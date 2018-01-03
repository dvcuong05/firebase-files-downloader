using Firebase.Auth;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.classes
{

    public class FileWatcher
    {
        public static string ApiKey = "AIzaSyAR1RquRt9K-xMTaCUvRUoaj1asVtU5ivc";
        public static string Bucket = "vncud-centraldb.appspot.com";
        public static string AuthEmail = "teescapeuser@gmail.com";
        public static string AuthPassword = "8112hj47124";


        public static void handleFolderChange(string folderPath)
        {
            try
            {
                List<string> listFilePath = new List<string>();
                foreach (string f in Directory.GetFiles(folderPath))
                {
                    string fileExtension = Path.GetExtension(f).ToUpper();
                    //if (fileExtension == ".TXT" || fileExtension == ".PNG" || fileExtension == ".JPEG" || fileExtension == ".JPG")
                    if (fileExtension == ".TXT")
                    {
                        uploadFile(f);
                        /*listFilePath.Add(f);
                        if (fileExtension == ".TXT")
                        {
                            uploadFile(f);
                        }*/
                    }
                }
                if (listFilePath.Count > 0)
                {
                    for (int i = 0; i < listFilePath.Count; i++)
                    {
                        handleUploadFile(listFilePath[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("vncud*** handleFolderChange has exception."+ex.Message);
            }
        }

        public static async void handleUploadFile(string filePath)
        {
            string folderName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);

            try
            {
                var auth = new FirebaseAuthProvider(new Firebase.Auth.FirebaseConfig(ApiKey));
                var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);


                // Construct FirebaseStorage with path to where you want to upload the file and put it there
                var task = new FirebaseStorage(Bucket, new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                    ThrowOnCancel = true // when you cancel the upload, exception is thrown. By default no exception is thrown
                })
                 .Child("teescape")
                 .Child(folderName)
                 .Child(fileName).GetDownloadUrlAsync();
                var downloadUrl = await task;
                //Console.WriteLine("vncud** file: '" + fileName + "' has download url:" + downloadUrl);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("vncud*** '"+ fileName + "' is not existing=> start uploading:" + ex.Message);
                uploadFile(filePath);
            }
        }
        /*public static void Main(string[] args)
        {
            string filePath = "D:\\Temporary\\teescape\\parent_pic3.png";
            string folderName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);
            string fileNameOnly = Path.GetFileNameWithoutExtension(filePath);
            string newFilePath = folderName + Path.DirectorySeparatorChar + fileNameOnly + "_bk" + fileExtension;
            string newFilePath2 = folderName + Path.DirectorySeparatorChar + fileNameOnly + "_bk" + fileExtension;
        }*/
        public static async void uploadFile(string filePath)
        {
            string folderName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);
            string fileNameOnly = Path.GetFileNameWithoutExtension(filePath);
            try
            {
                string newFilePath = folderName + Path.DirectorySeparatorChar + fileNameOnly + "_bk" + fileExtension;
                File.Copy(filePath, newFilePath);
                if (fileName.Equals("styleTemplates.txt") || fileName.Equals("stopwords.txt"))
                {
                    folderName = "assets";
                }
                var auth = new FirebaseAuthProvider(new Firebase.Auth.FirebaseConfig(ApiKey));
                var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);

                // Get any Stream — it can be FileStream, MemoryStream or any other type of Stream
                FileStream stream = File.Open(newFilePath, FileMode.Open);

                // Construct FirebaseStorage with path to where you want to upload the file and put it there
                var task = new FirebaseStorage(Bucket, new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                    ThrowOnCancel = true // when you cancel the upload, exception is thrown. By default no exception is thrown
                })
                 .Child("teescape")
                 .Child(folderName)
                 .Child(fileName)
                 .PutAsync(stream);
                //Console.WriteLine("vncud*** uploading image '" + fileName + "' into folder '" + folderName + "'");
                //task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");
                var downloadUrl = await task;
                //Console.WriteLine("vncud*** upload file '"+ fileName + "' is done."+ downloadUrl);
                stream.Close();
                stream.Dispose();
                File.Delete(newFilePath);
            }
            catch (Exception ex)
            {
                // Console.WriteLine("vncud*** upload '" + fileName + "' has error:" + ex.Message);
            }
        }
    }
}

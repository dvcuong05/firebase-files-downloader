using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class TeescapeInstance
    {
        private static string currentFolderPath;
		private static int totalDownloadingFile;
		
		public static int TotalDownloadingFile
        {
            get
            {
                return totalDownloadingFile;
            }

            set
            {
                totalDownloadingFile = value;
            }
        }
		
        public static string CurrentFolderPath
        {
            get
            {
                return currentFolderPath;
            }

            set
            {
                currentFolderPath = value;
            }
        }
        

        public static T Clone<T>(T source)
        {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }

        public static bool isEmpty(string data)
        {
            return (data == null || data.Trim() == "");
        }


        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "ncc";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "ncc";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static string creatHandler(string title)
        {
            title = title.ToLower();
            char[] arr = title.ToCharArray();

            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c)
                                              || char.IsWhiteSpace(c)
                                              || c == '_'
                                              || c == '-'))); 
           
            string res = new string(arr);
            string[] doubleCheckArr = res.Split(' ');
            string final = "";
            foreach (string i in doubleCheckArr)
            {
                if (i != "-" && i != "")
                {
                    if (final != "")
                    {
                        final += "-";
                    }
                    final += i;
                }
            }
            return final;
        }

        public static string getFixedName(string originalName, string time)
        {
            int maxLength = 70 - time.Length;
            string fixedName = "";
            string[] arr = originalName.Split(' ');
            for (int i = 0; i < arr.Count(); i++)
            {
                string tmp = arr[i] + " ";
                if ((fixedName.Length + tmp.Length) <= maxLength)
                {
                    fixedName += tmp;
                }
            }
            return fixedName + time;
        }

       
       
    }
}

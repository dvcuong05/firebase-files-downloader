using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
using Newtonsoft.Json;
using System.Net;
using System.Reflection;
using CefSharp;
using CefSharp.WinForms;
using System.Diagnostics;
using System.Web;
using System.Security;
using Main.classes;
using System.Threading;
using System.Drawing.Imaging;
using System.Timers;
using System.Drawing.Drawing2D;

namespace Main
{
    public partial class Main : Form
    {
        private ChromiumWebBrowser mainWebBrowser;
        private String step;
        private List<object> folderList = new List<object>();
        private int currentFolderIndex = -1;
        private int totalFilesOfCurrent = 0;
        private string currentCSSClassName = "";
        private bool isDownloadFileStep = false;

        CefSettings settings = new CefSettings();

        public Main()
        {
            try
            {
                InitializeComponent();
                settings.CachePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\assets\\caches";
                settings.PersistSessionCookies = true;
                settings.IgnoreCertificateErrors = true;
                settings.LogSeverity = LogSeverity.Error;
                
                Cef.Initialize(settings);

                BrowserSettings b = new BrowserSettings();                
                b.WebSecurity = CefState.Disabled;

                this.mainWebBrowser = new ChromiumWebBrowser("https://www.google.com/");
                this.mainWebBrowser.JsDialogHandler = new JsHandler();
                this.mainWebBrowser.BrowserSettings = b;
                this.mainWebBrowser.DownloadHandler = new DownloadHandler();
                this.mainWebBrowser.Dock = DockStyle.Fill;
                this.mainWebBrowser.Visible = false;
                //this.mainWebBrowser.FrameLoadEnd += mainWebBrowser_DocumentCompleteHandler;
                this.mainWebBrowser.LoadingStateChanged += mainWebBrowser_LoadingHandler;
                //this.mainWebBrowser.AddressChanged += mainWebBrowser_AdressChangeHandler;                
                //this.mainWebBrowser.ConsoleMessage += mainWebBrowser_ConsoleMessage;
                this.stopBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unhandled UI Exception1");
            }
        }
        
        private void mainWebBrowser_ConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            string consoleLog = "Current URL:" + mainWebBrowser.Address + "\n";
            consoleLog = consoleLog + "Console detail: Line: " + e.Line + " - Source: " + e.Source + " - Content:" + e.Message;
            writeLog(consoleLog);
        }

       


        private void mainWebBrowser_LoadingHandler(Object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {                
                switch (this.step)
                {
                    case "checkingFolderLoaded":
                        this.mainWebBrowser.Invoke((MethodInvoker)delegate
                        {
                            writeLog("Step: load folder content");
                        });
                        this.step = "checkingDOMLoadedAndScroll";
                        this.currentCSSClassName = "c5e-modulehost-scrollcontainer";
                        this.checkingDOMLoadedAndScroll(currentCSSClassName);
                        break;
                    case "accessFolderItem":
                        this.step = "checkingDOMLoadedAndScroll";
                        this.currentCSSClassName = "c5e-modulehost-content";
                        this.checkingDOMLoadedAndScroll(currentCSSClassName);
                        break;                        
                    default:
                        break;
                }                
            }
        }
        
     
        private void writeLog(string message)
        {
            try
            {
                this.mainWebBrowser.Invoke((MethodInvoker)delegate
                {
                    string result = "";
                    string[] lines = this.log.Text.Split(new[] { '\r', '\n' });
                    if(lines.Count() > 200)
                    {
                        for(int i =0; i<=200; i++)
                        {
                            result = result + lines[i] + "\n";
                        }
                    }
                    else
                    {
                        result = this.log.Text;
                    }
                    this.log.Text = result.Insert(0, message + "\n");
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("writeLog method has error:" + ex.Message);
            }
        }

        private void LoadSetting()
        {
            try
            {
                String filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\assets\\configs\\config.txt";
                string configStr = File.ReadAllText(filePath);
                AccountConfig config = Newtonsoft.Json.JsonConvert.DeserializeObject<AccountConfig>(configStr);
                folderTxt.Text = config.FirebaseFolder;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong, Please make sure that the firebase account is configured", "Warning");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                this.splitContainer.Panel2.Controls.Add(this.mainWebBrowser);
                this.splitContainer.Panel2.Enabled = true;
                this.mainWebBrowser.Visible = true;
                LoadSetting();
                this.log.Text = " * **Ready***\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unhandled UI Exception2");
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            SettingPanel settingPal = new SettingPanel();
            settingPal.ShowDialog();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.mainWebBrowser.Load(folderTxt.Text);
            this.step = "checkingFolderLoaded";
            writeLog("------Loading: " + folderTxt.Text);
        }

        private async void checkingDOMLoadedAndScroll(string className)
        {
            if (this.step != "checkingDOMLoadedAndScroll")
            {
                return;
            }

            try
            {
                await Task.Delay(3000);
                var domTask = this.mainWebBrowser.EvaluateScriptAsync("(function(){var rendered=$('.fb-table-elem').length;if(rendered!=0){$('."+className+ "').scrollTop($('." + className + "')[0].scrollHeight);return 200;}return 400;})()");
                await domTask.ContinueWith(t =>
                {
                    if (!t.IsFaulted)
                    {
                        var response = t.Result;
                        if (response.Success && response.Result != null)
                        {
                            string responseNum = response.Result.ToString();
                            if (responseNum == "200")
                            {
                                this.mainWebBrowser.Invoke((MethodInvoker)delegate
                                {
                                    if (this.step == "checkingScrollAtTheEnd")
                                    {
                                        return;
                                    }
                                    this.step = "checkingScrollAtTheEnd";
                                    checkingScrollAtTheEnd(this.currentCSSClassName);
                                });
                            }
                            else
                            {
                                checkingDOMLoadedAndScroll(this.currentCSSClassName);
                            }
                        }
                        else
                        {
                            writeLog(response.Message);
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                writeLog("checkingDOMLoadedAndScroll has error:" + ex.Message);
            }
        }

        private async void checkingScrollAtTheEnd(string className)
        {
            if (this.step != "checkingScrollAtTheEnd")
            {
                return;
            }

            try
            {
                await Task.Delay(3000);
                var domTask = this.mainWebBrowser.EvaluateScriptAsync("(function(){var elem=$('." + className + "');if(elem[0].scrollHeight-elem.scrollTop()==elem.outerHeight()){return 200;}else{$('." + className + "').scrollTop($('." + className+"')[0].scrollHeight);return 404;}return 400;})();");
                await domTask.ContinueWith(t =>
                {
                    if (!t.IsFaulted)
                    {
                        var response = t.Result;
                        if (response.Success && response.Result != null)
                        {
                            string responseNum = response.Result.ToString();
                            if (responseNum == "200")
                            {
                                this.mainWebBrowser.Invoke((MethodInvoker)delegate
                                {                                    
                                    if (!this.isDownloadFileStep)
                                    {
                                        if (this.step == "getListOfFolderLinks")
                                        {
                                            return;
                                        }
                                        this.step = "getListOfFolderLinks";
                                        getListOfFolderLinks();
                                    }
                                    else
                                    {
                                        if (this.step == "downloadingFileForFolder")
                                        {
                                            return;
                                        }
                                        this.step = "downloadingFileForFolder";
                                        downloadFileForFolder();
                                    }
                                });
                            }
                            else
                            {
                                this.step = "checkingDOMLoadedAndScroll";
                                checkingDOMLoadedAndScroll(className);
                            }
                        }
                        else
                        {
                            writeLog(response.Message);
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                writeLog("checkingScrollAtTheEnd has error:" + ex.Message);
            }
        }

        private async void getListOfFolderLinks()
        {
            if(this.step != "getListOfFolderLinks")
            {
                return;
            }

            try
            {
                await Task.Delay(5000);
                var domTask = this.mainWebBrowser.EvaluateScriptAsync("(function(){var rendered=$('.fb-table-elem').length;if(rendered!=0){var total=$('.fb-table-has-icon').length;var result=[];for(var i=0;i<total;i++){result.push($('.fb-table-has-icon')[i].href);}return result;}return 404;})()");
                await domTask.ContinueWith(t =>
                {
                    if (!t.IsFaulted)
                    {
                        var response = t.Result;
                        if (response.Success && response.Result != null)
                        {
                            string responseNum = response.Result.ToString();
                            if (response.Result.ToString() != "404")
                            {
                                this.mainWebBrowser.Invoke((MethodInvoker)delegate
                                {
                                    if (this.step == "accessFolderItem")
                                    {
                                        return;
                                    }
                                    this.folderList = (List<object>)response.Result;
                                    this.step = "accessFolderItem";
                                    this.currentFolderIndex = 0;
                                    accessFolderItem();
                                });
                            }
                            else
                            {
                                getListOfFolderLinks();
                            }
                        }
                        else
                        {
                            writeLog(response.Message);
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                writeLog("getListOfFolderLinks has error:" + ex.Message);
            }
        }

        private void accessFolderItem()
        {
            this.mainWebBrowser.Load(this.folderList[this.currentFolderIndex].ToString());
            this.step = "accessFolderItem";
            this.isDownloadFileStep = true;
            writeLog("------Step - accessFolderItem:");
            writeLog(this.folderList[this.currentFolderIndex].ToString());

        }

        private async void downloadFileForFolder()
        {
            if (this.step != "downloadingFileForFolder")
            {
                return;
            }

            try
            {
                await Task.Delay(5000);                
                //Calculate folder name
                string folderName = HttpUtility.UrlDecode(this.folderList[this.currentFolderIndex].ToString());
                folderName = folderName.Substring(folderName.LastIndexOf(this.folderTxt.Text) + this.folderTxt.Text.Length);
                folderName = folderName.Replace("\\","").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
                TeescapeInstance.CurrentFolderPath = this.outputFolderTxt.Text+"\\"+ folderName;
                System.IO.Directory.CreateDirectory(TeescapeInstance.CurrentFolderPath);

                //Start to download with current folderPath from Instance
                var domTask = this.mainWebBrowser.EvaluateScriptAsync("(function(){var rendered=$('.fb-table-elem').length;if(rendered!=0){setTimeout(function(){if(!$('md-checkbox[aria-label=\"Select all items\"]').hasClass('md-checked')){$('md-checkbox[aria-label=\"Select all items\"]').click();}$('button[multi-download]').click();},1000);return $('.uploaded-files').length;}return 404;})()");
                await domTask.ContinueWith(t =>
                {
                    if (!t.IsFaulted)
                    {
                        var response = t.Result;
                        if (response.Success && response.Result != null)
                        {
                            int responseNum = Convert.ToInt32(response.Result.ToString());
                            if (responseNum != 404)
                            {
                                this.mainWebBrowser.Invoke((MethodInvoker)delegate
                                {
                                    if (this.step == "checkTotalDownloadedFiles")
                                    {
                                        return;
                                    }
                                    this.step = "checkTotalDownloadedFiles";
                                    this.totalFilesOfCurrent = responseNum;
                                    checkTotalDownloadedFiles();
                                });
                            }
                            else
                            {
                                downloadFileForFolder();
                            }
                        }
                        else
                        {
                            writeLog(response.Message);
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                writeLog("downloadFileForFolder has error:" + ex.Message);
            }
        }

        private void checkTotalDownloadedFiles()
        {
            if(this.step != "checkTotalDownloadedFiles")
            {
                return;
            }

            string[] fileEntries = Directory.GetFiles(TeescapeInstance.CurrentFolderPath);
            if(fileEntries.Length != this.totalFilesOfCurrent)
            {
                System.Threading.Thread.Sleep(5000);
                checkTotalDownloadedFiles();
            }
            else
            {
                //Download next folder
                this.currentFolderIndex = this.currentFolderIndex + 1;
                if (this.currentFolderIndex >= this.folderList.Count)
                {
                    writeLog("****All done");
                    return;
                }
                this.accessFolderItem();
            }
        }
    }

}
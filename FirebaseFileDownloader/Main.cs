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
                        this.checkingFolderLoaded();
                        break;
                    case "downloadFileForFolder":
                        this.downloadFileForFolder(this.currentFolderIndex);
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

        private async void checkingFolderLoaded()
        {
            if(this.step != "checkingFolderLoaded")
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
                                    if (this.step == "downloadFileForFolder")
                                    {
                                        return;
                                    }
                                    this.folderList = (List<object>)response.Result;
                                    this.step = "downloadFileForFolder";
                                    this.currentFolderIndex = 0;
                                    accessFolderItem(this.currentFolderIndex);

                                    //this.mainWebBrowser.EvaluateScriptAsync("(function(index){$('.fb-table-has-icon')[index].click();})(" + this.currentFolderIndex + ");");
                                   // System.Threading.Thread.Sleep(2000);
                                    //downloadFileForFolder(this.currentFolderIndex);
                                });
                            }
                            else
                            {
                                if (this.step == "checkingFolderLoaded")
                                {
                                    return;
                                }
                                this.step = "checkingFolderLoaded";
                                checkingFolderLoaded();
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
                writeLog("checkingFolderLoaded has error:" + ex.Message);
            }
        }

        private void accessFolderItem(int index)
        {
            this.mainWebBrowser.Load(this.folderList[index].ToString());
            this.step = "downloadFileForFolder";
            writeLog("------Loading:");
            writeLog(this.folderList[this.currentFolderIndex].ToString());

        }

        private async void downloadFileForFolder(int index)
        {
            if (this.step != "downloadFileForFolder")
            {
                return;
            }

            try
            {
                await Task.Delay(5000);
                var domTask = this.mainWebBrowser.EvaluateScriptAsync("(function(){var rendered=$('.fb-table-elem').length;if(rendered!=0){$('md-checkbox[aria-label=\"Select all items\"]').click();setTimeout(function(){$('button[multi-download]').click();},2000)return 200;}return 404;})()");
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
                                    if (this.step == "downloadFolderItem")
                                    {
                                        return;
                                    }
                                    this.currentFolderIndex = this.currentFolderIndex + 1;
                                    if(this.currentFolderIndex <= this.folderList.Count)
                                    {
                                        writeLog("All done");
                                        return;
                                    }
                                    this.accessFolderItem(this.currentFolderIndex);
                                });
                            }
                            else
                            {
                                if (this.step == "downloadFileForFolder")
                                {
                                    return;
                                }
                                this.step = "downloadFileForFolder";
                                downloadFileForFolder(index);
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
                writeLog("checkingFolderLoaded has error:" + ex.Message);
            }
        }
    }

}
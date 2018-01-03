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
        private String loginStatus = "";
        private String logoutUrl = "https://www.shopify.com/logout";
        private String loginUrl = "https://www.shopify.com/login";
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
                if (this.loginStatus == "logged")
                {
                    switch (this.step)
                    {
                        case "initApp":
                            this.mainWebBrowser.Invoke((MethodInvoker)delegate
                            {
                                writeLog("Step: initApp");
                            });
                            //this.InitTheSession();
                            break;
                        case "upload":
                            //this.processUpload();
                            this.mainWebBrowser.Invoke((MethodInvoker)delegate
                            {
                                //updateProcessBarValue(1);
                                writeLog("Step: upload");
                            });
                            break;                        
                        default:
                            break;
                    }

                }
                else if (this.loginStatus == "" && this.step == "processLogin")
                {
                    //processLogin();
                }
                else if (this.loginStatus == "" && this.step == "logging" 
                    && e.Browser.MainFrame.Url != this.loginUrl && !e.Browser.MainFrame.Url.Contains("/login"))
                {
                    this.mainWebBrowser.Invoke((MethodInvoker)delegate
                    {
                        this.step = "logged";
                        this.folderTxt.Enabled = true;
                        string currentUrl = e.Browser.MainFrame.Url;
                        string mainUrl = ".myshopify.com";
                        //this.storeUrl = currentUrl.Substring(0, currentUrl.IndexOf(".myshopify.com"))+ mainUrl;
                       // saveOrLoadShopConfigs(this.storeUrl);
                        //updateLoginStatus();
                    });
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
                MessageBox.Show(ex.Message, "Load config is fail:");
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
            writeLog("------Loading: " + folderTxt.Text);
        }
    }

}
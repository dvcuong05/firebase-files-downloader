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
        private string keywordIOURL = "https://www.keyword.io/tool/google-longtail-finder?q=#&audience=en-us";
        private String uploadUrl = "/admin/apps/teescape-fulfillment/active/shopify/uploader.asp";
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

                //saveOrLoadShopConfigs(null);
                string startUrl = "https://shopify.com";
               /* if(this.shopConfig.ShopName != null && this.shopConfig.ShopName != "")
                {
                    startUrl = this.shopConfig.ShopName+"/admin";
                    this.storeUrl = this.shopConfig.ShopName;
                    this.step = "logging";
                    this.username.Enabled = false;
                    this.password.Enabled = false;
                    this.logoutBtn.Enabled = false;
                    this.buttonLogin.Enabled = false;
                }*/
                this.mainWebBrowser = new ChromiumWebBrowser(startUrl);
                this.mainWebBrowser.JsDialogHandler = new JsHandler();
                this.mainWebBrowser.BrowserSettings = b;

                this.mainWebBrowser.Dock = DockStyle.Fill;
                this.mainWebBrowser.Visible = false;
                //this.mainWebBrowser.FrameLoadEnd += mainWebBrowser_DocumentCompleteHandler;
                this.mainWebBrowser.LoadingStateChanged += mainWebBrowser_LoadingHandler;
                this.mainWebBrowser.AddressChanged += mainWebBrowser_AdressChangeHandler;                
                //this.mainWebBrowser.ConsoleMessage += mainWebBrowser_ConsoleMessage;
                this.stopBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unhandled UI Exception1");
            }
        }

        private void mainWebBrowser_AdressChangeHandler(object sender, AddressChangedEventArgs e)
        {
            try
            {
                if (e.Address.Contains("/admin/auth/login"))
                {
                    System.Threading.Thread.Sleep(4000);
                    string username = this.username.Text;
                    string password = this.password.Text;
                    this.mainWebBrowser.ExecuteScriptAsync("(function(username,password){var evt=document.createEvent('MouseEvents');evt.initEvent('input',true,true);var form=$('form');var email=form.find('[name=login][type=email]')[0];email.value=username;email.dispatchEvent(evt);var passwordDom=form.find('[name=password][type=password]')[0];passwordDom.value=password;passwordDom.dispatchEvent(evt);form.find('[name=button][type=submit]').click();setTimeout(function(){try{var iframes=$('iframe'); iframes[0].contentDocument.getElementsByClassName('recaptcha-checkbox-checkmark')[0].click();}catch(e){}},2500)})('" + username + "','" + password + "')");
                    Console.WriteLine("vncud address change" + e.Address);
                }
            }
            catch (Exception ex)
            {
                writeLog("mainWebBrowser_AdressChangeHandler - error is:"+ex.Message);
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
                            this.timer.Stop();
                            this.mainWebBrowser.Invoke((MethodInvoker)delegate
                            {
                                writeLog("Step: initApp");
                            });
                            //this.InitTheSession();
                            break;
                        case "upload":
                            this.timer.Stop();
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
                    processLogin();
                }
                else if (this.loginStatus == "" && this.step == "logging" 
                    && e.Browser.MainFrame.Url != this.loginUrl && !e.Browser.MainFrame.Url.Contains("/login"))
                {
                    this.mainWebBrowser.Invoke((MethodInvoker)delegate
                    {
                        this.step = "logged";
                        this.username.Enabled = true;
                        this.password.Enabled = true;
                        this.logoutBtn.Enabled = true;
                        this.buttonLogin.Enabled = true;
                        string currentUrl = e.Browser.MainFrame.Url;
                        string mainUrl = ".myshopify.com";
                        //this.storeUrl = currentUrl.Substring(0, currentUrl.IndexOf(".myshopify.com"))+ mainUrl;
                       // saveOrLoadShopConfigs(this.storeUrl);
                        //updateLoginStatus();
                    });
                }
            }
        }
        

        // process login
        private void processLogin()
        {
            if (this.step == "processLogin")
            {
                this.step = "logging";
                this.checkingLoginForm();
            }
        }
        private async void checkingLoginForm()
        {
            try
            {
                //ShopifyLoginForm
                await Task.Delay(1000);
                var domTask = this.mainWebBrowser.EvaluateScriptAsync("(function(){var rendered=$('#ShopifyLoginForm').length;if(rendered!=0){var subDoms=$('input[name=\"subdomain\"]');if(subDoms.length!=0){subDoms.val('');subDoms.trigger('change');}}return rendered;})()");
                await domTask.ContinueWith(t =>
                 {
                     if (!t.IsFaulted)
                     {
                         var response = t.Result;
                         if (response.Success && response.Result != null)
                         {
                             bool isDomExisted = Convert.ToInt32(response.Result.ToString()) != 0;
                             if (isDomExisted)
                             {
                                 this.mainWebBrowser.Invoke((MethodInvoker)delegate
                                 {
                                     this.processingLogin();
                                 });
                             }
                             else
                             {
                                 this.mainWebBrowser.Invoke((MethodInvoker)delegate
                                 {
                                     this.checkingLoginForm();
                                 });

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
                Console.WriteLine("checkingLoginForm has error:" + ex.Message);
            }
        }
        private void processingLogin()
        {
            string username = this.username.Text;
            string password = this.password.Text;
            this.mainWebBrowser.ExecuteScriptAsync("(function(username,password){var evt=document.createEvent('MouseEvents');evt.initEvent('input',true,true);var form=$('#ShopifyLoginForm');var email=form.find('[name=login][type=email]')[0];email.value=username;email.dispatchEvent(evt);var passwordDom=form.find('[name=password][type=password]')[0];passwordDom.value=password;passwordDom.dispatchEvent(evt);form.find('[name=button][type=submit]').click();})('" + username + "','" + password + "')");
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
        
    }

}
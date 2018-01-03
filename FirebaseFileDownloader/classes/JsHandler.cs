using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.classes
{
    class JsHandler: IJsDialogHandler
    {
	public bool OnJSAlert(IWebBrowser browser, string url, string message)
    {

        return true;
    }

    public bool OnJSConfirm(IWebBrowser browser, string url, string message, out bool retval)
    {
        retval = true;
        return true;
    }

    public bool OnJSPrompt(IWebBrowser browser, string url, string message, string defaultValue, out bool retval, out string result)
    {
        retval = true;
        result="";
        return true;
    }

    public void OnDialogClosed(IWebBrowser browserControl, IBrowser browser)
    {
    }

    public bool OnJSBeforeUnload(IWebBrowser browserControl, IBrowser browser, string message, bool isReload, IJsDialogCallback callback)
    {
        callback.Continue(true);
        return true;
    }	

    public bool OnJSDialog(IWebBrowser browserControl, IBrowser browser, string originUrl, CefJsDialogType dialogType, string messageText, string defaultPromptText, IJsDialogCallback callback, ref bool suppressMessage)
    {
        callback.Continue(true);
        return true;
    }

    public void OnResetDialogState(IWebBrowser browserControl, IBrowser browser)
    {
       
    }
    }
}

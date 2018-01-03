using CefSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Main.classes
{
    class DownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        public void OnBeforeDownload(IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            var handler = OnBeforeDownloadFired;
            String filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\assets\\images";
            if (handler != null)
            {
                handler(this, downloadItem);
            }

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(filePath +"\\"+downloadItem.SuggestedFileName, showDialog: false);
                }
            }
        }

        public void OnDownloadUpdated(IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            var handler = OnDownloadUpdatedFired;
            if (handler != null)
            {
                handler(this, downloadItem);
            }
        }
    }
}

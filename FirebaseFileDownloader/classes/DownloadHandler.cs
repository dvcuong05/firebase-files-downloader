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
            
            if (handler != null)
            {
                handler(this, downloadItem);
            }

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    string filePath = TeescapeInstance.CurrentFolderPath + "\\" + downloadItem.SuggestedFileName;
                    if (!File.Exists(filePath))
                    {
                        if(filePath.Length > 255)
                        {
                            filePath = TeescapeInstance.CurrentFolderPath + "\\vncud_long_" + DateTime.Now + ".png";
                        }
                        callback.Continue(filePath, showDialog: false);
                    }else
                    {
                        TeescapeInstance.TotalDownloadingFile = TeescapeInstance.TotalDownloadingFile - 1;
                        //downloadItem.IsCancelled = true;
                        //downloadItem.IsComplete = true;
                        //downloadItem.IsValid = false;

                        ///callback.Dispose();
                    }
                    
                }
            }
            else
            {
                TeescapeInstance.TotalDownloadingFile = TeescapeInstance.TotalDownloadingFile - 1;
            }
        }

        public void OnDownloadUpdated(IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            var handler = OnDownloadUpdatedFired;
            if (handler != null)
            {
                handler(this, downloadItem);
            }
            if (downloadItem.IsComplete || downloadItem.IsCancelled)
            {
                TeescapeInstance.TotalDownloadingFile = TeescapeInstance.TotalDownloadingFile - 1;
                callback.Dispose();
            }
        }
      
    }
}

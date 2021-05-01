using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSize
{
    public static class Utilities
    {
        public static void OpenLink(string link)
        {
            var procInfo = new ProcessStartInfo();
            procInfo.FileName = "cmd.exe";
            procInfo.ArgumentList.Add("/c");
            procInfo.ArgumentList.Add("start");
            procInfo.ArgumentList.Add(link);
            Process.Start(procInfo);
        }

        public static void OpenLink(Uri uri) => OpenLink(uri.ToString());

        public static void ShowInExplorer(string path)
        {
            var procInfo = new ProcessStartInfo();
            procInfo.FileName = "explorer.exe";
            procInfo.ArgumentList.Add("/select,");
            procInfo.ArgumentList.Add(path);
            Process.Start(procInfo);
        }
    }
}

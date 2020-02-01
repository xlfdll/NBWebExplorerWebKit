using System;
using System.IO;
using System.Text;

using Xlfdll.IO;

namespace NBWebExplorerWebKit
{
    internal static class IOHelper
    {
        internal static void CreateInternetShortcutFile(String path, String title, String url)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[InternetShortcut]");
            sb.AppendLine("URL=" + url);

            String fileName = Path.Combine(path, PathExtensions.GetSafeFileName(title + ".url"));

            File.WriteAllText(fileName, sb.ToString());
        }
    }
}
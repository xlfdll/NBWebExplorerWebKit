using System;

using Xlfdll.Configuration;

namespace NBWebExplorerWebKit
{
    internal class AppSettings : ApplicationSettings
    {
        internal AppSettings(ApplicationConfiguration appConfiguration)
            : base(appConfiguration)
        {
            this.Provider.Current.TryAddValue("Main", "HomePage", "about:blank");
            this.Provider.Current.TryAddValue("Main", "SourceViewer", @"C:\Windows\Notepad.exe");
        }

        internal String HomePage
        {
            get { return this.Provider.Current["Main"]["HomePage"]; }
            set { this.Provider.Current["Main"]["HomePage"] = value; }
        }
        internal String SourceViewer
        {
            get { return this.Provider.Current["Main"]["SourceViewer"]; }
            set { this.Provider.Current["Main"]["SourceViewer"] = value; }
        }
    }
}
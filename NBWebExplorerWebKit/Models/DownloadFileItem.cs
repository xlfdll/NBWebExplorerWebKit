using System;

namespace NBWebExplorerWebKit
{
    public class DownloadFileItem
    {
        private String _sourceURL;
        private String _destinationPath;
        private Int32 _progress;

        public String SourceURL
        {
            get { return _sourceURL; }
            set { _sourceURL = value; }
        }

        public String DestinationPath
        {
            get { return _destinationPath; }
            set { _destinationPath = value; }
        }

        public Int32 Progress
        {
            get { return _progress; }
            set { _progress = value; }
        }
    }
}
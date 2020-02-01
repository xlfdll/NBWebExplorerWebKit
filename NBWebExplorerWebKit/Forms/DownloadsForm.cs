using System;
using System.Windows.Forms;

using WebKit;

namespace NBWebExplorerWebKit
{
    public partial class DownloadsForm : Form
    {
        public DownloadsForm()
        {
            InitializeComponent();
        }

        private void downloadListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = sender as ListView;

            if (listView != null)
            {
                if (listView.SelectedItems.Count > 0)
                {
                    DownloadFileItem downloadFileItem = listView.SelectedItems[0].Tag as DownloadFileItem;

                    if (downloadFileItem != null)
                    {
                        downloadSourceTextBox.Text = downloadFileItem.SourceURL;
                        downloadDestinationTextBox.Text = downloadFileItem.DestinationPath;
                        downloadProgressBar.Value = downloadFileItem.Progress;
                    }
                }
            }
        }
    }
}

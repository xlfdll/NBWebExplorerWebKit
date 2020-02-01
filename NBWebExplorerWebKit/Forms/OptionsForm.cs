using System;
using System.Windows.Forms;

namespace NBWebExplorerWebKit
{
    public partial class OptionsForm : Form
    {
        private OptionsForm()
        {
            InitializeComponent();
        }

        public OptionsForm(WebBrowserTabPage webBrowserTabPage)
            : this()
        {
            homePageTextBox.Tag = webBrowserTabPage.Browser.Url.OriginalString;
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            homePageTextBox.Text = ApplicationHelper.Settings.HomePage;
            sourceViewerTextBox.Text = ApplicationHelper.Settings.SourceViewer;
        }

        private void useCurrentPageButton_Click(object sender, EventArgs e)
        {
            homePageTextBox.Text = homePageTextBox.Tag.ToString();
        }

        private void useBlankPageButton_Click(object sender, EventArgs e)
        {
            homePageTextBox.Text = "about:blank";
        }

        private void sourceViewerBrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    sourceViewerTextBox.Text = dlg.FileName;
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(homePageTextBox.Text))
            {
                MessageBox.Show(this, "Home Page is empty.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ApplicationHelper.Settings.HomePage = homePageTextBox.Text;
            ApplicationHelper.Settings.SourceViewer = sourceViewerTextBox.Text;

            ApplicationHelper.Settings.Provider.Save();

            this.Close();
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

using Xlfdll.IO;

namespace NBWebExplorerWebKit
{
    public partial class NewFavoriteFolderForm : Form
    {
        public NewFavoriteFolderForm(ComboBox parentLocationComboBox)
        {
            InitializeComponent();

            foreach (Object item in parentLocationComboBox.Items)
            {
                locationComboBox.Items.Add(item);
            }

            locationComboBox.SelectedIndex = parentLocationComboBox.SelectedIndex;
        }

        private String _newFolderPath;

        public String NewFolderPath
        {
            get { return _newFolderPath; }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !String.IsNullOrEmpty(nameTextBox.Text);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            FavoriteFolderItem parentFolderItem = locationComboBox.SelectedItem as FavoriteFolderItem;
            String parentPath = parentFolderItem.FullPath;
            String newFolderPath = PathExtensions.GetSafePath(Path.Combine(parentPath, nameTextBox.Text));

            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);

                _newFolderPath = newFolderPath;

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show(this, "The specified directory already exists.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
using System;
using System.IO;
using System.Windows.Forms;

using Xlfdll.IO;

namespace NBWebExplorerWebKit
{
    public partial class NewFavoriteFolderForm : Form
    {
        public NewFavoriteFolderForm(Int32 selectedIndex)
        {
            InitializeComponent();

            locationComboBox.Tag = selectedIndex;
        }

        private String _newFolderName;

        public String NewFolderName
        {
            get { return _newFolderName; }
        }

        private void NewFavoriteFolderForm_Load(object sender, EventArgs e)
        {
            locationComboBox.Items.Add("Favorites");

            FormHelper.AddFavoriteFolders(locationComboBox, Environment.GetFolderPath(Environment.SpecialFolder.Favorites), 1);

            locationComboBox.SelectedIndex = (Int32)(locationComboBox.Tag);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !String.IsNullOrEmpty(nameTextBox.Text);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            String parentPath = FormHelper.GetSelectedFavoriteFolderPath(locationComboBox);
            String newFolderPath = PathExtensions.GetSafePath(Path.Combine(parentPath, nameTextBox.Text));

            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);

                _newFolderName = locationComboBox.SelectedItem.ToString() + @"\" + nameTextBox.Text;

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
using System;
using System.Windows.Forms;

namespace NBWebExplorerWebKit
{
    public partial class NewFavoriteFolderForm : Form
    {
        public NewFavoriteFolderForm()
        {
            InitializeComponent();
        }

        private void NewFavoriteFolderForm_Load(object sender, EventArgs e)
        {
            FormHelper.AddFavoriteFolders(locationComboBox, Environment.GetFolderPath(Environment.SpecialFolder.Favorites), 1);

            locationComboBox.SelectedIndex = 0;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !String.IsNullOrEmpty(nameTextBox.Text);
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace NBWebExplorerWebKit
{
    public partial class AddToFavoritesForm : Form
    {
        private AddToFavoritesForm()
        {
            InitializeComponent();
        }

        public AddToFavoritesForm(String title, String url)
            : this()
        {
            titleTextBox.Text = title;
            titleTextBox.Tag = url;
        }

        private void AddFavoriteForm_Load(object sender, EventArgs e)
        {
            locationComboBox.Items.Clear();

            FormHelper.AddFavoriteFolders(locationComboBox, Environment.GetFolderPath(Environment.SpecialFolder.Favorites), 0);

            locationComboBox.SelectedIndex = 0;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !String.IsNullOrEmpty(titleTextBox.Text);
        }

        private void newFolderButton_Click(object sender, EventArgs e)
        {
            using (NewFavoriteFolderForm form = new NewFavoriteFolderForm(locationComboBox))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    locationComboBox.Items.Clear();

                    AddFavoriteForm_Load(sender, e);

                    FavoriteFolderItem newFolderItem = FormHelper.FindSpecificFavoriteFolder
                        (form.NewFolderPath, locationComboBox.Items[0] as FavoriteFolderItem);

                    locationComboBox.SelectedItem = newFolderItem;
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            foreach (Char c in Path.GetInvalidFileNameChars())
            {
                if (titleTextBox.Text.Contains(c.ToString()))
                {
                    MessageBox.Show(this, "Title cannot have invalid character '" + c + "'.", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
            }

            IOHelper.CreateInternetShortcutFile
                ((locationComboBox.SelectedItem as FavoriteFolderItem).FullPath,
                titleTextBox.Text, titleTextBox.Tag.ToString());

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}

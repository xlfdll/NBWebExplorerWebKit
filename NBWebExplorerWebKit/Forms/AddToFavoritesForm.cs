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

            this.Tag = url;
        }

        private void AddFavoriteForm_Load(object sender, EventArgs e)
        {
            locationComboBox.Items.Add("Favorites");

            FormHelper.AddFavoriteFolders(locationComboBox, Environment.GetFolderPath(Environment.SpecialFolder.Favorites), 1);

            locationComboBox.SelectedIndex = 0;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !String.IsNullOrEmpty(titleTextBox.Text);
        }

        private void newFolderButton_Click(object sender, EventArgs e)
        {
            using (NewFavoriteFolderForm form = new NewFavoriteFolderForm(locationComboBox.SelectedIndex))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    locationComboBox.Items.Clear();

                    AddFavoriteForm_Load(sender, e);

                    String[] newFolderNameEntries = form.NewFolderName.Split
                        (new String[] { @"\" },
                        StringSplitOptions.RemoveEmptyEntries);

                    for (Int32 i = locationComboBox.Items.IndexOf(newFolderNameEntries[0]); i < locationComboBox.Items.Count; i++)
                    {
                        if (locationComboBox.Items[i].ToString().Trim() == newFolderNameEntries[1])
                        {
                            locationComboBox.SelectedIndex = i;

                            break;
                        }
                    }
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
                (FormHelper.GetSelectedFavoriteFolderPath(locationComboBox),
                titleTextBox.Text, this.Tag.ToString());

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}

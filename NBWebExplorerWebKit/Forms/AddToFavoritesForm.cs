using System;
using System.Text;
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
            FormHelper.AddFavoriteFolders(locationComboBox, Environment.GetFolderPath(Environment.SpecialFolder.Favorites), 1);

            locationComboBox.SelectedIndex = 0;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !String.IsNullOrEmpty(titleTextBox.Text);
        }

        private void newFolderButton_Click(object sender, EventArgs e)
        {
            using (NewFavoriteFolderForm form = new NewFavoriteFolderForm())
            {
                form.ShowDialog(this);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Int32 selectedIndex = locationComboBox.SelectedIndex;
            StringBuilder sb = new StringBuilder();

            
        }
    }
}

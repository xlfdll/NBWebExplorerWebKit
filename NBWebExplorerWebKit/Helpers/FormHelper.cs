using System;
using System.IO;
using System.Windows.Forms;

namespace NBWebExplorerWebKit
{
    internal static class FormHelper
    {
        internal static String GetSelectedFavoriteFolderPath(ComboBox locationComboBox)
        {
            if (locationComboBox.SelectedIndex == 0)
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            }
            else
            {
                String currentPath = locationComboBox.SelectedItem.ToString().Trim();

                for (Int32 i = locationComboBox.SelectedIndex - 1; i > 0; i--)
                {
                    currentPath = Path.Combine(locationComboBox.Items[i].ToString().Trim(), currentPath);
                }

                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), currentPath);
            }
        }

        internal static void AddFavoriteFolders(ComboBox locationComboBox, String favoritePath, Int32 level)
        {
            String[] entries = Directory.GetDirectories(favoritePath);

            foreach (String entry in entries)
            {
                locationComboBox.Items.Add(new String(' ', level * FormHelper.FolderLevelMultiplier) + Path.GetFileNameWithoutExtension(entry));

                FormHelper.AddFavoriteFolders(locationComboBox, entry, level + 1);
            }
        }

        internal static Int32 GetFolderLabelLevel(String folderLabel)
        {
            Int32 spaceCount = 0;

            for (Int32 i = 0; Char.IsWhiteSpace(folderLabel[i]); i++)
            {
                spaceCount++;
            }

            return spaceCount / FormHelper.FolderLevelMultiplier;
        }

        internal const Int32 FolderLevelMultiplier = 2;
    }
}
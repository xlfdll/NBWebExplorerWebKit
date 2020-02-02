using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NBWebExplorerWebKit
{
    internal static class FormHelper
    {
        internal static FavoriteFolderItem AddFavoriteFolders(ComboBox locationComboBox, String favoritePath, Int32 level)
        {
            FavoriteFolderItem root = new FavoriteFolderItem(favoritePath, level);

            locationComboBox.Items.Add(root);

            String[] directories = Directory.GetDirectories(favoritePath);

            foreach (String directory in directories)
            {
                FavoriteFolderItem childItem = FormHelper.AddFavoriteFolders(locationComboBox, directory, level + 1);

                root.Children.Add(childItem.Name, childItem);
            }

            return root;
        }

        internal static FavoriteFolderItem FindSpecificFavoriteFolder(String fullPath, FavoriteFolderItem root)
        {
            fullPath = fullPath.Replace(root.FullPath, String.Empty).Trim('\\');

            Queue<String> nameQueue = new Queue<String>(fullPath.Split(new String[] { @"\" }, StringSplitOptions.RemoveEmptyEntries));

            FavoriteFolderItem currentFolderItem = root;

            while (nameQueue.Count > 0)
            {
                String name = nameQueue.Dequeue();

                if (currentFolderItem.Children.ContainsKey(name))
                {
                    currentFolderItem = currentFolderItem.Children[name];
                }
                else
                {
                    return null;
                }
            }

            return currentFolderItem;
        }
    }
}
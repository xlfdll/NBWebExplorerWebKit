using System;
using System.Collections.Generic;
using System.IO;

namespace NBWebExplorerWebKit
{
    public class FavoriteFolderItem
    {
        public FavoriteFolderItem(String fullPath, Int32 level)
        {
            _level = level;
            _name = Path.GetFileNameWithoutExtension(fullPath);
            _fullPath = fullPath;
            _children = new Dictionary<String, FavoriteFolderItem>();
        }

        private Int32 _level;
        private String _name;
        private String _fullPath;
        private Dictionary<String, FavoriteFolderItem> _children;

        public Int32 Level
        {
            get { return _level; }
        }

        public String Name
        {
            get { return _name; }
        }

        public String FullPath
        {
            get { return _fullPath; }
        }

        public Dictionary<String, FavoriteFolderItem> Children
        {
            get { return _children; }
        }

        public override String ToString()
        {
            return new String(' ', this.Level * FavoriteFolderItem.FolderLevelMultiplier) + this.Name;
        }

        internal const Int32 FolderLevelMultiplier = 2;
    }
}
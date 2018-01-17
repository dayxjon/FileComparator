using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparator
{
    class DirectoryClass
    {
        public List<FileItem> itemList;
        public List<DirectoryClass> directoryList;
        private int indent;

        public DirectoryClass()
        {
            itemList = new List<FileItem>();
            directoryList = new List<DirectoryClass>();
            indent = 0;
        }

        public DirectoryClass(int _indent)
        {
            itemList = new List<FileItem>();
            directoryList = new List<DirectoryClass>();
            indent = _indent;
        }

        public int GetNumItems()
        {
            return itemList.Count();
        }

        public int GetNumDirectories()
        {
            return itemList.Count();
        }
        public int GetIndent()
        {
            return indent;
        }

        public void AddItem()
        {


        }

        public void AddDirectory()
        {


        }

        public override string ToString()
        {
            return "testing?";
        }
    }
}

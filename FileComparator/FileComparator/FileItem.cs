using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparator
{
    class FileItem
    {
        public string name;
        public double size;

        public FileItem()
        {
            name = "Default";
            size = 0;
        }

        public FileItem(string _name, double _size)
        {
            name = _name;
            size = _size;
        }

        public override string ToString()
        {
            return name + " " + size + " GB\n";
        }
    }
}

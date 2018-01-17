using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FileComparator
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string root = folderDialog.SelectedPath;
                    StreamWriter sw;
                    if (ParentRBtn.Checked)
                    {
                        sw = new StreamWriter("Parent.txt");
                        //sw.WriteLine("Parent.txt");
                    }
                    else
                    {
                        sw = new StreamWriter("Child.txt");
                        //sw.WriteLine("Child.txt");
                    }

                    ProcessDirectory(root, root, 0, ref sw);
                    sw.Close();
                }
            }


        }

        public void ProcessDirectory(string origpath, string path, int index, ref StreamWriter sw)
        {

            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
            {
                //for (int i = 0; i < index; i++)
                //{
                //    sw.Write("\t");
                //}

                string test = fileName.TrimStart(origpath.ToCharArray());

                long a = new System.IO.FileInfo(fileName).Length;

                sw.WriteLine(test + " " + a.ToString());
            }

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectoryEntries)
            {
                //for (int i = 0; i <= index; i++)
                //{
                //    sw.Write("\t");
                //}
                //string test = subdirectory.TrimStart(origpath.ToCharArray());
                //sw.WriteLine(test);
                ProcessDirectory(origpath, subdirectory, index + 1, ref sw);
            }
        }

        private void ComparePCBtn_Click(object sender, EventArgs e)
        {
            List<string> parent = new List<string>();
            List<string> child = new List<string>();

            try
            {
                StreamReader a = new StreamReader("Parent.txt");

                while(!a.EndOfStream)
                {
                    parent.Add(a.ReadLine());
                }
                a.Close();

                StreamReader cb = new StreamReader("Child.txt");
                while (!cb.EndOfStream)
                {
                    child.Add(cb.ReadLine());
                }
                cb.Close();


            }
            catch (Exception except)
            {
                if (parent.Count == 0)
                    MessageBox.Show("Error with Opening up Parent Probably");
                else if (child.Count == 0)
                    MessageBox.Show("Error with Opening up Child Probably");
                else
                    MessageBox.Show("Error with something else?");
                return;
            }


            List<string> filesnotfoundinParent = new List<string>();
            List<string> filesnotfoundinChild = new List<string>();

            foreach (string line in parent)
            {
                if (!IsParentFileInChildList(line, child))
                {
                    filesnotfoundinChild.Add(line);
                }

            }

            foreach (string line in child)
            {
                if (!IsParentFileInChildList(line, parent))
                {
                    filesnotfoundinParent.Add(line);
                }
            }

            StreamWriter b = new StreamWriter("results.txt");

            b.WriteLine("Files That Parent has, but Child does not:");
            foreach (string line in filesnotfoundinChild)
            {
                b.WriteLine(line);
            }
            b.WriteLine("\nFiles That Child has, but Parent does not:");
            foreach (string line in filesnotfoundinParent)
            {
                b.WriteLine(line);
            }

            b.Close();
            MessageBox.Show("Comparator Finished! Check the results.txt");
        }

        public Boolean IsParentFileInChildList(string pFileName, List<string> child)
        {
            foreach (string line in child)
            {
                if (pFileName == line)
                    return true;
            }
            return false;
        }
    }
}

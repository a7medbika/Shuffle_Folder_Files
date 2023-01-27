using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuffle_Folder_Files
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            // Show Dialog
            FolderBrowserDialog D = new FolderBrowserDialog();
            if (D.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = D.SelectedPath;
            }
        }

        private void Btn_Shuffle_Click(object sender, EventArgs e)
        {
            // Validate of emoty txtbox
            if(String.IsNullOrWhiteSpace(txt_Path.Text))
            {
                MessageBox.Show("قم بإختيار المجلد اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Path.Focus();
                return;
            }

            // Confirmation Message
            DialogResult dr = MessageBox.Show("هل انت متأكد من انك تريد تغيير اسماء ملفات هذا المجلد؟؟", "تأكيد", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            // Get Files
            List<string> files = GetFilesShuffledList(txt_Path.Text);

            // Check Shuffled
            if (CheckShuffled(files))
                // remove shuffle
                RemoveShuffle(files);

            // Rename shuffled list
            RenameList(files);
        }

        private bool CheckShuffled(List<string> list)
        {
            foreach(string file in list)
            {
                // Get first 4 chars of th file name
                string num = file.Substring(GetIndexOfFileName(file), 4);
                try
                {
                    Convert.ToInt32(num);
                    // if done means all files shuffled
                }
                catch
                {
                    // means on of the files is not shuffled or all of them
                    return false;
                }
            }

            return true;
        }

        private void RemoveShuffle(List<string> list)
        {
            for (int i = 0, n = list.Count(); i < n; i++)
            {
                File.Move(list[i], list[i].Remove(GetIndexOfFileName(list[i]), 6));
                list[i] = list[i].Remove(GetIndexOfFileName(list[i]), 6);
            }
        }

        private List<string> GetFilesShuffledList(string dir)
        {
            // Get all files
            string[] paths = Directory.GetFiles(dir);
            // Randoming object
            Random rng = new Random();
            // return shuffled list of files
            return paths.OrderBy(a => rng.Next()).ToList();
        }

        private string GetNewName(string oldname, int num_to_add)
        {
            // change num to formated string
            string num = num_to_add.ToString();
            for(int i = 0, n = 4 - num.Count(); i < n; i++)
            {
                num = num.Insert(0, "0");
            }
            num = num + ". ";

            // Insert num before the file name in the path
            return oldname.Insert(GetIndexOfFileName(oldname), num);
        }

        private int GetIndexOfFileName(string filepath)
        {
            string[] splitedpath = filepath.Split('\\');
            return filepath.IndexOf(splitedpath.Last());
        }

        private void RenameList(List<string> list)
        {
            int i = 1;
            foreach (string file in list)
            {
                File.Move(file, GetNewName(file, i));
                i++;
            }
        }
    }
}

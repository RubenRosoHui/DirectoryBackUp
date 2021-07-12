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
using System.Diagnostics;

namespace AutoBackUp
{
    public partial class Form1 : Form
    {
        string Source,Destination;
        bool sub;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            Destination = txt_Destination.Text;
            Source = txt_Source.Text;
            if (rbtn_No.Checked == true) { sub = false; }
            else if (rbtn_Yes.Checked == true) { sub = true; }
            DirCopy(Source, Destination, sub);
        }
        private static void DirCopy(string source, string dest, bool CopySubs) 
        {
            DirectoryInfo dir = new DirectoryInfo(source);
            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!dir.Exists) 
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + source);
            }
            if (!Directory.Exists(dest)) 
            {
                Directory.CreateDirectory(dest);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files) 
            {
                string tempPath = Path.Combine(dest, file.Name);
                file.CopyTo(tempPath, false);

            }
            if (CopySubs)
            {
                foreach (DirectoryInfo subdir in dirs) 
                {
                    string tempPath = Path.Combine(dest, subdir.Name);
                    DirCopy(subdir.FullName, tempPath, CopySubs);
                }
            }
            MessageBox.Show("Thank You for using Backup Tech");
        }
    }
}

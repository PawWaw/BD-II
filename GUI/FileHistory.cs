using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;

namespace GUI
{
    public partial class FileHistory : Form
    {
        int id;

        public FileHistory(int secID)
        {
            InitializeComponent();

            id = secID;
        }

        private void FileHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = DependencyFacade.GetSectionFiles(id);
            dataGridView1.Columns.Remove("File");
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[3].Width = 260;
            dataGridView1.Columns[4].Width = 40;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string ByteToString(byte[] file, string extension)
        {
            FileStream fs;                          
            BinaryWriter bw;
            string path;

            if (extension.Equals("txt"))
            {
                fs = new FileStream("C:/Users/pawel/source/repos/BD-II/section" + id.ToString() + "txt" + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                path = "C:/Users/pawel/source/repos/BD-II/file.txt";
            }
            else if (extension.Equals("pdf"))
            {
                fs = new FileStream("C:/Users/pawel/source/repos/BD-II/section" + id.ToString() + "pdf" + ".pdf", FileMode.OpenOrCreate, FileAccess.Write);
                path = "C:/Users/pawel/source/repos/BD-II/file.pdf";
            }
            else
            {
                fs = new FileStream("C:/Users/pawel/source/repos/BD-II/section" + id.ToString() + "zip" + ".zip", FileMode.OpenOrCreate, FileAccess.Write);
                path = "C:/Users/pawel/source/repos/BD-II/file.zip";
            }

            bw = new BinaryWriter(fs);

            bw.Write(file);
            bw.Flush();

            bw.Close();
            fs.Close();
            Process process = new Process();
            if (File.Exists("C:/Users/pawel/source/repos/BD-II/section" + id.ToString() + "txt" + ".txt") && extension.Equals("txt"))
                process.StartInfo.FileName = "C:/Users/pawel/source/repos/BD-II/section" + id.ToString() + "txt" + ".txt";
            else if (File.Exists("C:/Users/pawel/source/repos/BD-II/section" + id.ToString() + "pdf" + ".pdf") && extension.Equals("pdf"))
                process.StartInfo.FileName = "C:/Users/pawel/source/repos/BD-II/section" + id.ToString() + "pdf" + ".pdf";
            else if (File.Exists("C:/Users/pawel/source/repos/BD-II/section" + id.ToString() + "zip" + ".zip") && extension.Equals("zip"))
                process.StartInfo.FileName = "C:/Users/pawel/source/repos/BD-II/section" + id.ToString() + "zip" + ".zip";
            else
                MessageBox.Show("Wrong file!");
            process.Start();
            process.WaitForExit();
            return path;
        }

        private void OpenFile(string path)
        {
            FileStream fs = File.Open(path, FileMode.Open);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Files fl = DependencyFacade.GetFile(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            string path = ByteToString(fl.File.ToArray(), fl.Ext);
            OpenFile(path);
            this.Hide();
        }
    }
}

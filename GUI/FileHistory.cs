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
                fs = new FileStream("C:/Users/pawel/source/repos/BD-II/file" + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                path = "C:/Users/pawel/source/repos/BD-II/file.txt";
            }
            else if (extension.Equals("pdf"))
            {
                fs = new FileStream("C:/Users/pawel/source/repos/BD-II/file" + ".pdf", FileMode.OpenOrCreate, FileAccess.Write);
                path = "C:/Users/pawel/source/repos/BD-II/file.pdf";
            }
            else
            {
                fs = new FileStream("C:/Users/pawel/source/repos/BD-II/file" + ".zip", FileMode.OpenOrCreate, FileAccess.Write);
                path = "C:/Users/pawel/source/repos/BD-II/file.zip";
            }

            bw = new BinaryWriter(fs);

            bw.Write(file);
            bw.Flush();

            bw.Close();
            fs.Close();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;

namespace GUI
{
    public partial class FileDetails : Form
    {
        byte[] file;
        int ID;
        string ext;

        public FileDetails(byte[] filedata, int sectionID, string extension)
        {
            InitializeComponent();

            file = filedata;
            ID = sectionID;
            ext = extension;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DependencyFacade.InsertFile(file, ID, richTextBox1.Text, ext);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

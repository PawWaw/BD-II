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

        public FileDetails(byte[] filedata, int sectionID)
        {
            InitializeComponent();

            file = filedata;
            ID = sectionID;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DependencyFacade.InsertFile(file, ID, richTextBox1.Text);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

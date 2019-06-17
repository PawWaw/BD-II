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
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            //open file 
        }
    }
}

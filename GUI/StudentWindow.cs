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

namespace GUI
{
    public partial class StudentWindow : Form
    {
        public StudentWindow()
        {
            InitializeComponent();
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {           
            openFileDialog1.ShowDialog();
            FilenameLabel.Text = openFileDialog1.FileName;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow log = new LoginWindow();
            log.Show();
        }
    }
}

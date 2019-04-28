using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FileHistory : Form
    {
        public FileHistory()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            //open file 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

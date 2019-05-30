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
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            FileHistory fsh = new FileHistory();
            fsh.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //AddMark adm = new AddMark();
            //adm.ShowDialog();
        }
    }
}

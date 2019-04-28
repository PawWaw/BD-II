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
    public partial class Topics : Form
    {
        public Topics()
        {
            InitializeComponent();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            TopicDetails tpd = new TopicDetails(0);
            tpd.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TopicDetails tpd = new TopicDetails(1);
            tpd.ShowDialog();
        }
    }
}

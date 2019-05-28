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
    public partial class TopicSet : Form
    {
        public TopicSet(int id)
        {
            InitializeComponent();
            SectionTexbox.Text = id.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DependencyFacade.SetTopic(Convert.ToInt32(TopicTextbox.Text), Convert.ToInt32(SectionTexbox.Text)) == 0)
                MessageBox.Show("Can't set section to topic!", "Error");
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

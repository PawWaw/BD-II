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
    public partial class TeacherPanel : Form
    {
        public TeacherPanel()
        {
            InitializeComponent();
        }

        private void NewSectionButton_Click(object sender, EventArgs e)
        {
            SectionPanel sec = new SectionPanel();
            sec.ShowDialog();
        }

        private void TopicButton_Click(object sender, EventArgs e)
        {
            Topic top = new Topic();
            top.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginPanel lgp = new LoginPanel();
            this.Hide();
            lgp.ShowDialog();
        }
    }
}

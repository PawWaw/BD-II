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
            Sections sec = new Sections();
            sec.ShowDialog();
        }

        private void AddMarkButton_Click(object sender, EventArgs e)
        {
            Marks mrk = new Marks();
            mrk.ShowDialog();
        }

        private void TopicButton_Click(object sender, EventArgs e)
        {
            Topics top = new Topics();
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

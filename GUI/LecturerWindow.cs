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
    public partial class LecturerWindow : Form
    {
        public LecturerWindow()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow log = new LoginWindow();
            log.Show();
        }

        private void NewSectionButton_Click(object sender, EventArgs e)
        {
            AddSectionWindow ads = new AddSectionWindow();
            ads.ShowDialog();
        }

        private void AddMarkButton_Click(object sender, EventArgs e)
        {
            AddMarkWindow adm = new AddMarkWindow();
            adm.ShowDialog();
        }

        private void TopicButton_Click(object sender, EventArgs e)
        {
            AddTopicWindow adt = new AddTopicWindow();
            adt.ShowDialog();
        }
    }
}

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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            PersonalDataWindow pers = new PersonalDataWindow();
            pers.ShowDialog();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUserWindow adu = new AddUserWindow();
            adu.ShowDialog();        
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow log = new LoginWindow();
            log.Show();
        }
    }
}

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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        string accountType = "lecturer";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (true)   //sprawdzanie, czy istnieje konto o podanym loginie i haśle
            {
                if(accountType == "admin")
                {
                    this.Hide();
                    AdminWindow fm = new AdminWindow();
                    fm.Show();
                }
                else if (accountType == "lecturer")
                {
                    this.Hide();
                    LecturerWindow lct = new LecturerWindow();
                    lct.Show();
                }
                else if (accountType == "student")
                {
                    this.Hide();
                    StudentWindow std = new StudentWindow();
                    std.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong login or password!", "Error");
            }
        }
    }
}

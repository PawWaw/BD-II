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
    public partial class LoginPanel : Form
    {
        public static int albumNumber = 0;

        public LoginPanel()
        {
            InitializeComponent();
        }

        Users userSearchCriteria, log;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            userSearchCriteria = new Users
            {
                Password = PswdTextBox.Text,
                Login = LoginTextBox.Text  
            };

            log = UserFacade.LogIn(userSearchCriteria);

            if (log != null)   //sprawdzanie, czy istnieje konto o podanym loginie i haśle
            {
                if(log.TypeOfUser == "adm")
                {
                    this.Hide();
                    AdminPanel fm = new AdminPanel();
                    fm.Show();
                }
                else if (log.TypeOfUser == "tch")
                {
                    this.Hide();
                    TeacherPanel lct = new TeacherPanel();
                    lct.Show();
                }
                else if (log.TypeOfUser == "std")
                {
                    albumNumber = UserFacade.GetAlbumNumber(log.ID);
                    this.Hide();
                    StudentWindow std = new StudentWindow();
                    std.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong login or password!", "Error");
                LoginTextBox.Text = "";
                PswdTextBox.Text = "";
            }
        }
    }
}

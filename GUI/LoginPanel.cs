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
        public static int TeacherID = 0;
        public static int semID;
        Sems[] sems;

        public LoginPanel()
        {
            InitializeComponent();
            sems = DependencyFacade.GetSems();
            for (int i = 0; i < sems.Length; i++)
                SemCombobox.Items.Add(sems[i].StudyField + ", " + sems[i].Year + ", semestr " + sems[i].Sem);
            SemCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SemCombobox.SelectedIndex = 0;
        }

        Users userSearchCriteria, log;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            userSearchCriteria = new Users
            {
                Password = PswdTextBox.Text,
                Login = LoginTextBox.Text  
            };

            semID = sems[SemCombobox.SelectedIndex].ID; 
            log = UserFacade.LogIn(userSearchCriteria);
            if (log != null)
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
                    TeacherID = UserFacade.GetTeacherFromUser(log).ID;
                    TeacherPanel lct = new TeacherPanel();
                    lct.Show();
                }
                else if (log.TypeOfUser == "std")
                {
                    if(UserFacade.GetStudentSem(log, semID))
                    {
                        albumNumber = UserFacade.GetAlbumNumber(log.ID);
                        this.Hide();
                        StudentWindow std = new StudentWindow();
                        std.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Error");
                        LoginTextBox.Text = "";
                        PswdTextBox.Text = "";
                    }
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

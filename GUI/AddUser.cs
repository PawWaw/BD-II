using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer;

namespace GUI
{
    public partial class AddUser : Form
    {
        byte openType = 0;

        public AddUser()                              
        {
            InitializeComponent();
            DegreeTextbox.Enabled = false;
            AlbumTextbox.Enabled = false;
        }

        public AddUser(int windowType, Users user)
        {
            if(windowType == 0)
            {
                openType = 0;
                InitializeComponent();
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
                IDTextbox.Enabled = false;
            }
            else if(windowType == 1)
            {
                openType = 1;
                InitializeComponent();
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
                PswdLabel.Visible = false;
                PswdTextbox.Visible = false;
                PswdButton.Visible = true;
                IDTextbox.Enabled = false;
                this.Text = "Change Data";
                IDTextbox.Text = user.ID.ToString();
                NameTextBox.Text = user.Name;
                SurnameTextbox.Text = user.Surname;
                LoginTextbox.Text = user.Login;
                FunctionCombobox.SelectedIndex = Convert.ToInt32(user.TypeOfUser);
                if (FunctionCombobox.SelectedIndex == 2)
                    AlbumTextbox.Text = UserFacade.GetAlbumNumber(Convert.ToInt32(user.ID)).ToString();

                FunctionCombobox.Enabled = false;

            }
        }

        private void CloseButton_Click(object sender, EventArgs e) => this.Hide();

        private void FunctionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FunctionCombobox.SelectedIndex == 1)
            {
                DegreeTextbox.Enabled = true;
                AlbumTextbox.Enabled = false;
            }
            else if (FunctionCombobox.SelectedIndex == 2)
            {
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
            }
            else
            {
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
            }
        }

        private void PswdButton_Click(object sender, EventArgs e)
        {
            PswdChange pswd = new PswdChange();
            pswd.ShowDialog();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            if (IDTextbox.Text != "")
                user.ID = Convert.ToInt32(IDTextbox.Text);
            user.Login = LoginTextbox.Text;
            user.Name = NameTextBox.Text;
            user.Surname = SurnameTextbox.Text;
            if (Equals(FunctionCombobox.SelectedItem.ToString(), "Student"))
                user.TypeOfUser = "std";
            else if (Equals(FunctionCombobox.SelectedItem.ToString(), "Lecturer"))
                user.TypeOfUser = "tch";
            else if (Equals(FunctionCombobox.SelectedItem.ToString(), "Admin"))
                user.TypeOfUser = "adm";
            if (openType == 1)
            {      
                UserFacade.UpdateUsers(user);
                this.Hide();
            }
            else if (openType == 0)
            {
                int max = UserFacade.GetMaxIndex();
                user.Password = PswdTextbox.Text;
                if (Equals(FunctionCombobox.SelectedItem.ToString(), "Student"))
                    UserFacade.InsertStudent(user, max);
                else if (Equals(FunctionCombobox.SelectedItem.ToString(), "Lecturer"))
                    UserFacade.InsertTeacher(user, DegreeTextbox.Text);
                else
                    UserFacade.InsertUser(user);
                this.Hide();
            }
        }
    }
}

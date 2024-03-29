﻿using System;
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
        Sems[] sems;
        Hashing hash = new Hashing();
        Users usr;

        public AddUser()                              
        {
            InitializeComponent();
            DegreeTextbox.Enabled = false;
            AlbumTextbox.Enabled = false;
        }

        public AddUser(int windowType, Users user)
        {
            usr = user;
            if(windowType == 0)
            {
                openType = 0;
                InitializeComponent();
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
                SemCombobox.Enabled = false;
                IDTextbox.Enabled = false;
                IDTextbox.Visible = false;
                IDLabel.Visible = false;
                sems = DependencyFacade.GetSems();
                for (int i = 0; i < sems.Length; i++)
                    SemCombobox.Items.Add(sems[i].StudyField + ", " + sems[i].Year + ", semestr " + sems[i].Sem);
                SemCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                SemCombobox.SelectedIndex = 0;
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
                sems = DependencyFacade.GetSems();
                for (int i = 0; i < sems.Length; i++)
                    SemCombobox.Items.Add(sems[i].StudyField + ", " + sems[i].Year + ", semestr " + sems[i].Sem);
                SemCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                SemCombobox.SelectedIndex = 0;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e) => this.Hide();

        private void FunctionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FunctionCombobox.SelectedIndex == 1)
            {
                DegreeTextbox.Enabled = true;
                AlbumTextbox.Enabled = false;
                SemCombobox.Enabled = false;
            }
            else if (FunctionCombobox.SelectedIndex == 2)
            {
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
                SemCombobox.Enabled = true;
            }
            else
            {
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
                SemCombobox.Enabled = false;
            }
        }

        private void PswdButton_Click(object sender, EventArgs e)
        {
            PswdChange pswd = new PswdChange(usr);
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
            if ((user.Login != "") && (user.Name != "") && (user.Surname != "") && (FunctionCombobox.SelectedItem != null))
            {
                if (Equals(FunctionCombobox.SelectedItem.ToString(), "Student"))
                    user.TypeOfUser = "std";
                else if (Equals(FunctionCombobox.SelectedItem.ToString(), "Teacher"))
                    user.TypeOfUser = "tch";
                else if (Equals(FunctionCombobox.SelectedItem.ToString(), "Admin"))
                    user.TypeOfUser = "adm";
            }
            if (openType == 1)
            {
                if (user.Login != "" && user.Name != "" && user.Surname != "" && user.Hash != "" && user.TypeOfUser != null)
                {
                    UserFacade.UpdateUsers(user);
                    this.Hide();
                }
            }
            else if (openType == 0)
            {
                int max = UserFacade.GetMaxIndex();
                user.Salt = hash.CreateSalt(10);
                user.Hash = hash.GenSalt(PswdTextbox.Text, user.Salt);
                if (user.Login != "" && user.Name != "" && user.Surname != "" && user.Hash != "" && user.TypeOfUser != null)
                {
                    if (Equals(FunctionCombobox.SelectedItem.ToString(), "Student"))
                    {
                        UserFacade.InsertStudent(user, max, DependencyFacade.GetSems()[SemCombobox.SelectedIndex].ID);
                    }
                    else if (Equals(FunctionCombobox.SelectedItem.ToString(), "Teacher"))
                        UserFacade.InsertTeacher(user, DegreeTextbox.Text);
                    else
                        UserFacade.InsertUser(user);
                    this.Hide();
                }
                else
                    MessageBox.Show("Incorrect data!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}

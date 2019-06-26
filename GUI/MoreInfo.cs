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
    public partial class MoreInfo : Form
    {
        public MoreInfo()
        {
            InitializeComponent();
        }

        int id;
        Students_Groups[] stdgrp;
        int secID;
        int topID = 0; 

        public MoreInfo(int mode, Sections sec, Topics top)
        {
            if(top != null)
                topID = top.ID;
            if(mode == 0)
            {
                InitializeComponent();
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                if(sec != null)
                {
                    PlacesTexbox.Text = (sec.GroupSize - DependencyFacade.GetStudentNumber(sec.ID)).ToString();
                    Users[] usrs = UserFacade.GetSectionSquad(sec.ID);
                    if (sec.Status == "opn")
                        StatusTextbox.Text = "Open";
                    else if (sec.Status == "cls")
                        StatusTextbox.Text = "Close";
                    else
                        StatusTextbox.Text = "Final";
                    foreach (Users v in usrs)
                        MembersTextbox.AppendText(v.Name + "  " + v.Surname + "\n");
                        
                    secID = sec.ID;
                }
                if (top != null)
                {
                    TopicTextbox.Text = top.Title;
                    DetailsTextbox.Text = top.Description;
                    TeacherTextbox.Text = UserFacade.GetTeacher(top.TeacherID).Name + " " + UserFacade.GetTeacher(top.TeacherID).Surname;
                    id = top.ID;
                }
            }
            else if (mode == 1)
            {
                InitializeComponent();
                SaveButton.Text = "Leave";
                MarkLabel.Visible = true;
                MarkTextbox.Visible = true;
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                if(sec !=null)
                {
                    Users[] usrs = UserFacade.GetSectionSquad(sec.ID);
                    Users usr = new Users();
                    Users user = UserFacade.GetSingleStudent(LoginPanel.albumNumber);
                    for (int i = 0; i < usrs.Count(); i++)
                    {
                        if (usrs[i].ID == user.ID)
                        {
                            if (sec.Status == "opn")
                                StatusTextbox.Text = "Open";
                            else if (sec.Status == "cls")
                                StatusTextbox.Text = "Close";
                            else
                                StatusTextbox.Text = "Final";

                            PlacesTexbox.Text = (sec.GroupSize - DependencyFacade.GetStudentNumber(sec.ID)).ToString();
                            foreach (Users v in usrs)
                                MembersTextbox.Text += v.Name + "  " + v.Surname + "\n";

                            if (top != null && top.Title != null)
                            {
                                TopicTextbox.Text = top.Title;
                                DetailsTextbox.Text = top.Description;
                                TeacherTextbox.Text = UserFacade.GetTeacher(top.TeacherID).Name + " " + UserFacade.GetTeacher(top.TeacherID).Surname;
                                id = top.ID;
                            }
                            secID = sec.ID;
                        }
                    }
                }
            }
            else if (mode == 2)
            {
                InitializeComponent();
                StatusTextbox.Visible = false;
                StatusCombobox.Visible = true;
                MarkLabel.Visible = false;
                MarkTextbox.Visible = false;
                MarkTextbox.Enabled = true;
                SaveButton.Text = "Save";
                SizeLabel.Text = "Section size:";
                TopicTextbox.Enabled = false;
                DetailsTextbox.Enabled = false;
                TeacherTextbox.Enabled = false;
                PlacesTexbox.Enabled = true;
                MembersTextbox.Enabled = false;
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                id = sec.ID;

                if (sec.Status == "opn")
                    StatusCombobox.SelectedIndex = 0;
                else if (sec.Status == "cls")
                    StatusCombobox.SelectedIndex = 1;
                else
                    StatusCombobox.SelectedIndex = 2;

                if (top != null)
                {
                    TopicTextbox.Text = top.Title;
                    DetailsTextbox.Text = top.Description;
                    TeacherTextbox.Text = UserFacade.GetTeacher(top.TeacherID).Name + " " + UserFacade.GetTeacher(top.TeacherID).Surname;
                }

                PlacesTexbox.Text = sec.GroupSize.ToString();
                secID = sec.ID;

                Users[] usrs = UserFacade.GetSectionSquad(sec.ID);
                PlacesTexbox.Text = sec.GroupSize.ToString();
                foreach (Users v in usrs)
                    MembersTextbox.Text += v.Name + "  " + v.Surname + "\n";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (SaveButton.Text.Equals("Leave"))
            {
                UserFacade.UpdateGroupStudent(LoginPanel.albumNumber, secID, false);
                this.Hide();
            }
            else
            {
                Sections sec = new Sections();
                sec.ID = secID;
                if (SaveButton.Text != "Save")
                {
                    if (StatusTextbox.Text == "Open")
                    {
                        MessageBox.Show("Joining this section will cause leaving current section!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        stdgrp = UserFacade.GetGroupStudentID(UserFacade.GetSingleStudent(LoginPanel.albumNumber).ID);
                        if(stdgrp != null)
                        {
                            //for(int i = 0; i < stdgrp.Length; i++)
                            //{
                            //    if (stdgrp[i].Active == true)
                            //    {
                            //        UserFacade.UpdateGroupStudent(LoginPanel.albumNumber, 0, false);
                            //        flag = 1;
                            //    }
                            //    if (stdgrp[i].GroupID == secID)
                            //    {
                            //        UserFacade.UpdateGroupStudent(LoginPanel.albumNumber, secID, true);
                            //        flag = 0;
                            //    }
                            //}
                            //if(flag == 1)
                            //{
                                DependencyFacade.SetStudentSection(LoginPanel.albumNumber, sec);
                                //flag = 0;
                            //}
                        }
                        else
                        {
                            DependencyFacade.SetStudentSection(LoginPanel.albumNumber, sec);
                        }

                    }
                    else
                    {
                        MessageBox.Show("You can't join to closed section!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    this.Hide();
                }
                else
                {
                    sec.ID = id;
                    sec.GroupSize = Convert.ToByte(PlacesTexbox.Text);

                    if (StatusCombobox.Text == "Open")
                        sec.Status = "opn";
                    else if (StatusCombobox.Text == "Closed")
                        sec.Status = "cls";
                    else
                        sec.Status = "fin";

                    if(topID != 0)
                        sec.TopicID = topID;
                    DependencyFacade.UpdateSection(sec);
                }
                this.Hide();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

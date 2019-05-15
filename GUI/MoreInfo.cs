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

        public MoreInfo(int mode, Groups grp, Topics top)
        {
            if(mode == 0)
            {
                InitializeComponent();
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                if (top != null)
                {
                    TopicTextbox.Text = top.Title;
                    DetailsTextbox.Text = top.Description;
                    TeacherTextbox.Text = UserFacade.GetTeacher(top.TeacherID).Name + " " + UserFacade.GetTeacher(top.TeacherID).Surname;
                    id = top.ID;
                    PlacesTexbox.Text = (grp.GroupSize - DependencyFacade.GetStudentNumber(grp.ID)).ToString();
                    Users[] usrs = UserFacade.GetSectionSquad(grp.ID);
                    for(int i = 0; i < usrs.Length; i++)
                    {
                        MembersTextbox.AppendText(usrs[i].Name + "  " + usrs[i].Surname + "\n");
                    }
                    if (top.Active == "opn")
                        StatusTextbox.Text = "Open";
                    else if (top.Active == "cls")
                        StatusTextbox.Text = "Closed";
                    else
                        StatusTextbox.Text = "Final";
                }
            }
            else if (mode == 1)
            {
                InitializeComponent();
                SaveButton.Visible = false;
                MarkLabel.Visible = true;
                MarkTextbox.Visible = true;
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                if (top != null && top.Title != null)
                {
                    TopicTextbox.Text = top.Title;
                    DetailsTextbox.Text = top.Description;
                    TeacherTextbox.Text = UserFacade.GetTeacher(top.TeacherID).Name + " " + UserFacade.GetTeacher(top.TeacherID).Surname;
                    id = top.ID;
                    PlacesTexbox.Text = (grp.GroupSize - DependencyFacade.GetStudentNumber(grp.ID)).ToString();
                    Users[] usrs = UserFacade.GetSectionSquad(grp.ID);
                    for (int i = 0; i < usrs.Length; i++)
                    {
                        MembersTextbox.Text += usrs[i].Name + "  " + usrs[i].Surname + "\n";
                    }
                    if (top.Active == "opn")
                        StatusTextbox.Text = "Open";
                    else if (top.Active == "cls")
                        StatusTextbox.Text = "Closed";
                    else
                        StatusTextbox.Text = "Final";
                }
                SaveButton.Visible = false;
            }
            else if (mode == 2)
            {
                InitializeComponent();
                StatusTextbox.Visible = false;
                StatusCombobox.Visible = true;
                MarkLabel.Visible = true;
                MarkTextbox.Visible = true;
                MarkTextbox.Enabled = true;
                SaveButton.Text = "Save";
                SizeLabel.Text = "Group size:";
                TopicTextbox.Enabled = true;
                DetailsTextbox.Enabled = true;
                TeacherTextbox.Enabled = true;
                PlacesTexbox.Enabled = true;
                MembersTextbox.Enabled = true;
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                id = grp.ID;
                if (top != null)
                {
                    TopicTextbox.Text = top.Title;
                    DetailsTextbox.Text = top.Description;
                    TeacherTextbox.Text = UserFacade.GetTeacher(top.TeacherID).Name + " " + UserFacade.GetTeacher(top.TeacherID).Surname;
                    if (top.Active == "opn")
                        StatusCombobox.SelectedIndex = 0;
                    else if (top.Active == "cls")
                        StatusCombobox.SelectedIndex = 1;
                    else
                        StatusCombobox.SelectedIndex = 2;
                }
                PlacesTexbox.Text = grp.GroupSize.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Groups grp = new Groups();

            if(SaveButton.Text != "Save")
            {
                if (StatusTextbox.Text == "Open")
                {
                    MessageBox.Show("Joining this section will cause leaving current section!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    int albumNr = LoginPanel.albumNumber;
                    DependencyFacade.SetStudentSection(albumNr, id);
                }
                else
                {
                    MessageBox.Show("You can't join to closed section!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Hide();
            }
            else
            {
                grp.ID = id;
                grp.GroupSize = Convert.ToByte(PlacesTexbox.Text);
                DependencyFacade.UpdateSection(grp);
            }    
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

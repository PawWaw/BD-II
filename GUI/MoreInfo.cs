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

        public MoreInfo(int mode, Sections sec, Topics top)
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
                    PlacesTexbox.Text = (sec.GroupSize - DependencyFacade.GetStudentNumber(sec.ID)).ToString();
                    Users[] usrs = UserFacade.GetSectionSquad(sec.ID);
                    for(int i = 0; i < usrs.Length; i++)
                    {
                        MembersTextbox.AppendText(usrs[i].Name + "  " + usrs[i].Surname + "\n");
                    }
                    if (top.Status == "Open")
                        StatusTextbox.Text = "Open";
                    else if (top.Status == "Close")
                        StatusTextbox.Text = "Close";
                    else
                        StatusTextbox.Text = "Final";
                }
            }
            else if (mode == 1)
            {
                InitializeComponent();
                SaveButton.Text = "File history";
                MarkLabel.Visible = true;
                MarkTextbox.Visible = true;
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                if (top != null && top.Title != null)
                {
                    TopicTextbox.Text = top.Title;
                    DetailsTextbox.Text = top.Description;
                    TeacherTextbox.Text = UserFacade.GetTeacher(top.TeacherID).Name + " " + UserFacade.GetTeacher(top.TeacherID).Surname;
                    id = top.ID;
                    PlacesTexbox.Text = (sec.GroupSize - DependencyFacade.GetStudentNumber(sec.ID)).ToString();
                    Users[] usrs = UserFacade.GetSectionSquad(sec.ID);
                    for (int i = 0; i < usrs.Length; i++)
                    {
                        MembersTextbox.Text += usrs[i].Name + "  " + usrs[i].Surname + "\n";
                    }
                    if (top.Status == "Open")
                        StatusTextbox.Text = "Open";
                    else if (top.Status == "Close")
                        StatusTextbox.Text = "Close";
                    else
                        StatusTextbox.Text = "Final";
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
                if (top != null)
                {
                    TopicTextbox.Text = top.Title;
                    DetailsTextbox.Text = top.Description;
                    TeacherTextbox.Text = UserFacade.GetTeacher(top.TeacherID).Name + " " + UserFacade.GetTeacher(top.TeacherID).Surname;
                    if (top.Status == "Open")
                        StatusCombobox.SelectedIndex = 0;
                    else if (top.Status == "Close")
                        StatusCombobox.SelectedIndex = 1;
                    else
                        StatusCombobox.SelectedIndex = 2;
                }
                PlacesTexbox.Text = sec.GroupSize.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveButton.Text.Equals("File history"))
            {
                FileHistory fhs = new FileHistory();
                fhs.ShowDialog();
            }
            else
            {
                Sections grp = new Sections();

                if (SaveButton.Text != "Save")
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
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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

        public MoreInfo(int mode, Groups grp, Topics top)
        {
            if(mode == 0)
            {
                InitializeComponent();
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else if (mode == 1)
            {
                InitializeComponent();
                SaveButton.Visible = false;
                MarkLabel.Visible = true;
                MarkTextbox.Visible = true;
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
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
                TopicTextbox.Enabled = true;
                DetailsTextbox.Enabled = true;
                TeacherTextbox.Enabled = true;
                PlacesTexbox.Enabled = true;
                MembersTextbox.Enabled = true;
                StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
                if(top != null)
                {
                    TopicTextbox.Text = top.Title;
                    DetailsTextbox.Text = top.Description;
                    TeacherTextbox.Text = top.TeacherID.ToString();
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
            if(SaveButton.Text != "Save")
                MessageBox.Show("Joining this section will cause leaving current section!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            // add student to section
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class TopicDetails : Form
    {
        Topics searchCrit;
        byte opentype = 0;

        public TopicDetails()
        {
            InitializeComponent();
        }

        public TopicDetails(int mode, Topics topic)
        {
            if(mode == 0)
            {
                opentype = 0;
                InitializeComponent();
                StatusCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                Topics top = DependencyFacade.GetTopicData(topic);
                if (top != null)
                {
                    TopicTextbox.Text = top.Title;
                    InfoRichTextbox.Text = top.Description;
                    if (top.Status == "Open")
                        StatusCombobox.SelectedIndex = 0;
                    else if (top.Status == "Close")
                        StatusCombobox.SelectedIndex = 1;
                    else
                        StatusCombobox.SelectedIndex = 2;
                    TeacherTextbox.Text = UserFacade.GetName(top.TeacherID);
                    IDTextbox.Text = top.ID.ToString();
                }
                IDTextbox.Enabled = false;
                TeacherTextbox.Enabled = false;
            }
            else if(mode == 1)
            {
                opentype = 1;
                InitializeComponent();
                StatusCombobox.Enabled = false;
                StatusCombobox.SelectedIndex = 0;
                IDTextbox.Enabled = false;
                TeacherTextbox.Text = UserFacade.GetName(LoginPanel.TeacherID);
                TeacherTextbox.Enabled = false;
            }
            else if (mode == 2)
            {
                opentype = 0;
                InitializeComponent();
                StatusCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                Topics top = DependencyFacade.GetTopicData(topic);
                if (top != null)
                {
                    TopicTextbox.Text = top.Title;
                    InfoRichTextbox.Text = top.Description;
                    if (top.Status == "Open")
                        StatusCombobox.SelectedIndex = 0;
                    else if (top.Status == "Close")
                        StatusCombobox.SelectedIndex = 1;
                    else
                        StatusCombobox.SelectedIndex = 2;
                    TeacherTextbox.Text = UserFacade.GetName(top.TeacherID);
                    IDTextbox.Text = top.ID.ToString();
                }
                TopicTextbox.Enabled = false;
                InfoRichTextbox.Enabled = false;
                TeacherTextbox.Enabled = false;
                IDTextbox.Enabled = false;
                StatusCombobox.Enabled = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            searchCrit = new Topics();
            if (TopicTextbox.Text != "" && InfoRichTextbox.Text != "" && TeacherTextbox.Text != "")
            {
                searchCrit.Title = TopicTextbox.Text;
                searchCrit.Description = InfoRichTextbox.Text;
                searchCrit.TeacherID = LoginPanel.TeacherID;

                if (IDTextbox.Text != "")
                    searchCrit.ID = Convert.ToInt32(IDTextbox.Text);

                if (StatusCombobox.SelectedItem.ToString() == "Open")
                    searchCrit.Status = "Open";
                else if (StatusCombobox.SelectedItem.ToString() == "Closed")
                    searchCrit.Status = "Close";
                else
                    searchCrit.Status = "Final";

                if (opentype == 1)
                    DependencyFacade.InsertTopic(searchCrit);
                else
                    DependencyFacade.UpdateTopics(searchCrit);
                this.Hide();
            }
            else
                MessageBox.Show("Wrong parameters of topic.", "Warning", MessageBoxButtons.OK);
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

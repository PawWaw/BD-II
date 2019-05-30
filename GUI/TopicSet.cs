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
    public partial class TopicSet : Form
    {
        Topics[] topics;
        public TopicSet(int id)
        {
            InitializeComponent();
            SectionTexbox.Text = id.ToString();
            SectionTexbox.Enabled = false;
            Topics top = new Topics
            {
                ID = 0
            };
            topics = DependencyFacade.GetArrayTopics(LoginPanel.TeacherID);
            for (int i = 0; i < topics.Length; i++)
                TopicCombobox.Items.Add(topics[i].Title);
            TopicCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            TopicCombobox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DependencyFacade.SetTopic(topics[TopicCombobox.SelectedIndex].ID, Convert.ToInt32(SectionTexbox.Text));
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

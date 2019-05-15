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
    public partial class Topic : Form
    {
        Topics searchCrit;
        byte flag = 0;

        public Topic()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            Topics top = new Topics();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                top.ID = (int)row.Cells[0].Value;
            }
            TopicDetails tpd = new TopicDetails(0, top);
            tpd.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e) => this.Hide();

        private void AddButton_Click(object sender, EventArgs e)
        {
            TopicDetails tpd = new TopicDetails(1, searchCrit);
            tpd.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (IDTextbox.Text != "")
            {
                searchCrit = new Topics
                {
                    Title = TopicTextbox.Text,
                    ID = Convert.ToInt32(IDTextbox.Text)
                };
            }
            else
            {
                searchCrit = new Topics
                {
                    Title = TopicTextbox.Text
                };
            }
            dataGridView1.DataSource = DependencyFacade.GetTopics(searchCrit);
            dataGridView1.Columns[3].HeaderText = "Teacher name";
            dataGridView1.Columns[4].HeaderText = "Teacher surname";
            for(int i = 0; i < 5; i++)
            {
                DataGridViewColumn col = dataGridView1.Columns[i];
                col.Width = i == 1 ? 250 : 70;
            }

        }

        private void Topic_Activated(object sender, EventArgs e)
        {
            if (flag == 1)
                SearchButton_Click(sender, e);
        }

        private void Topic_Deactivate(object sender, EventArgs e) => flag = 1;
    }
}

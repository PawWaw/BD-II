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
    public partial class Sections : Form
    {
        byte flag = 0;

        Groups searchCrit;
        public Sections()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            Groups grp = new Groups();
            Topics top = new Topics();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                grp.ID = (int)row.Cells[0].Value;
                grp.GroupSize = (byte)row.Cells[1].Value;
                if (row.Cells[2].Value != null)
                {
                    grp.TopicID = (int)row.Cells[2].Value;
                    top.ID = (int)row.Cells[2].Value;
                }
                else
                {
                    top.ID = 0;
                    grp.TopicID = 0;
                }

                grp.SemID = (int)row.Cells[3].Value;
            }
            top = DependencyFacade.GetTopicData(top);
            MoreInfo mri = new MoreInfo(2, grp, top);
            mri.ShowDialog();
        }

        private void TopicButton_Click(object sender, EventArgs e)
        {
            TopicSet tps = new TopicSet();
            tps.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSection ads = new AddSection();
            ads.ShowDialog();
        }

        private void PresenceButton_Click(object sender, EventArgs e)
        {
            Presences prs = new Presences();
            prs.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SectionTextbox.Text != "")
            {
                searchCrit = new Groups
                {
                    ID = Convert.ToInt32(SectionTextbox.Text)
                };
            }
            else
            {
                searchCrit = new Groups
                {
                    ID = 0
                };
            }
            dataGridView1.DataSource = DependencyFacade.GetSections(searchCrit);
            for (int i = 0; i < 4; i++)
            {
                DataGridViewColumn col = dataGridView1.Columns[i];
                col.Width = 130;
            }
        }

        private void Sections_Activated(object sender, EventArgs e)
        {
            if (flag == 1)
                SearchButton_Click(sender, e);
        }

        private void Sections_Deactivate(object sender, EventArgs e) => flag = 1;
    }
}

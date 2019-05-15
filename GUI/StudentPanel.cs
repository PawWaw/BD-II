using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;
using DataLayer;

namespace GUI
{
    public partial class StudentWindow : Form
    {
        public StudentWindow()
        {
            InitializeComponent();
        }

        private void StudentWindow_Load(object sender, EventArgs e)
        {
            Topics top = new Topics();
            dataGridView1.DataSource = DependencyFacade.GetAvailableTopics(top);
            dataGridView1.Columns[0].Width = 50;
            //dataGridView1.Columns[]
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            System.Boolean noErrors = false;
            while(!noErrors)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    switch(Path.GetExtension(openFileDialog1.FileName).ToLower())
                    {
                        case ".pdf":
                        case ".zip":
                        case ".7z"://Add case here if you add some filter
                            FilenameLabel.Text = openFileDialog1.SafeFileName;
                            noErrors = true;
                            break;
                        default:
                            MessageBox.Show("Please choose file with pdf extension or archive file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
                else { noErrors = true; }
            }
            FileDetails fld = new FileDetails();
            fld.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPanel log = new LoginPanel();
            log.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Groups grp = new Groups();
            Topics top = new Topics();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                top.ID = (int)row.Cells[0].Value;
                top.Title = row.Cells[1].Value.ToString();
                top.Active = row.Cells[2].Value.ToString();
            }
            grp = DependencyFacade.GetSectionData(top.ID);
            top = DependencyFacade.GetTopicData(top);
            MoreInfo mri = new MoreInfo(0, grp, top);
            mri.ShowDialog();
        }

        private void MySecButton_Click(object sender, EventArgs e)
        {
            Groups grp = new Groups();
            Topics top = new Topics();
            grp = DependencyFacade.GetMySection(LoginPanel.albumNumber);
            if (grp != null)
            {
                top.ID = (int)grp.TopicID;
                top = DependencyFacade.GetTopicData(top);
            }
            MoreInfo mri = new MoreInfo(1, grp, top);
            mri.ShowDialog();
        }
    }
}

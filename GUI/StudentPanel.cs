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

        byte[] pdfBytes;
        int secID;

        public StudentWindow()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void StudentWindow_Load(object sender, EventArgs e)
        {
            Sections sec = new Sections();
            dataGridView1.DataSource = DependencyFacade.GetSections(sec, null);
            for (int i = 2; i < 5; i++)
            {
                DataGridViewColumn col = dataGridView1.Columns[i];
                col.Width = 60;
            }
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[5].Width = 250;
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
                        case ".7z": //Add case here if you add some filter
                            FilenameLabel.Text = openFileDialog1.SafeFileName;
                            noErrors = true;
                            break;
                        default:
                            MessageBox.Show("Please choose file with pdf extension or archive file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
                else { noErrors = true; }
                //string path = Path.GetFullPath(openFileDialog1.FileName);
                //pdfBytes = File.ReadAllBytes(path);
                //string pdf = Convert.ToString(pdfBytes);
            }
            Sections sec = new Sections();
            sec = DependencyFacade.GetMySection(LoginPanel.albumNumber);
            if(sec != null)
            {
                FileDetails fld = new FileDetails(pdfBytes, sec.ID);
                fld.ShowDialog();
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPanel log = new LoginPanel();
            log.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Sections sec = new Sections();
            Topics top = new Topics();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[4].Value != null)
                {
                    top.ID = (int)row.Cells[4].Value;
                    top.Title = row.Cells[5].Value.ToString();
                }
                sec.ID = (int)row.Cells[0].Value;
            }
            sec = DependencyFacade.GetSection(sec);
            top = DependencyFacade.GetTopicData(top);
            MoreInfo mri = new MoreInfo(0, sec, top);
            mri.ShowDialog();
        }

        private void MySecButton_Click(object sender, EventArgs e)
        {
            Sections grp = new Sections();
            Topics top = new Topics();
            grp = DependencyFacade.GetMySection(LoginPanel.albumNumber);
            if (grp != null && grp.TopicID != null)
            {
                top.ID = (int)grp.TopicID;
                top = DependencyFacade.GetTopicData(top);
            }
            MoreInfo mri = new MoreInfo(1, grp, top);
            mri.ShowDialog();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    secID = (int)row.Cells[0].Value;
                }
            }

            FileHistory flh = new FileHistory(secID);
            flh.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Sections sec = new Sections();
            dataGridView1.DataSource = DependencyFacade.GetSections(sec, SearchTextbox.Text);
        }
    }
}

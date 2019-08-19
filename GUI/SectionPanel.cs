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

using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout;

namespace GUI
{
    public partial class SectionPanel : Form
    {
        byte flag = 0;

        Sections searchCrit;

        public SectionPanel()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SectionPanel_Load(object sender, EventArgs e)
        {
            SearchButton_Click(sender, e);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            Sections grp = new Sections();
            Topics top = new Topics();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                grp.ID = (int)row.Cells[0].Value;
                grp.GroupSize = (byte)row.Cells[1].Value;
                grp.Status = row.Cells[2].Value.ToString();
                if (row.Cells[4].Value != null)
                {
                    grp.TopicID = (int)row.Cells[4].Value;
                    top.ID = (int)row.Cells[4].Value;
                    top.Title = row.Cells[5].Value.ToString();
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
            if(dataGridView1.SelectedCells.Count != 0)
            {
                TopicSet tps = new TopicSet(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
                tps.ShowDialog();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSection ads = new AddSection();
            ads.ShowDialog();
        }

        private void PresenceButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count != 0)
            {
                Presences prs = new Presences(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
                prs.ShowDialog();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SectionTextbox.Text != "")
            {
                searchCrit = new Sections
                {
                    ID = Convert.ToInt32(SectionTextbox.Text)
                };
            }
            else
            {
                searchCrit = new Sections
                {
                    ID = 0
                };
            }
            dataGridView1.DataSource = DependencyFacade.GetSections(searchCrit, null);
            for (int i = 2; i < 5; i++)
            {
                DataGridViewColumn col = dataGridView1.Columns[i];
                col.Width = 60;
            }
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[5].Width = 250;
        }

        private void Sections_Activated(object sender, EventArgs e)
        {
            if (flag == 1)
                SearchButton_Click(sender, e);
        }

        private void Sections_Deactivate(object sender, EventArgs e) => flag = 1;

        private void DelTopicButton_Click(object sender, EventArgs e)
        {
            Sections grp = new Sections();
            Topics top = new Topics();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if(row.Cells[4].Value != null)
                {
                    top.ID = (int)row.Cells[4].Value;
                    top.Status = "Open";
                    DependencyFacade.UpdateTopics(top);

                    grp.ID = (int)row.Cells[0].Value;
                    grp.GroupSize = (byte)row.Cells[1].Value;
                    grp.TopicID = null;
                    grp.SemID = (int)row.Cells[3].Value;
                    grp.Status = row.Cells[2].Value.ToString();
                    DependencyFacade.UpdateSection(grp);
                }
            }
            SearchButton_Click(sender, e);
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 0)
            {
                AddMark mrk = new AddMark(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
                mrk.ShowDialog();
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {

            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var exportFile = System.IO.Path.Combine(exportFolder, "MarkSummary.pdf");

            Users[] users = UserFacade.GetStudentsToPDFForm(LoginPanel.TeacherID);
            Students_Groups[] groups = DependencyFacade.GetStudentsGroupsPDF(LoginPanel.TeacherID);
            Table tab = new Table(3);

            tab.AddCell("Section number:");
            tab.AddCell("Album number:");
            tab.AddCell("Mark:");

            using (var writer = new PdfWriter(exportFile))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    if(groups != null)
                    {
                        var doc = new Document(pdf);
                        doc.Add(new Paragraph("List of grades for semester:\n\n\n\n\n\n").SetRelativePosition(200,20,50,200));
                        for (int i = 0; i < groups.Length; i++)
                        {
                            tab.AddCell(groups[i].GroupID.ToString());
                            tab.AddCell(groups[i].StudentAlbumNr + ": ");
                            if (!groups[i].Mark.ToString().Equals(null))
                                tab.AddCell(groups[i].Mark.ToString());
                            else
                                tab.AddCell("No mark");
                        }
                        doc.Add(tab);
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer;

namespace GUI
{
    public partial class Presences : Form
    {
        int secID;
        public Presences(int sectionID)
        {
            InitializeComponent();
            secID = sectionID;
            Users[] users;
            Presence[] pres;
            users = UserFacade.GetSectionSquad(sectionID);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            pres = DependencyFacade.GetPresence();

            for (int i = 0; i < users.Length; i++)
            {
                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                column.Name = users[i].Name + " " + users[i].Surname;
                column.HeaderText = users[i].Name + " " + users[i].Surname;
                column.FalseValue = 0;
                column.TrueValue = 1;
                dataGridView1.Columns.Insert(i, column);
            }

            for(int j = 0; j < pres.Length; j++)
            {
                for(int k = 0; k < users.Length; k++)
                {
                    int id = UserFacade.GetGroupStudentID(users[k].ID);
                    if (id == pres[j].Group_StudentID)
                    {
                        var datetime = pres[j].Date;
                        var date = datetime.ToShortDateString();
                        dataGridView1.Rows.Add();
                        dataGridView1.RowHeadersWidth = 120;
                        dataGridView1.Rows[0].HeaderCell.Value = date;
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DependencyFacade.InsertPresenceDate(secID);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // zapis do bazy
            this.Hide();
        }
    }
}

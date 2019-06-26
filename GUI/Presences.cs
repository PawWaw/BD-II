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
        public int temp = 0;
        public List<DateTime> presDates = new List<DateTime>();
        Users[] users;
        Presence[] pres;

        public Presences(int sectionID)
        {
            InitializeComponent();
            secID = sectionID;    
        }

        private void Presences_Load(object sender, EventArgs e)
        {
            users = UserFacade.GetSectionSquad(secID);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            pres = DependencyFacade.GetPresence();

            for (int i = 0; i < users.Length; i++)
            {
                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn
                {
                    Name = users[i].Name + " " + users[i].Surname,
                    HeaderText = users[i].Name + " " + users[i].Surname,
                    FalseValue = 0,
                    TrueValue = 1
                };
                dataGridView1.Columns.Insert(i, column);
            }

            for (int j = 0; j < pres.Length; j++)
            {
                for (int k = 0; k < users.Length; k++)
                {
                    int id = 0;
                    Students_Groups[] stdgrp = UserFacade.GetGroupStudentID(users[k].ID);
                    for (int l = 0; l < stdgrp.Length; l++)
                    {
                        if (stdgrp[l].Active == true)
                            id = stdgrp[l].ID;
                    }
                    if (id == pres[j].Group_StudentID)
                    {
                        var datetime = pres[j].Date;
                        var date = datetime.ToShortDateString();
                        if (dataGridView1.Rows.Count == 0)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.RowHeadersWidth = 120;
                            dataGridView1.Rows[0].HeaderCell.Value = date;
                            presDates.Add(pres[j].Date);
                        }
                        else
                        {
                            temp = 0;
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                if (date.Equals(dataGridView1.Rows[i].HeaderCell.Value.ToString()))
                                {
                                    temp = 1;
                                }
                            }
                            if (temp == 0)
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.RowHeadersWidth = 120;
                                dataGridView1.Rows[dataGridView1.Rows.Count - 1].HeaderCell.Value = date;
                                presDates.Add(pres[j].Date);
                            }
                            temp = 0;
                        }
                    }
                }
            }
            int flag = 0;

            for (int k = 0; k < presDates.Count; k++)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    for (int j = 0; j < pres.Length; j++)
                    {
                        Students_Groups[] stdgrp = UserFacade.GetGroupStudentID(users[i].ID);
                        for (int l = 0; l < stdgrp.Length; l++)
                        {
                            if (stdgrp[l].Active == true)
                            {
                                if (stdgrp[l].ID == pres[j].Group_StudentID && presDates[k] == pres[j].Date)
                                {
                                    dataGridView1[i, k].Value = pres[j].Present;
                                    flag = 1;
                                }
                            }
                        }
                    }
                    if (flag == 0)
                    {
                        dataGridView1[i, k].ReadOnly = true;
                        dataGridView1[i, k].Value = false;
                    }
                    flag = 0;
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
            this.Hide();
            Presences prs = new Presences(secID);
            prs.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < presDates.Count; i++)
            {
                for(int j = 0; j < users.Length; j++)
                {
                    Students_Groups[] stdgrp = UserFacade.GetGroupStudentID(users[j].ID);
                    for (int l = 0; l < stdgrp.Length; l++)
                    {
                        if (stdgrp[l].Active == true)
                        {
                            DependencyFacade.UpdatePresences(presDates[i], stdgrp[l].ID, dataGridView1[j, i].Value.ToString());
                        }
                    }
                }
            }
            this.Hide();
        }
    }
}

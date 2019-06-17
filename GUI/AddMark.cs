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
    public partial class AddMark : Form
    {
        Users[] stg;
        int secID;

        public AddMark(int id)
        {
            InitializeComponent();
            secID = id;
            SectionTextbox.Text = id.ToString();
            StudentCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            stg = UserFacade.GetSectionSquad(id);
            for(int i = 0; i < stg.Length; i++)
            {
                StudentCombobox.Items.Add(stg[i].Name + " " + stg[i].Surname);
            }
            if(stg.Length !=  0)
                StudentCombobox.SelectedIndex = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(stg.Length != 0)
            {
                UserFacade.UpdateMark(stg[StudentCombobox.SelectedIndex].ID, Convert.ToDouble(MarkCombobox.SelectedItem));
                this.Hide();
            }
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FilesButton_Click_1(object sender, EventArgs e)
        {
            FileHistory flh = new FileHistory(secID);
            flh.ShowDialog();
        }
    }
}

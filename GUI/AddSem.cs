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
    public partial class AddSem : Form
    {
        public AddSem()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(StudyTextbox.Text != "" && YearTextbox.Text != "" && SemTextbox.Text != "")
            {
                Sems sem = new Sems();
                sem.StudyField = StudyTextbox.Text;
                sem.Year = Convert.ToInt16(YearTextbox.Text);
                sem.Sem = Convert.ToInt16(SemTextbox.Text);
                DependencyFacade.InsertSem(sem);
                this.Hide();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

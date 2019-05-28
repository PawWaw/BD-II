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
    public partial class AddSection : Form
    {
        Sections searchCrit;
        public AddSection()
        {
            InitializeComponent();
            SectionTextbox1.Text = (DependencyFacade.GetMaxSecID() + 1).ToString();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            searchCrit = new Sections
            {
                GroupSize = Convert.ToByte(QuantityTextbox.Text),
            };
            DependencyFacade.InsertSection(searchCrit);
            this.Hide();
        }
    }
}

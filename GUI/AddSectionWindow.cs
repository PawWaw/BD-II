using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddSectionWindow : Form
    {
        public AddSectionWindow()
        {
            InitializeComponent();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // DO DODANIA - zapis do bazy danych
            this.Hide();
        }
    }
}

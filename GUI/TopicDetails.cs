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
    public partial class TopicDetails : Form
    {
        public TopicDetails()
        {
            InitializeComponent();
        }

        public TopicDetails(int mode)
        {
            if(mode == 0)
            {
                InitializeComponent();
                StatusCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            }
            else if(mode == 1)
            {
                InitializeComponent();
                StatusCombobox.Enabled = false;
                StatusCombobox.SelectedIndex = 0;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // DO DODANIA - zapis do bazy danych
            this.Hide();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

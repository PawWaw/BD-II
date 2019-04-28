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
    public partial class AddUser : Form
    {
        public AddUser()                              
        {
            InitializeComponent();
            DegreeTextbox.Enabled = false;
            AlbumTextbox.Enabled = false;
        }

        public AddUser(int windowType)
        {
            if(windowType == 0)
            {
                InitializeComponent();
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
            }
            else if(windowType == 1)
            {
                InitializeComponent();
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
                PswdLabel.Visible = false;
                PswdTextbox.Visible = false;
                PswdButton.Visible = true;
                this.Text = "Change Data";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddUserWindow_Load(object sender, EventArgs e)
        {

        }

        private void FunctionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FunctionCombobox.SelectedIndex == 1)
            {
                DegreeTextbox.Enabled = true;
                AlbumTextbox.Enabled = false;
            }
            else if (FunctionCombobox.SelectedIndex == 2)
            {
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = true;
            }
            else
            {
                DegreeTextbox.Enabled = false;
                AlbumTextbox.Enabled = false;
            }
        }

        private void PswdButton_Click(object sender, EventArgs e)
        {
            PswdChange pswd = new PswdChange();
            pswd.ShowDialog();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            AlbumTextbox.Enabled = false;
            TypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            AddUser adu = new AddUser(1);
            adu.ShowDialog();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUser adu = new AddUser(0);
            adu.ShowDialog();        
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPanel log = new LoginPanel();
            log.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCombobox.SelectedIndex == 1)
                AlbumTextbox.Enabled = true;
            else
            {
                AlbumTextbox.Enabled = false;
            }
        }
    }
}

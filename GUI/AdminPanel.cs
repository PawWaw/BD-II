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
    public partial class AdminPanel : Form
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        byte flag = 0;
        
        Users userSearchCriteria;

        public AdminPanel()
        {
            InitializeComponent();
            AlbumTextbox.Enabled = false;
            TypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ViewUsers(string type)
        {
            userSearchCriteria = new Users
            {
                Surname = SurnameTextbox.Text,
                Name = NameTextbox.Text
            };

            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = UserFacade.GetUsers(userSearchCriteria, type);
            dataGridView1.Columns.Remove("Password");

            for (int i = 0; i < 5; i++)
            {
                DataGridViewColumn col = dataGridView1.Columns[i];
                col.Width = 130;
            }
        }

        private void ViewStudents()
        {
            userSearchCriteria = new Users
            {
                Surname = SurnameTextbox.Text,
                Name = NameTextbox.Text
            };
            int nr = 0;
            if (AlbumTextbox.Text != "")
                nr = Convert.ToInt32(AlbumTextbox.Text);
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = UserFacade.GetStudents(userSearchCriteria, nr);
            dataGridView1.Columns.Remove("Password");
            dataGridView1.Columns.Remove("UserID");
            for (int i = 0; i < 6; i++)
            {
                DataGridViewColumn col = dataGridView1.Columns[i];
                col.Width = 130;
            }
        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                user.ID = (int)row.Cells[0].Value;
                user.Login = (string)row.Cells[1].Value;
                user.Name = (string)row.Cells[2].Value;
                user.Surname = (string)row.Cells[3].Value;
                if (String.Equals((string)row.Cells[4].Value, "std"))
                    user.TypeOfUser = "2";
                else if (String.Equals((string)row.Cells[4].Value, "tch"))
                    user.TypeOfUser = "1";
                else
                    user.TypeOfUser = "0";
            }
            AddUser adu = new AddUser(1, user);
            adu.ShowDialog();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            AddUser adu = new AddUser(0, user);
            adu.ShowDialog();        
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPanel log = new LoginPanel();
            log.Show();
        }

        private void TypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCombobox.SelectedIndex == 1)
                AlbumTextbox.Enabled = true;
            else
                AlbumTextbox.Enabled = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (Equals(TypeCombobox.SelectedItem, "Std"))
                ViewStudents();
            else if (Equals(TypeCombobox.SelectedItem, "Tch"))
                ViewUsers("Tch");
            else if (Equals(TypeCombobox.SelectedItem, "Adm"))
                ViewUsers("Adm");
            else
                ViewUsers("");
        }

        private void AdminPanel_Deactivate(object sender, EventArgs e) => flag = 1;

        private void AdminPanel_Activated(object sender, EventArgs e)
        {
            if (flag == 1)
                SearchButton_Click(sender, e);
        }
    }
}

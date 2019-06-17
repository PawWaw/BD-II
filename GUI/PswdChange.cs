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
    public partial class PswdChange : Form
    {
        Hashing hash = new Hashing();
        Users usr;

        public PswdChange(Users user)
        {
            usr = user;
            if (user.TypeOfUser == "2")
                user.TypeOfUser = "std";
            else if (user.TypeOfUser == "1")
                user.TypeOfUser = "tch";
            else
                user.TypeOfUser = "adm";
            InitializeComponent();
            LoginTextbox.Text = user.Login.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            usr.Salt = hash.CreateSalt(10);
            usr.Hash = hash.GenSalt(PswdTextbox.Text, usr.Salt);
            UserFacade.UpdateUsers(usr);
            this.Hide();
        }
    }
}

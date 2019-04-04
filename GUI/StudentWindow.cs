using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StudentWindow : Form
    {
        public StudentWindow()
        {
            InitializeComponent();
            SectionCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SignUpButton.Enabled = false;
            LeaveButton.Enabled = false;
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {       
            while(true)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(openFileDialog1.FileName).Equals(".pdf"))
                    {
                        FilenameLabel.Text = openFileDialog1.SafeFileName;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Please choose file with pdf extension.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else { break; }
            }        
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginWindow log = new LoginWindow();
            log.Show();
        }

        private void SectionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SectionCombobox.SelectedIndex == 0)
            {
                SignUpButton.Enabled = false;
                LeaveButton.Enabled = true;
            }
            else if (SectionCombobox.SelectedIndex == 1)
            {
                SignUpButton.Enabled = true;
                LeaveButton.Enabled = false;
            }
        }
    }
}

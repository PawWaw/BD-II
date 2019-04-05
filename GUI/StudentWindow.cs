﻿using System;
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
            System.Boolean noErrors = false;
            while(!noErrors)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    switch(Path.GetExtension(openFileDialog1.FileName).ToLower())
                    {
                        case ".pdf":
                        case ".zip":
                        case ".7z"://Add case here if you add some filter
                            FilenameLabel.Text = openFileDialog1.SafeFileName;
                            noErrors = true;
                            break;
                        default:
                            MessageBox.Show("Please choose file with pdf extension or archive file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
                else { noErrors = true; }
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

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
    public partial class LecturerWindow : Form
    {
        public LecturerWindow()
        {
            InitializeComponent();
            MarkCombobox.SelectedIndex = 0;
            CourseCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            TopicCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SectionNameCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SectionNameCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            MarkCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

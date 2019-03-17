namespace GUI
{
    partial class StudentWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignedUpCombobox = new System.Windows.Forms.ComboBox();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.LeaveLabel = new System.Windows.Forms.Label();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.LeaveCombobox = new System.Windows.Forms.ComboBox();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(180, 100);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(100, 30);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // SignedUpCombobox
            // 
            this.SignedUpCombobox.FormattingEnabled = true;
            this.SignedUpCombobox.Location = new System.Drawing.Point(180, 60);
            this.SignedUpCombobox.Name = "SignedUpCombobox";
            this.SignedUpCombobox.Size = new System.Drawing.Size(120, 24);
            this.SignedUpCombobox.TabIndex = 1;
            this.SignedUpCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.Location = new System.Drawing.Point(30, 60);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(140, 23);
            this.SignUpLabel.TabIndex = 2;
            this.SignUpLabel.Text = "Available sections";
            // 
            // LeaveLabel
            // 
            this.LeaveLabel.Location = new System.Drawing.Point(420, 60);
            this.LeaveLabel.Name = "LeaveLabel";
            this.LeaveLabel.Size = new System.Drawing.Size(100, 23);
            this.LeaveLabel.TabIndex = 3;
            this.LeaveLabel.Text = "Leave section";
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(530, 100);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(100, 30);
            this.LeaveButton.TabIndex = 4;
            this.LeaveButton.Text = "Leave";
            this.LeaveButton.UseVisualStyleBackColor = true;
            // 
            // LeaveCombobox
            // 
            this.LeaveCombobox.FormattingEnabled = true;
            this.LeaveCombobox.Location = new System.Drawing.Point(530, 60);
            this.LeaveCombobox.Name = "LeaveCombobox";
            this.LeaveCombobox.Size = new System.Drawing.Size(120, 24);
            this.LeaveCombobox.TabIndex = 5;
            this.LeaveCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(180, 250);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(100, 30);
            this.AddFileButton.TabIndex = 6;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Filter = "PDF Files (*.pdf) | *.pdf";
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.Location = new System.Drawing.Point(180, 290);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(400, 23);
            this.FilenameLabel.TabIndex = 7;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(530, 250);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(100, 30);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.LeaveCombobox);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.LeaveLabel);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.SignedUpCombobox);
            this.Controls.Add(this.SignUpButton);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "StudentWindow";
            this.Text = "Student On-Line";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.ComboBox SignedUpCombobox;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Label LeaveLabel;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.ComboBox LeaveCombobox;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.Button LogoutButton;
    }
}
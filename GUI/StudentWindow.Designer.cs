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
            this.LeaveButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SectionCombobox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(550, 70);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(100, 30);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(550, 130);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(100, 30);
            this.LeaveButton.TabIndex = 4;
            this.LeaveButton.Text = "Leave";
            this.LeaveButton.UseVisualStyleBackColor = true;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(550, 190);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(100, 30);
            this.AddFileButton.TabIndex = 6;
            this.AddFileButton.Text = "Add File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // openFileDialog1
            // 
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
            this.LogoutButton.Location = new System.Drawing.Point(550, 250);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(100, 30);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(493, 256);
            this.dataGridView1.TabIndex = 9;
            // 
            // SectionCombobox
            // 
            this.SectionCombobox.FormattingEnabled = true;
            this.SectionCombobox.Items.AddRange(new object[] {
            "My sections",
            "All sections"});
            this.SectionCombobox.Location = new System.Drawing.Point(171, 27);
            this.SectionCombobox.Name = "SectionCombobox";
            this.SectionCombobox.Size = new System.Drawing.Size(121, 24);
            this.SectionCombobox.TabIndex = 10;
            this.SectionCombobox.SelectedIndexChanged += new System.EventHandler(this.SectionCombobox_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(31, 30);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(114, 17);
            this.TypeLabel.TabIndex = 11;
            this.TypeLabel.Text = "Choose Sections";
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(672, 343);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.SectionCombobox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.SignUpButton);
            this.MaximumSize = new System.Drawing.Size(690, 400);
            this.MinimumSize = new System.Drawing.Size(690, 390);
            this.Name = "StudentWindow";
            this.Text = "Student On-Line";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox SectionCombobox;
        private System.Windows.Forms.Label TypeLabel;
    }
}
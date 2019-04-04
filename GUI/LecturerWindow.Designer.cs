namespace GUI
{
    partial class LecturerWindow
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
            this.NewSectionButton = new System.Windows.Forms.Button();
            this.AddMarkButton = new System.Windows.Forms.Button();
            this.SectionStatusButton = new System.Windows.Forms.Button();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.SectionCombobox = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.TopicButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewSectionButton
            // 
            this.NewSectionButton.Location = new System.Drawing.Point(558, 130);
            this.NewSectionButton.Name = "NewSectionButton";
            this.NewSectionButton.Size = new System.Drawing.Size(100, 30);
            this.NewSectionButton.TabIndex = 0;
            this.NewSectionButton.Text = "Add section";
            this.NewSectionButton.UseVisualStyleBackColor = true;
            this.NewSectionButton.Click += new System.EventHandler(this.NewSectionButton_Click);
            // 
            // AddMarkButton
            // 
            this.AddMarkButton.Location = new System.Drawing.Point(558, 70);
            this.AddMarkButton.Name = "AddMarkButton";
            this.AddMarkButton.Size = new System.Drawing.Size(100, 30);
            this.AddMarkButton.TabIndex = 1;
            this.AddMarkButton.Text = "Add Mark";
            this.AddMarkButton.UseVisualStyleBackColor = true;
            this.AddMarkButton.Click += new System.EventHandler(this.AddMarkButton_Click);
            // 
            // SectionStatusButton
            // 
            this.SectionStatusButton.Location = new System.Drawing.Point(558, 250);
            this.SectionStatusButton.Name = "SectionStatusButton";
            this.SectionStatusButton.Size = new System.Drawing.Size(100, 30);
            this.SectionStatusButton.TabIndex = 8;
            this.SectionStatusButton.Text = "Set status";
            this.SectionStatusButton.UseVisualStyleBackColor = true;
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "Final"});
            this.StatusCombobox.Location = new System.Drawing.Point(537, 23);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(121, 24);
            this.StatusCombobox.TabIndex = 9;
            // 
            // SectionCombobox
            // 
            this.SectionCombobox.Location = new System.Drawing.Point(30, 23);
            this.SectionCombobox.Name = "SectionCombobox";
            this.SectionCombobox.Size = new System.Drawing.Size(100, 23);
            this.SectionCombobox.TabIndex = 11;
            this.SectionCombobox.Text = "Section name";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(465, 23);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 23);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "Status";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(558, 310);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(100, 30);
            this.LogoutButton.TabIndex = 20;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // TopicButton
            // 
            this.TopicButton.Location = new System.Drawing.Point(558, 190);
            this.TopicButton.Name = "TopicButton";
            this.TopicButton.Size = new System.Drawing.Size(100, 30);
            this.TopicButton.TabIndex = 27;
            this.TopicButton.Text = "Add Topic";
            this.TopicButton.UseVisualStyleBackColor = true;
            this.TopicButton.Click += new System.EventHandler(this.TopicButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 28;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(260, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 23);
            this.NameLabel.TabIndex = 29;
            this.NameLabel.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(501, 440);
            this.dataGridView1.TabIndex = 31;
            // 
            // LecturerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(682, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TopicButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SectionCombobox);
            this.Controls.Add(this.StatusCombobox);
            this.Controls.Add(this.SectionStatusButton);
            this.Controls.Add(this.AddMarkButton);
            this.Controls.Add(this.NewSectionButton);
            this.MaximumSize = new System.Drawing.Size(700, 570);
            this.MinimumSize = new System.Drawing.Size(700, 570);
            this.Name = "LecturerWindow";
            this.Text = "Lecturer On-Line";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewSectionButton;
        private System.Windows.Forms.Button AddMarkButton;
        private System.Windows.Forms.Button SectionStatusButton;
        private System.Windows.Forms.ComboBox StatusCombobox;
        private System.Windows.Forms.Label SectionCombobox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button TopicButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
namespace GUI
{
    partial class MoreInfo
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
            this.TopicLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TeacherLabel = new System.Windows.Forms.Label();
            this.StudentsLabel = new System.Windows.Forms.Label();
            this.TeacherTextbox = new System.Windows.Forms.TextBox();
            this.PlacesTexbox = new System.Windows.Forms.TextBox();
            this.StatusTextbox = new System.Windows.Forms.TextBox();
            this.DetailsTextbox = new System.Windows.Forms.RichTextBox();
            this.MembersTextbox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.MarkTextbox = new System.Windows.Forms.TextBox();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.TopicTextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TopicLabel
            // 
            this.TopicLabel.AutoSize = true;
            this.TopicLabel.Location = new System.Drawing.Point(30, 25);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(47, 17);
            this.TopicLabel.TabIndex = 0;
            this.TopicLabel.Text = "Topic:";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(30, 100);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(55, 17);
            this.DetailsLabel.TabIndex = 1;
            this.DetailsLabel.Text = "Details:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(30, 250);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(86, 17);
            this.SizeLabel.TabIndex = 2;
            this.SizeLabel.Text = "Free places:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(30, 400);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 17);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status";
            // 
            // TeacherLabel
            // 
            this.TeacherLabel.AutoSize = true;
            this.TeacherLabel.Location = new System.Drawing.Point(30, 200);
            this.TeacherLabel.Name = "TeacherLabel";
            this.TeacherLabel.Size = new System.Drawing.Size(65, 17);
            this.TeacherLabel.TabIndex = 4;
            this.TeacherLabel.Text = "Teacher:";
            // 
            // StudentsLabel
            // 
            this.StudentsLabel.AutoSize = true;
            this.StudentsLabel.Location = new System.Drawing.Point(30, 300);
            this.StudentsLabel.Name = "StudentsLabel";
            this.StudentsLabel.Size = new System.Drawing.Size(66, 17);
            this.StudentsLabel.TabIndex = 5;
            this.StudentsLabel.Text = "Members";
            // 
            // TeacherTextbox
            // 
            this.TeacherTextbox.Enabled = false;
            this.TeacherTextbox.Location = new System.Drawing.Point(150, 200);
            this.TeacherTextbox.Name = "TeacherTextbox";
            this.TeacherTextbox.Size = new System.Drawing.Size(200, 22);
            this.TeacherTextbox.TabIndex = 8;
            // 
            // PlacesTexbox
            // 
            this.PlacesTexbox.Enabled = false;
            this.PlacesTexbox.Location = new System.Drawing.Point(150, 250);
            this.PlacesTexbox.Name = "PlacesTexbox";
            this.PlacesTexbox.Size = new System.Drawing.Size(200, 22);
            this.PlacesTexbox.TabIndex = 9;
            // 
            // StatusTextbox
            // 
            this.StatusTextbox.Enabled = false;
            this.StatusTextbox.Location = new System.Drawing.Point(150, 400);
            this.StatusTextbox.Name = "StatusTextbox";
            this.StatusTextbox.Size = new System.Drawing.Size(200, 22);
            this.StatusTextbox.TabIndex = 11;
            // 
            // DetailsTextbox
            // 
            this.DetailsTextbox.Enabled = false;
            this.DetailsTextbox.Location = new System.Drawing.Point(150, 100);
            this.DetailsTextbox.Name = "DetailsTextbox";
            this.DetailsTextbox.Size = new System.Drawing.Size(200, 80);
            this.DetailsTextbox.TabIndex = 12;
            this.DetailsTextbox.Text = "";
            // 
            // MembersTextbox
            // 
            this.MembersTextbox.Enabled = false;
            this.MembersTextbox.Location = new System.Drawing.Point(150, 300);
            this.MembersTextbox.Name = "MembersTextbox";
            this.MembersTextbox.Size = new System.Drawing.Size(200, 80);
            this.MembersTextbox.TabIndex = 13;
            this.MembersTextbox.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(30, 500);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 30);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Join and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(250, 500);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 30);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(30, 450);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(43, 17);
            this.MarkLabel.TabIndex = 16;
            this.MarkLabel.Text = "Mark:";
            this.MarkLabel.Visible = false;
            // 
            // MarkTextbox
            // 
            this.MarkTextbox.Enabled = false;
            this.MarkTextbox.Location = new System.Drawing.Point(150, 450);
            this.MarkTextbox.Name = "MarkTextbox";
            this.MarkTextbox.Size = new System.Drawing.Size(200, 22);
            this.MarkTextbox.TabIndex = 17;
            this.MarkTextbox.Visible = false;
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "Final"});
            this.StatusCombobox.Location = new System.Drawing.Point(150, 400);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(200, 24);
            this.StatusCombobox.TabIndex = 19;
            this.StatusCombobox.Visible = false;
            // 
            // TopicTextbox
            // 
            this.TopicTextbox.Enabled = false;
            this.TopicTextbox.Location = new System.Drawing.Point(150, 25);
            this.TopicTextbox.Name = "TopicTextbox";
            this.TopicTextbox.Size = new System.Drawing.Size(200, 53);
            this.TopicTextbox.TabIndex = 20;
            this.TopicTextbox.Text = "";
            // 
            // MoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.TopicTextbox);
            this.Controls.Add(this.StatusCombobox);
            this.Controls.Add(this.MarkTextbox);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MembersTextbox);
            this.Controls.Add(this.DetailsTextbox);
            this.Controls.Add(this.StatusTextbox);
            this.Controls.Add(this.PlacesTexbox);
            this.Controls.Add(this.TeacherTextbox);
            this.Controls.Add(this.StudentsLabel);
            this.Controls.Add(this.TeacherLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.TopicLabel);
            this.Name = "MoreInfo";
            this.Text = "Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label TeacherLabel;
        private System.Windows.Forms.Label StudentsLabel;
        private System.Windows.Forms.TextBox TeacherTextbox;
        private System.Windows.Forms.TextBox PlacesTexbox;
        private System.Windows.Forms.TextBox StatusTextbox;
        private System.Windows.Forms.RichTextBox DetailsTextbox;
        private System.Windows.Forms.RichTextBox MembersTextbox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.TextBox MarkTextbox;
        private System.Windows.Forms.ComboBox StatusCombobox;
        private System.Windows.Forms.RichTextBox TopicTextbox;
    }
}
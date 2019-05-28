namespace GUI
{
    partial class TopicDetails
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
            this.TopicInfoLabel = new System.Windows.Forms.Label();
            this.InfoRichTextbox = new System.Windows.Forms.RichTextBox();
            this.TopicTextbox = new System.Windows.Forms.TextBox();
            this.TopicNameLabel = new System.Windows.Forms.Label();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusCombobox = new System.Windows.Forms.ComboBox();
            this.TeacherLabel = new System.Windows.Forms.Label();
            this.TeacherTextbox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TopicInfoLabel
            // 
            this.TopicInfoLabel.Location = new System.Drawing.Point(31, 128);
            this.TopicInfoLabel.Name = "TopicInfoLabel";
            this.TopicInfoLabel.Size = new System.Drawing.Size(100, 23);
            this.TopicInfoLabel.TabIndex = 30;
            this.TopicInfoLabel.Text = "Information";
            // 
            // InfoRichTextbox
            // 
            this.InfoRichTextbox.Location = new System.Drawing.Point(161, 128);
            this.InfoRichTextbox.Name = "InfoRichTextbox";
            this.InfoRichTextbox.Size = new System.Drawing.Size(319, 100);
            this.InfoRichTextbox.TabIndex = 29;
            this.InfoRichTextbox.Text = "";
            // 
            // TopicTextbox
            // 
            this.TopicTextbox.Location = new System.Drawing.Point(161, 78);
            this.TopicTextbox.Name = "TopicTextbox";
            this.TopicTextbox.Size = new System.Drawing.Size(319, 22);
            this.TopicTextbox.TabIndex = 28;
            // 
            // TopicNameLabel
            // 
            this.TopicNameLabel.Location = new System.Drawing.Point(31, 78);
            this.TopicNameLabel.Name = "TopicNameLabel";
            this.TopicNameLabel.Size = new System.Drawing.Size(100, 23);
            this.TopicNameLabel.TabIndex = 27;
            this.TopicNameLabel.Text = "Topic name";
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(380, 360);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(100, 45);
            this.LeaveButton.TabIndex = 32;
            this.LeaveButton.Text = "Close";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(253, 360);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 45);
            this.SaveButton.TabIndex = 31;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(34, 258);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(100, 23);
            this.StatusLabel.TabIndex = 33;
            this.StatusLabel.Text = "Status";
            // 
            // StatusCombobox
            // 
            this.StatusCombobox.FormattingEnabled = true;
            this.StatusCombobox.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "Final"});
            this.StatusCombobox.Location = new System.Drawing.Point(161, 258);
            this.StatusCombobox.Name = "StatusCombobox";
            this.StatusCombobox.Size = new System.Drawing.Size(319, 24);
            this.StatusCombobox.TabIndex = 34;
            // 
            // TeacherLabel
            // 
            this.TeacherLabel.AutoSize = true;
            this.TeacherLabel.Location = new System.Drawing.Point(34, 308);
            this.TeacherLabel.Name = "TeacherLabel";
            this.TeacherLabel.Size = new System.Drawing.Size(65, 17);
            this.TeacherLabel.TabIndex = 35;
            this.TeacherLabel.Text = "Teacher:";
            // 
            // TeacherTextbox
            // 
            this.TeacherTextbox.Location = new System.Drawing.Point(161, 308);
            this.TeacherTextbox.Name = "TeacherTextbox";
            this.TeacherTextbox.Size = new System.Drawing.Size(319, 22);
            this.TeacherTextbox.TabIndex = 36;
            // 
            // IDlabel
            // 
            this.IDlabel.Location = new System.Drawing.Point(31, 28);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(100, 23);
            this.IDlabel.TabIndex = 37;
            this.IDlabel.Text = "ID:";
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(161, 28);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(319, 22);
            this.IDTextbox.TabIndex = 38;
            // 
            // TopicDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 453);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.TeacherTextbox);
            this.Controls.Add(this.TeacherLabel);
            this.Controls.Add(this.StatusCombobox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TopicInfoLabel);
            this.Controls.Add(this.InfoRichTextbox);
            this.Controls.Add(this.TopicTextbox);
            this.Controls.Add(this.TopicNameLabel);
            this.MaximumSize = new System.Drawing.Size(528, 500);
            this.MinimumSize = new System.Drawing.Size(528, 500);
            this.Name = "TopicDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopicInfoLabel;
        private System.Windows.Forms.RichTextBox InfoRichTextbox;
        private System.Windows.Forms.TextBox TopicTextbox;
        private System.Windows.Forms.Label TopicNameLabel;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusCombobox;
        private System.Windows.Forms.Label TeacherLabel;
        private System.Windows.Forms.TextBox TeacherTextbox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox IDTextbox;
    }
}
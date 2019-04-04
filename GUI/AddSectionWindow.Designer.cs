namespace GUI
{
    partial class AddSectionWindow
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
            this.TopicCombobox = new System.Windows.Forms.ComboBox();
            this.TopicLabel = new System.Windows.Forms.Label();
            this.CourseCombobox = new System.Windows.Forms.ComboBox();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.SectionTextbox1 = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.SectionNameLabel1 = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopicCombobox
            // 
            this.TopicCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TopicCombobox.FormattingEnabled = true;
            this.TopicCombobox.Location = new System.Drawing.Point(137, 154);
            this.TopicCombobox.Name = "TopicCombobox";
            this.TopicCombobox.Size = new System.Drawing.Size(120, 24);
            this.TopicCombobox.TabIndex = 30;
            // 
            // TopicLabel
            // 
            this.TopicLabel.Location = new System.Drawing.Point(40, 153);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(100, 23);
            this.TopicLabel.TabIndex = 29;
            this.TopicLabel.Text = "Topic";
            // 
            // CourseCombobox
            // 
            this.CourseCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseCombobox.FormattingEnabled = true;
            this.CourseCombobox.Location = new System.Drawing.Point(137, 34);
            this.CourseCombobox.Name = "CourseCombobox";
            this.CourseCombobox.Size = new System.Drawing.Size(120, 24);
            this.CourseCombobox.TabIndex = 28;
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Location = new System.Drawing.Point(137, 114);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(120, 22);
            this.QuantityTextbox.TabIndex = 27;
            // 
            // SectionTextbox1
            // 
            this.SectionTextbox1.Location = new System.Drawing.Point(137, 74);
            this.SectionTextbox1.Name = "SectionTextbox1";
            this.SectionTextbox1.Size = new System.Drawing.Size(120, 22);
            this.SectionTextbox1.TabIndex = 26;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(37, 114);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(61, 17);
            this.QuantityLabel.TabIndex = 25;
            this.QuantityLabel.Text = "Quantity";
            // 
            // SectionNameLabel1
            // 
            this.SectionNameLabel1.AutoSize = true;
            this.SectionNameLabel1.Location = new System.Drawing.Point(37, 74);
            this.SectionNameLabel1.Name = "SectionNameLabel1";
            this.SectionNameLabel1.Size = new System.Drawing.Size(94, 17);
            this.SectionNameLabel1.TabIndex = 24;
            this.SectionNameLabel1.Text = "Section name";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(37, 34);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(53, 17);
            this.CourseLabel.TabIndex = 23;
            this.CourseLabel.Text = "Course";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(30, 210);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 45);
            this.SaveButton.TabIndex = 31;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(170, 210);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(100, 45);
            this.LeaveButton.TabIndex = 32;
            this.LeaveButton.Text = "Leave";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // AddSectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 293);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TopicCombobox);
            this.Controls.Add(this.TopicLabel);
            this.Controls.Add(this.CourseCombobox);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.SectionTextbox1);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.SectionNameLabel1);
            this.Controls.Add(this.CourseLabel);
            this.MaximumSize = new System.Drawing.Size(300, 340);
            this.MinimumSize = new System.Drawing.Size(300, 340);
            this.Name = "AddSectionWindow";
            this.Text = "AddSectionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TopicCombobox;
        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.ComboBox CourseCombobox;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.TextBox SectionTextbox1;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label SectionNameLabel1;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LeaveButton;
    }
}
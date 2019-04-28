namespace GUI
{
    partial class AddMark
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
            this.MarkCombobox = new System.Windows.Forms.ComboBox();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.SectionNameLabel2 = new System.Windows.Forms.Label();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MarkCombobox
            // 
            this.MarkCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkCombobox.FormattingEnabled = true;
            this.MarkCombobox.Items.AddRange(new object[] {
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5"});
            this.MarkCombobox.Location = new System.Drawing.Point(151, 75);
            this.MarkCombobox.Name = "MarkCombobox";
            this.MarkCombobox.Size = new System.Drawing.Size(120, 24);
            this.MarkCombobox.TabIndex = 25;
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(41, 75);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(43, 17);
            this.MarkLabel.TabIndex = 22;
            this.MarkLabel.Text = "Mark:";
            // 
            // SectionNameLabel2
            // 
            this.SectionNameLabel2.AutoSize = true;
            this.SectionNameLabel2.Location = new System.Drawing.Point(41, 35);
            this.SectionNameLabel2.Name = "SectionNameLabel2";
            this.SectionNameLabel2.Size = new System.Drawing.Size(59, 17);
            this.SectionNameLabel2.TabIndex = 20;
            this.SectionNameLabel2.Text = "Section:";
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(171, 140);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(100, 45);
            this.LeaveButton.TabIndex = 28;
            this.LeaveButton.Text = "Close";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(151, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 29;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(44, 140);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 45);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 223);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MarkCombobox);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.SectionNameLabel2);
            this.MaximumSize = new System.Drawing.Size(337, 270);
            this.MinimumSize = new System.Drawing.Size(337, 270);
            this.Name = "AddMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMarkWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox MarkCombobox;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.Label SectionNameLabel2;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveButton;
    }
}
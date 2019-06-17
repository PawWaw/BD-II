namespace GUI
{
    partial class AddSem
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
            this.StudyLabel = new System.Windows.Forms.Label();
            this.YearButton = new System.Windows.Forms.Label();
            this.SemButton = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StudyTextbox = new System.Windows.Forms.TextBox();
            this.YearTextbox = new System.Windows.Forms.TextBox();
            this.SemTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudyLabel
            // 
            this.StudyLabel.Location = new System.Drawing.Point(32, 50);
            this.StudyLabel.Name = "StudyLabel";
            this.StudyLabel.Size = new System.Drawing.Size(100, 23);
            this.StudyLabel.TabIndex = 0;
            this.StudyLabel.Text = "Study field:";
            // 
            // YearButton
            // 
            this.YearButton.Location = new System.Drawing.Point(32, 90);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(100, 23);
            this.YearButton.TabIndex = 1;
            this.YearButton.Text = "Year:";
            // 
            // SemButton
            // 
            this.SemButton.Location = new System.Drawing.Point(32, 130);
            this.SemButton.Name = "SemButton";
            this.SemButton.Size = new System.Drawing.Size(100, 23);
            this.SemButton.TabIndex = 2;
            this.SemButton.Text = "Semester:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(35, 182);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 30);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(173, 182);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 30);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StudyTextbox
            // 
            this.StudyTextbox.Location = new System.Drawing.Point(173, 50);
            this.StudyTextbox.Name = "StudyTextbox";
            this.StudyTextbox.Size = new System.Drawing.Size(100, 22);
            this.StudyTextbox.TabIndex = 5;
            // 
            // YearTextbox
            // 
            this.YearTextbox.Location = new System.Drawing.Point(173, 90);
            this.YearTextbox.Name = "YearTextbox";
            this.YearTextbox.Size = new System.Drawing.Size(100, 22);
            this.YearTextbox.TabIndex = 6;
            // 
            // SemTextbox
            // 
            this.SemTextbox.Location = new System.Drawing.Point(173, 127);
            this.SemTextbox.Name = "SemTextbox";
            this.SemTextbox.Size = new System.Drawing.Size(100, 22);
            this.SemTextbox.TabIndex = 7;
            // 
            // AddSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 244);
            this.Controls.Add(this.SemTextbox);
            this.Controls.Add(this.YearTextbox);
            this.Controls.Add(this.StudyTextbox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SemButton);
            this.Controls.Add(this.YearButton);
            this.Controls.Add(this.StudyLabel);
            this.MaximumSize = new System.Drawing.Size(324, 291);
            this.MinimumSize = new System.Drawing.Size(324, 291);
            this.Name = "AddSem";
            this.Text = "AddSem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudyLabel;
        private System.Windows.Forms.Label YearButton;
        private System.Windows.Forms.Label SemButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox StudyTextbox;
        private System.Windows.Forms.TextBox YearTextbox;
        private System.Windows.Forms.TextBox SemTextbox;
    }
}
namespace GUI
{
    partial class AddTopicWindow
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
            this.SuspendLayout();
            // 
            // TopicInfoLabel
            // 
            this.TopicInfoLabel.Location = new System.Drawing.Point(33, 78);
            this.TopicInfoLabel.Name = "TopicInfoLabel";
            this.TopicInfoLabel.Size = new System.Drawing.Size(100, 23);
            this.TopicInfoLabel.TabIndex = 30;
            this.TopicInfoLabel.Text = "Information";
            // 
            // InfoRichTextbox
            // 
            this.InfoRichTextbox.Location = new System.Drawing.Point(163, 78);
            this.InfoRichTextbox.Name = "InfoRichTextbox";
            this.InfoRichTextbox.Size = new System.Drawing.Size(319, 100);
            this.InfoRichTextbox.TabIndex = 29;
            this.InfoRichTextbox.Text = "";
            // 
            // TopicTextbox
            // 
            this.TopicTextbox.Location = new System.Drawing.Point(163, 28);
            this.TopicTextbox.Name = "TopicTextbox";
            this.TopicTextbox.Size = new System.Drawing.Size(319, 22);
            this.TopicTextbox.TabIndex = 28;
            // 
            // TopicNameLabel
            // 
            this.TopicNameLabel.Location = new System.Drawing.Point(33, 28);
            this.TopicNameLabel.Name = "TopicNameLabel";
            this.TopicNameLabel.Size = new System.Drawing.Size(100, 23);
            this.TopicNameLabel.TabIndex = 27;
            this.TopicNameLabel.Text = "Topic name";
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(382, 210);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(100, 45);
            this.LeaveButton.TabIndex = 32;
            this.LeaveButton.Text = "Leave";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(255, 210);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 45);
            this.SaveButton.TabIndex = 31;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddTopicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 310);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TopicInfoLabel);
            this.Controls.Add(this.InfoRichTextbox);
            this.Controls.Add(this.TopicTextbox);
            this.Controls.Add(this.TopicNameLabel);
            this.MaximumSize = new System.Drawing.Size(528, 357);
            this.MinimumSize = new System.Drawing.Size(528, 357);
            this.Name = "AddTopicWindow";
            this.Text = "AddTopicWindow";
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
    }
}
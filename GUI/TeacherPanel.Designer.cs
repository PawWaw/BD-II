namespace GUI
{
    partial class TeacherPanel
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
            this.TopicButton = new System.Windows.Forms.Button();
            this.NewSectionButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopicButton
            // 
            this.TopicButton.Location = new System.Drawing.Point(85, 136);
            this.TopicButton.Name = "TopicButton";
            this.TopicButton.Size = new System.Drawing.Size(120, 50);
            this.TopicButton.TabIndex = 30;
            this.TopicButton.Text = "Add/Edit Topic";
            this.TopicButton.UseVisualStyleBackColor = true;
            this.TopicButton.Click += new System.EventHandler(this.TopicButton_Click);
            // 
            // NewSectionButton
            // 
            this.NewSectionButton.Location = new System.Drawing.Point(85, 45);
            this.NewSectionButton.Name = "NewSectionButton";
            this.NewSectionButton.Size = new System.Drawing.Size(120, 50);
            this.NewSectionButton.TabIndex = 28;
            this.NewSectionButton.Text = "Add/Edit Section";
            this.NewSectionButton.UseVisualStyleBackColor = true;
            this.NewSectionButton.Click += new System.EventHandler(this.NewSectionButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(85, 222);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(120, 50);
            this.LogoutButton.TabIndex = 31;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 327);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.TopicButton);
            this.Controls.Add(this.NewSectionButton);
            this.Name = "TeacherPanel";
            this.Text = "Teacher Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TopicButton;
        private System.Windows.Forms.Button NewSectionButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}
namespace GUI
{
    partial class AdminWindow
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
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.AlbumTextbox = new System.Windows.Forms.TextBox();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.ChangeDataLabel = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.Location = new System.Drawing.Point(370, 149);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(120, 30);
            this.ChangeDataButton.TabIndex = 0;
            this.ChangeDataButton.Text = "Change Data";
            this.ChangeDataButton.UseVisualStyleBackColor = true;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // AlbumTextbox
            // 
            this.AlbumTextbox.Location = new System.Drawing.Point(370, 100);
            this.AlbumTextbox.Name = "AlbumTextbox";
            this.AlbumTextbox.Size = new System.Drawing.Size(120, 22);
            this.AlbumTextbox.TabIndex = 1;
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.Location = new System.Drawing.Point(250, 100);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(100, 22);
            this.AlbumLabel.TabIndex = 3;
            this.AlbumLabel.Text = "Album number";
            // 
            // ChangeDataLabel
            // 
            this.ChangeDataLabel.Location = new System.Drawing.Point(300, 50);
            this.ChangeDataLabel.Name = "ChangeDataLabel";
            this.ChangeDataLabel.Size = new System.Drawing.Size(120, 23);
            this.ChangeDataLabel.TabIndex = 5;
            this.ChangeDataLabel.Text = "Change personal data:";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(58, 149);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(100, 30);
            this.AddUserButton.TabIndex = 6;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(370, 205);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(120, 30);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(532, 253);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.ChangeDataLabel);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.AlbumTextbox);
            this.Controls.Add(this.ChangeDataButton);
            this.MaximumSize = new System.Drawing.Size(550, 300);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeDataButton;
        private System.Windows.Forms.TextBox AlbumTextbox;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label ChangeDataLabel;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}
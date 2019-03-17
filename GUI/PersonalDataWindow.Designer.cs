namespace GUI
{
    partial class PersonalDataWindow
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
            this.PswdTextbox = new System.Windows.Forms.TextBox();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.PswdLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SectionTextbox = new System.Windows.Forms.TextBox();
            this.AlbumTextbox = new System.Windows.Forms.TextBox();
            this.Section = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PswdTextbox
            // 
            this.PswdTextbox.Location = new System.Drawing.Point(200, 200);
            this.PswdTextbox.Name = "PswdTextbox";
            this.PswdTextbox.PasswordChar = '*';
            this.PswdTextbox.Size = new System.Drawing.Size(100, 22);
            this.PswdTextbox.TabIndex = 43;
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(200, 150);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(100, 22);
            this.LoginTextbox.TabIndex = 42;
            // 
            // PswdLabel
            // 
            this.PswdLabel.Location = new System.Drawing.Point(50, 200);
            this.PswdLabel.Name = "PswdLabel";
            this.PswdLabel.Size = new System.Drawing.Size(100, 22);
            this.PswdLabel.TabIndex = 41;
            this.PswdLabel.Text = "Password";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Location = new System.Drawing.Point(50, 150);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(100, 22);
            this.LoginLabel.TabIndex = 40;
            this.LoginLabel.Text = "Login";
            // 
            // SectionTextbox
            // 
            this.SectionTextbox.Location = new System.Drawing.Point(200, 100);
            this.SectionTextbox.Name = "SectionTextbox";
            this.SectionTextbox.Size = new System.Drawing.Size(100, 22);
            this.SectionTextbox.TabIndex = 37;
            // 
            // AlbumTextbox
            // 
            this.AlbumTextbox.Location = new System.Drawing.Point(200, 50);
            this.AlbumTextbox.Name = "AlbumTextbox";
            this.AlbumTextbox.Size = new System.Drawing.Size(100, 22);
            this.AlbumTextbox.TabIndex = 31;
            // 
            // Section
            // 
            this.Section.Location = new System.Drawing.Point(50, 100);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(100, 22);
            this.Section.TabIndex = 30;
            this.Section.Text = "Section";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.Location = new System.Drawing.Point(50, 50);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(100, 22);
            this.AlbumLabel.TabIndex = 24;
            this.AlbumLabel.Text = "Album number";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(50, 250);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(100, 30);
            this.AddUserButton.TabIndex = 23;
            this.AddUserButton.Text = "Change Data";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(200, 250);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 30);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PersonalDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(332, 323);
            this.Controls.Add(this.PswdTextbox);
            this.Controls.Add(this.LoginTextbox);
            this.Controls.Add(this.PswdLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.SectionTextbox);
            this.Controls.Add(this.AlbumTextbox);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.CloseButton);
            this.MaximumSize = new System.Drawing.Size(350, 370);
            this.MinimumSize = new System.Drawing.Size(350, 370);
            this.Name = "PersonalDataWindow";
            this.Text = "PersonalDataWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PswdTextbox;
        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.Label PswdLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox SectionTextbox;
        private System.Windows.Forms.TextBox AlbumTextbox;
        private System.Windows.Forms.Label Section;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button CloseButton;
    }
}
namespace GUI
{
    partial class AddUserWindow
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.AlbumTextbox = new System.Windows.Forms.TextBox();
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.FunctionCombobox = new System.Windows.Forms.ComboBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PswdLabel = new System.Windows.Forms.Label();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.PswdTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(200, 250);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 30);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(50, 250);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(100, 30);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.Location = new System.Drawing.Point(50, 50);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(100, 22);
            this.AlbumLabel.TabIndex = 2;
            this.AlbumLabel.Text = "Album number";
            // 
            // AlbumTextbox
            // 
            this.AlbumTextbox.Location = new System.Drawing.Point(200, 50);
            this.AlbumTextbox.Name = "AlbumTextbox";
            this.AlbumTextbox.Size = new System.Drawing.Size(100, 22);
            this.AlbumTextbox.TabIndex = 9;
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.Location = new System.Drawing.Point(50, 100);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(100, 22);
            this.FunctionLabel.TabIndex = 16;
            this.FunctionLabel.Text = "Function";
            // 
            // FunctionCombobox
            // 
            this.FunctionCombobox.FormattingEnabled = true;
            this.FunctionCombobox.Items.AddRange(new object[] {
            "Admin",
            "Lecturer",
            "Student"});
            this.FunctionCombobox.Location = new System.Drawing.Point(200, 100);
            this.FunctionCombobox.Name = "FunctionCombobox";
            this.FunctionCombobox.Size = new System.Drawing.Size(100, 24);
            this.FunctionCombobox.TabIndex = 17;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Location = new System.Drawing.Point(50, 150);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(100, 22);
            this.LoginLabel.TabIndex = 18;
            this.LoginLabel.Text = "Login";
            // 
            // PswdLabel
            // 
            this.PswdLabel.Location = new System.Drawing.Point(50, 200);
            this.PswdLabel.Name = "PswdLabel";
            this.PswdLabel.Size = new System.Drawing.Size(100, 22);
            this.PswdLabel.TabIndex = 19;
            this.PswdLabel.Text = "Password";
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(200, 150);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(100, 22);
            this.LoginTextbox.TabIndex = 20;
            // 
            // PswdTextbox
            // 
            this.PswdTextbox.Location = new System.Drawing.Point(200, 200);
            this.PswdTextbox.Name = "PswdTextbox";
            this.PswdTextbox.PasswordChar = '*';
            this.PswdTextbox.Size = new System.Drawing.Size(100, 22);
            this.PswdTextbox.TabIndex = 21;
            // 
            // AddUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 323);
            this.Controls.Add(this.PswdTextbox);
            this.Controls.Add(this.LoginTextbox);
            this.Controls.Add(this.PswdLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.FunctionCombobox);
            this.Controls.Add(this.FunctionLabel);
            this.Controls.Add(this.AlbumTextbox);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.CloseButton);
            this.MaximumSize = new System.Drawing.Size(350, 370);
            this.MinimumSize = new System.Drawing.Size(350, 370);
            this.Name = "AddUserWindow";
            this.Text = "AddUserWindow";
            this.Load += new System.EventHandler(this.AddUserWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.TextBox AlbumTextbox;
        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.ComboBox FunctionCombobox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PswdLabel;
        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.TextBox PswdTextbox;
    }
}
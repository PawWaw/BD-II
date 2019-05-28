namespace GUI
{
    partial class AddUser
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
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextbox = new System.Windows.Forms.TextBox();
            this.DegreeTextbox = new System.Windows.Forms.TextBox();
            this.PswdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(200, 470);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 45);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(50, 470);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(100, 45);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Save and Exit";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.Location = new System.Drawing.Point(50, 320);
            this.AlbumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(110, 22);
            this.AlbumLabel.TabIndex = 2;
            this.AlbumLabel.Text = "Album number:";
            // 
            // AlbumTextbox
            // 
            this.AlbumTextbox.Location = new System.Drawing.Point(200, 320);
            this.AlbumTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.AlbumTextbox.Name = "AlbumTextbox";
            this.AlbumTextbox.Size = new System.Drawing.Size(100, 22);
            this.AlbumTextbox.TabIndex = 9;
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.Location = new System.Drawing.Point(50, 220);
            this.FunctionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(100, 22);
            this.FunctionLabel.TabIndex = 16;
            this.FunctionLabel.Text = "Function:";
            // 
            // FunctionCombobox
            // 
            this.FunctionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FunctionCombobox.FormattingEnabled = true;
            this.FunctionCombobox.Items.AddRange(new object[] {
            "Admin",
            "Teacher",
            "Student"});
            this.FunctionCombobox.Location = new System.Drawing.Point(200, 220);
            this.FunctionCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.FunctionCombobox.Name = "FunctionCombobox";
            this.FunctionCombobox.Size = new System.Drawing.Size(100, 24);
            this.FunctionCombobox.TabIndex = 17;
            this.FunctionCombobox.SelectedIndexChanged += new System.EventHandler(this.FunctionCombobox_SelectedIndexChanged);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Location = new System.Drawing.Point(50, 370);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(100, 22);
            this.LoginLabel.TabIndex = 18;
            this.LoginLabel.Text = "Login:";
            // 
            // PswdLabel
            // 
            this.PswdLabel.Location = new System.Drawing.Point(50, 420);
            this.PswdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PswdLabel.Name = "PswdLabel";
            this.PswdLabel.Size = new System.Drawing.Size(100, 22);
            this.PswdLabel.TabIndex = 19;
            this.PswdLabel.Text = "Password:";
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(200, 370);
            this.LoginTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(100, 22);
            this.LoginTextbox.TabIndex = 20;
            // 
            // PswdTextbox
            // 
            this.PswdTextbox.Location = new System.Drawing.Point(200, 420);
            this.PswdTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.PswdTextbox.Name = "PswdTextbox";
            this.PswdTextbox.PasswordChar = '*';
            this.PswdTextbox.Size = new System.Drawing.Size(100, 22);
            this.PswdTextbox.TabIndex = 21;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Location = new System.Drawing.Point(50, 170);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(100, 23);
            this.SurnameLabel.TabIndex = 22;
            this.SurnameLabel.Text = "Last Name:";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(50, 120);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 23);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "First Name:";
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Location = new System.Drawing.Point(50, 270);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(122, 17);
            this.DegreeLabel.TabIndex = 24;
            this.DegreeLabel.Text = "Academic degree:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(50, 70);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 17);
            this.IDLabel.TabIndex = 25;
            this.IDLabel.Text = "ID:";
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(200, 70);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(100, 22);
            this.IDTextbox.TabIndex = 26;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(200, 120);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 27;
            // 
            // SurnameTextbox
            // 
            this.SurnameTextbox.Location = new System.Drawing.Point(200, 170);
            this.SurnameTextbox.Name = "SurnameTextbox";
            this.SurnameTextbox.Size = new System.Drawing.Size(100, 22);
            this.SurnameTextbox.TabIndex = 28;
            // 
            // DegreeTextbox
            // 
            this.DegreeTextbox.Location = new System.Drawing.Point(200, 270);
            this.DegreeTextbox.Name = "DegreeTextbox";
            this.DegreeTextbox.Size = new System.Drawing.Size(100, 22);
            this.DegreeTextbox.TabIndex = 29;
            // 
            // PswdButton
            // 
            this.PswdButton.Location = new System.Drawing.Point(50, 420);
            this.PswdButton.Name = "PswdButton";
            this.PswdButton.Size = new System.Drawing.Size(250, 30);
            this.PswdButton.TabIndex = 30;
            this.PswdButton.Text = "Change Password";
            this.PswdButton.UseVisualStyleBackColor = true;
            this.PswdButton.Visible = false;
            this.PswdButton.Click += new System.EventHandler(this.PswdButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(332, 553);
            this.Controls.Add(this.PswdButton);
            this.Controls.Add(this.DegreeTextbox);
            this.Controls.Add(this.SurnameTextbox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.DegreeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(350, 600);
            this.MinimumSize = new System.Drawing.Size(350, 600);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
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
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextbox;
        private System.Windows.Forms.TextBox DegreeTextbox;
        private System.Windows.Forms.Button PswdButton;
    }
}
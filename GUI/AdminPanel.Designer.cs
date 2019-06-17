namespace GUI
{
    partial class AdminPanel
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
            this.AddUserButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SurnameTextbox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountTypeLabel = new System.Windows.Forms.Label();
            this.TypeCombobox = new System.Windows.Forms.ComboBox();
            this.AlbumNumberLabel = new System.Windows.Forms.Label();
            this.AlbumTextbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.Location = new System.Drawing.Point(850, 150);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(100, 30);
            this.ChangeDataButton.TabIndex = 0;
            this.ChangeDataButton.Text = "Change Data";
            this.ChangeDataButton.UseVisualStyleBackColor = true;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(850, 90);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(100, 30);
            this.AddUserButton.TabIndex = 6;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(850, 210);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(100, 30);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SurnameTextbox
            // 
            this.SurnameTextbox.Location = new System.Drawing.Point(110, 30);
            this.SurnameTextbox.Name = "SurnameTextbox";
            this.SurnameTextbox.Size = new System.Drawing.Size(100, 22);
            this.SurnameTextbox.TabIndex = 8;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Location = new System.Drawing.Point(30, 30);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(80, 22);
            this.SurnameLabel.TabIndex = 9;
            this.SurnameLabel.Text = "Last Name";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(230, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 22);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "First Name";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(310, 30);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(100, 22);
            this.NameTextbox.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 12;
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.Location = new System.Drawing.Point(430, 30);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(100, 22);
            this.AccountTypeLabel.TabIndex = 13;
            this.AccountTypeLabel.Text = "Account Type";
            // 
            // TypeCombobox
            // 
            this.TypeCombobox.FormattingEnabled = true;
            this.TypeCombobox.Items.AddRange(new object[] {
            "Adm",
            "Std",
            "Tch",
            "All"});
            this.TypeCombobox.Location = new System.Drawing.Point(530, 30);
            this.TypeCombobox.Name = "TypeCombobox";
            this.TypeCombobox.Size = new System.Drawing.Size(60, 24);
            this.TypeCombobox.TabIndex = 14;
            this.TypeCombobox.SelectedIndexChanged += new System.EventHandler(this.TypeCombobox_SelectedIndexChanged);
            // 
            // AlbumNumberLabel
            // 
            this.AlbumNumberLabel.Location = new System.Drawing.Point(610, 30);
            this.AlbumNumberLabel.Name = "AlbumNumberLabel";
            this.AlbumNumberLabel.Size = new System.Drawing.Size(110, 22);
            this.AlbumNumberLabel.TabIndex = 15;
            this.AlbumNumberLabel.Text = "Album Number";
            // 
            // AlbumTextbox
            // 
            this.AlbumTextbox.Location = new System.Drawing.Point(720, 30);
            this.AlbumTextbox.Name = "AlbumTextbox";
            this.AlbumTextbox.Size = new System.Drawing.Size(100, 22);
            this.AlbumTextbox.TabIndex = 16;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(850, 30);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 30);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AlbumTextbox);
            this.Controls.Add(this.AlbumNumberLabel);
            this.Controls.Add(this.TypeCombobox);
            this.Controls.Add(this.AccountTypeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnameTextbox);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.ChangeDataButton);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminWindow";
            this.Activated += new System.EventHandler(this.AdminPanel_Activated);
            this.Deactivate += new System.EventHandler(this.AdminPanel_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeDataButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TextBox SurnameTextbox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label AccountTypeLabel;
        private System.Windows.Forms.ComboBox TypeCombobox;
        private System.Windows.Forms.Label AlbumNumberLabel;
        private System.Windows.Forms.TextBox AlbumTextbox;
        private System.Windows.Forms.Button SearchButton;
    }
}
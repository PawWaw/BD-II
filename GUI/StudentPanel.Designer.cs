namespace GUI
{
    partial class StudentWindow
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
            this.AddFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InfoButton = new System.Windows.Forms.Button();
            this.MySecButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(650, 150);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(100, 30);
            this.AddFileButton.TabIndex = 6;
            this.AddFileButton.Text = "Handle File";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf|Zip Files (*.zip;*.7z)|*7z;*.zip";
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.Location = new System.Drawing.Point(180, 290);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(400, 23);
            this.FilenameLabel.TabIndex = 7;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(650, 270);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(100, 30);
            this.LogoutButton.TabIndex = 8;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 300);
            this.dataGridView1.TabIndex = 9;
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(650, 30);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(100, 30);
            this.InfoButton.TabIndex = 12;
            this.InfoButton.Text = "Details";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // MySecButton
            // 
            this.MySecButton.Location = new System.Drawing.Point(650, 90);
            this.MySecButton.Name = "MySecButton";
            this.MySecButton.Size = new System.Drawing.Size(100, 30);
            this.MySecButton.TabIndex = 13;
            this.MySecButton.Text = "My Section";
            this.MySecButton.UseVisualStyleBackColor = true;
            this.MySecButton.Click += new System.EventHandler(this.MySecButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(650, 210);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(100, 30);
            this.HistoryButton.TabIndex = 14;
            this.HistoryButton.Text = "Sent Files";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(772, 343);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.MySecButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.AddFileButton);
            this.MaximumSize = new System.Drawing.Size(790, 400);
            this.MinimumSize = new System.Drawing.Size(790, 390);
            this.Name = "StudentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student On-Line";
            this.Load += new System.EventHandler(this.StudentWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button MySecButton;
        private System.Windows.Forms.Button HistoryButton;
    }
}
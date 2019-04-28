namespace GUI
{
    partial class Sections
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
            this.SectionLabel = new System.Windows.Forms.Label();
            this.SectionTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Section_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.TopicButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PresenceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionLabel
            // 
            this.SectionLabel.Location = new System.Drawing.Point(30, 23);
            this.SectionLabel.Name = "SectionLabel";
            this.SectionLabel.Size = new System.Drawing.Size(100, 23);
            this.SectionLabel.TabIndex = 11;
            this.SectionLabel.Text = "Section ID";
            // 
            // SectionTextbox
            // 
            this.SectionTextbox.Location = new System.Drawing.Point(140, 23);
            this.SectionTextbox.Name = "SectionTextbox";
            this.SectionTextbox.Size = new System.Drawing.Size(150, 22);
            this.SectionTextbox.TabIndex = 28;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(360, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 23);
            this.NameLabel.TabIndex = 29;
            this.NameLabel.Text = "Name";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(420, 23);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(150, 22);
            this.NameTextbox.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Section_ID,
            this.Topic,
            this.Size,
            this.Status,
            this.Mark});
            this.dataGridView1.Location = new System.Drawing.Point(33, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 440);
            this.dataGridView1.TabIndex = 31;
            // 
            // Section_ID
            // 
            this.Section_ID.HeaderText = "ID";
            this.Section_ID.Name = "Section_ID";
            this.Section_ID.Width = 50;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Topic";
            this.Topic.Name = "Topic";
            this.Topic.Width = 200;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(670, 20);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 30);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(670, 480);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 30);
            this.CloseButton.TabIndex = 33;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(670, 70);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(100, 30);
            this.DetailsButton.TabIndex = 34;
            this.DetailsButton.Text = "Details/Edit";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // TopicButton
            // 
            this.TopicButton.Location = new System.Drawing.Point(670, 170);
            this.TopicButton.Name = "TopicButton";
            this.TopicButton.Size = new System.Drawing.Size(100, 30);
            this.TopicButton.TabIndex = 35;
            this.TopicButton.Text = "Set topic";
            this.TopicButton.UseVisualStyleBackColor = true;
            this.TopicButton.Click += new System.EventHandler(this.TopicButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(670, 120);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 30);
            this.AddButton.TabIndex = 36;
            this.AddButton.Text = "Add new";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PresenceButton
            // 
            this.PresenceButton.Location = new System.Drawing.Point(670, 220);
            this.PresenceButton.Name = "PresenceButton";
            this.PresenceButton.Size = new System.Drawing.Size(100, 30);
            this.PresenceButton.TabIndex = 37;
            this.PresenceButton.Text = "Presences";
            this.PresenceButton.UseVisualStyleBackColor = true;
            this.PresenceButton.Click += new System.EventHandler(this.PresenceButton_Click);
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(782, 523);
            this.Controls.Add(this.PresenceButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TopicButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SectionTextbox);
            this.Controls.Add(this.SectionLabel);
            this.MaximumSize = new System.Drawing.Size(800, 570);
            this.MinimumSize = new System.Drawing.Size(800, 570);
            this.Name = "Sections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sections";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SectionLabel;
        private System.Windows.Forms.TextBox SectionTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Button TopicButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button PresenceButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
    }
}
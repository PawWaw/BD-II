namespace GUI
{
    partial class SectionPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.TopicButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PresenceButton = new System.Windows.Forms.Button();
            this.DelTopicButton = new System.Windows.Forms.Button();
            this.GradesButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
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
            this.SectionTextbox.Size = new System.Drawing.Size(493, 22);
            this.SectionTextbox.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 440);
            this.dataGridView1.TabIndex = 31;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(670, 20);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 30);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.PresenceButton.Location = new System.Drawing.Point(670, 270);
            this.PresenceButton.Name = "PresenceButton";
            this.PresenceButton.Size = new System.Drawing.Size(100, 30);
            this.PresenceButton.TabIndex = 37;
            this.PresenceButton.Text = "Presences";
            this.PresenceButton.UseVisualStyleBackColor = true;
            this.PresenceButton.Click += new System.EventHandler(this.PresenceButton_Click);
            // 
            // DelTopicButton
            // 
            this.DelTopicButton.Location = new System.Drawing.Point(670, 220);
            this.DelTopicButton.Name = "DelTopicButton";
            this.DelTopicButton.Size = new System.Drawing.Size(100, 30);
            this.DelTopicButton.TabIndex = 38;
            this.DelTopicButton.Text = "Delete topic";
            this.DelTopicButton.UseVisualStyleBackColor = true;
            this.DelTopicButton.Click += new System.EventHandler(this.DelTopicButton_Click);
            // 
            // GradesButton
            // 
            this.GradesButton.Location = new System.Drawing.Point(670, 320);
            this.GradesButton.Name = "GradesButton";
            this.GradesButton.Size = new System.Drawing.Size(100, 30);
            this.GradesButton.TabIndex = 39;
            this.GradesButton.Text = "Grades";
            this.GradesButton.UseVisualStyleBackColor = true;
            this.GradesButton.Click += new System.EventHandler(this.GradesButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(670, 370);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 30);
            this.GenerateButton.TabIndex = 40;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(782, 523);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.GradesButton);
            this.Controls.Add(this.DelTopicButton);
            this.Controls.Add(this.PresenceButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TopicButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SectionTextbox);
            this.Controls.Add(this.SectionLabel);
            this.MaximumSize = new System.Drawing.Size(800, 570);
            this.MinimumSize = new System.Drawing.Size(800, 570);
            this.Name = "SectionPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sections";
            this.Activated += new System.EventHandler(this.Sections_Activated);
            this.Deactivate += new System.EventHandler(this.Sections_Deactivate);
            this.Load += new System.EventHandler(this.SectionPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SectionLabel;
        private System.Windows.Forms.TextBox SectionTextbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Button TopicButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button PresenceButton;
        private System.Windows.Forms.Button DelTopicButton;
        private System.Windows.Forms.Button GradesButton;
        private System.Windows.Forms.Button GenerateButton;
    }
}
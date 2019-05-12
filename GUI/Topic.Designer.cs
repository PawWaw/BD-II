namespace GUI
{
    partial class Topic
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
            this.DetailsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TopicTextbox = new System.Windows.Forms.TextBox();
            this.TopicLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(673, 81);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(100, 30);
            this.DetailsButton.TabIndex = 42;
            this.DetailsButton.Text = "Details/Edit";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(673, 491);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 30);
            this.CloseButton.TabIndex = 41;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(673, 31);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 30);
            this.SearchButton.TabIndex = 40;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 440);
            this.dataGridView1.TabIndex = 39;
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(423, 34);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(150, 22);
            this.IDTextbox.TabIndex = 38;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(383, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 23);
            this.NameLabel.TabIndex = 37;
            this.NameLabel.Text = "ID:";
            // 
            // TopicTextbox
            // 
            this.TopicTextbox.Location = new System.Drawing.Point(143, 34);
            this.TopicTextbox.Name = "TopicTextbox";
            this.TopicTextbox.Size = new System.Drawing.Size(150, 22);
            this.TopicTextbox.TabIndex = 36;
            // 
            // TopicLabel
            // 
            this.TopicLabel.Location = new System.Drawing.Point(33, 34);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(100, 23);
            this.TopicLabel.TabIndex = 35;
            this.TopicLabel.Text = "Topic name:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(673, 131);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 30);
            this.AddButton.TabIndex = 43;
            this.AddButton.Text = "Add new";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 552);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TopicTextbox);
            this.Controls.Add(this.TopicLabel);
            this.MaximumSize = new System.Drawing.Size(820, 599);
            this.MinimumSize = new System.Drawing.Size(820, 599);
            this.Name = "Topic";
            this.Text = "Topics";
            this.Activated += new System.EventHandler(this.Topic_Activated);
            this.Deactivate += new System.EventHandler(this.Topic_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox TopicTextbox;
        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.Button AddButton;
    }
}
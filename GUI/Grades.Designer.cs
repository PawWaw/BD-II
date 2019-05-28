namespace GUI
{
    partial class Grades
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Topic,
            this.Mark});
            this.dataGridView1.Location = new System.Drawing.Point(36, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(572, 376);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 30);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(572, 102);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(100, 30);
            this.HistoryButton.TabIndex = 2;
            this.HistoryButton.Text = "File History";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(572, 36);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 30);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add/Edit";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "Section ID";
            this.ID.Name = "ID";
            this.ID.Width = 70;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Topic";
            this.Topic.Name = "Topic";
            this.Topic.Width = 300;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            this.Mark.Width = 50;
            // 
            // Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Marks";
            this.Text = "Marks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
    }
}
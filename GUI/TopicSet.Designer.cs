namespace GUI
{
    partial class TopicSet
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TopicTextbox = new System.Windows.Forms.TextBox();
            this.SectionTexbox = new System.Windows.Forms.TextBox();
            this.TopicLabel = new System.Windows.Forms.Label();
            this.SectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(43, 158);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 45);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TopicTextbox
            // 
            this.TopicTextbox.Location = new System.Drawing.Point(150, 100);
            this.TopicTextbox.Name = "TopicTextbox";
            this.TopicTextbox.Size = new System.Drawing.Size(100, 22);
            this.TopicTextbox.TabIndex = 2;
            // 
            // SectionTexbox
            // 
            this.SectionTexbox.Location = new System.Drawing.Point(150, 50);
            this.SectionTexbox.Name = "SectionTexbox";
            this.SectionTexbox.Size = new System.Drawing.Size(100, 22);
            this.SectionTexbox.TabIndex = 3;
            // 
            // TopicLabel
            // 
            this.TopicLabel.AutoSize = true;
            this.TopicLabel.Location = new System.Drawing.Point(40, 100);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(64, 17);
            this.TopicLabel.TabIndex = 4;
            this.TopicLabel.Text = "Topic ID:";
            // 
            // SectionLabel
            // 
            this.SectionLabel.AutoSize = true;
            this.SectionLabel.Location = new System.Drawing.Point(40, 50);
            this.SectionLabel.Name = "SectionLabel";
            this.SectionLabel.Size = new System.Drawing.Size(76, 17);
            this.SectionLabel.TabIndex = 5;
            this.SectionLabel.Text = "Section ID:";
            // 
            // TopicSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 230);
            this.Controls.Add(this.SectionLabel);
            this.Controls.Add(this.TopicLabel);
            this.Controls.Add(this.SectionTexbox);
            this.Controls.Add(this.TopicTextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveButton);
            this.MaximumSize = new System.Drawing.Size(314, 277);
            this.MinimumSize = new System.Drawing.Size(314, 277);
            this.Name = "TopicSet";
            this.Text = "TopicSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TopicTextbox;
        private System.Windows.Forms.TextBox SectionTexbox;
        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.Label SectionLabel;
    }
}
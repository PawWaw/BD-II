namespace GUI
{
    partial class AddSection
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
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.SectionTextbox1 = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.SectionNameLabel1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Location = new System.Drawing.Point(136, 74);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(120, 22);
            this.QuantityTextbox.TabIndex = 27;
            // 
            // SectionTextbox1
            // 
            this.SectionTextbox1.Enabled = false;
            this.SectionTextbox1.Location = new System.Drawing.Point(136, 34);
            this.SectionTextbox1.Name = "SectionTextbox1";
            this.SectionTextbox1.Size = new System.Drawing.Size(120, 22);
            this.SectionTextbox1.TabIndex = 26;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(36, 74);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(61, 17);
            this.QuantityLabel.TabIndex = 25;
            this.QuantityLabel.Text = "Group Size:";
            // 
            // SectionNameLabel1
            // 
            this.SectionNameLabel1.AutoSize = true;
            this.SectionNameLabel1.Location = new System.Drawing.Point(36, 34);
            this.SectionNameLabel1.Name = "SectionNameLabel1";
            this.SectionNameLabel1.Size = new System.Drawing.Size(72, 17);
            this.SectionNameLabel1.TabIndex = 24;
            this.SectionNameLabel1.Text = "Section ID";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(30, 144);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 45);
            this.SaveButton.TabIndex = 31;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LeaveButton
            // 
            this.LeaveButton.Location = new System.Drawing.Point(156, 144);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(100, 45);
            this.LeaveButton.TabIndex = 32;
            this.LeaveButton.Text = "Close";
            this.LeaveButton.UseVisualStyleBackColor = true;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // AddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 243);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.SectionTextbox1);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.SectionNameLabel1);
            this.MaximumSize = new System.Drawing.Size(300, 290);
            this.MinimumSize = new System.Drawing.Size(300, 290);
            this.Name = "AddSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Section";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.TextBox SectionTextbox1;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label SectionNameLabel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LeaveButton;
    }
}
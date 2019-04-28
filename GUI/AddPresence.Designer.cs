namespace GUI
{
    partial class AddPresence
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
            this.TextLabel = new System.Windows.Forms.Label();
            this.Name1ChB = new System.Windows.Forms.CheckBox();
            this.Name2ChB = new System.Windows.Forms.CheckBox();
            this.Name3ChB = new System.Windows.Forms.CheckBox();
            this.Name4ChB = new System.Windows.Forms.CheckBox();
            this.Name5ChB = new System.Windows.Forms.CheckBox();
            this.Name6ChB = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.Location = new System.Drawing.Point(61, 30);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(190, 17);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Check present students:";
            // 
            // Name1ChB
            // 
            this.Name1ChB.Location = new System.Drawing.Point(64, 70);
            this.Name1ChB.Name = "Name1ChB";
            this.Name1ChB.Size = new System.Drawing.Size(150, 21);
            this.Name1ChB.TabIndex = 1;
            this.Name1ChB.Text = "Name 1";
            this.Name1ChB.UseVisualStyleBackColor = true;
            // 
            // Name2ChB
            // 
            this.Name2ChB.Location = new System.Drawing.Point(64, 110);
            this.Name2ChB.Name = "Name2ChB";
            this.Name2ChB.Size = new System.Drawing.Size(150, 21);
            this.Name2ChB.TabIndex = 2;
            this.Name2ChB.Text = "Name 2";
            this.Name2ChB.UseVisualStyleBackColor = true;
            // 
            // Name3ChB
            // 
            this.Name3ChB.Location = new System.Drawing.Point(64, 150);
            this.Name3ChB.Name = "Name3ChB";
            this.Name3ChB.Size = new System.Drawing.Size(150, 21);
            this.Name3ChB.TabIndex = 3;
            this.Name3ChB.Text = "Name 3";
            this.Name3ChB.UseVisualStyleBackColor = true;
            // 
            // Name4ChB
            // 
            this.Name4ChB.AutoSize = true;
            this.Name4ChB.Location = new System.Drawing.Point(64, 190);
            this.Name4ChB.Name = "Name4ChB";
            this.Name4ChB.Size = new System.Drawing.Size(79, 21);
            this.Name4ChB.TabIndex = 4;
            this.Name4ChB.Text = "Name 4";
            this.Name4ChB.UseVisualStyleBackColor = true;
            // 
            // Name5ChB
            // 
            this.Name5ChB.Location = new System.Drawing.Point(64, 230);
            this.Name5ChB.Name = "Name5ChB";
            this.Name5ChB.Size = new System.Drawing.Size(150, 21);
            this.Name5ChB.TabIndex = 5;
            this.Name5ChB.Text = "Name 5";
            this.Name5ChB.UseVisualStyleBackColor = true;
            // 
            // Name6ChB
            // 
            this.Name6ChB.Location = new System.Drawing.Point(64, 270);
            this.Name6ChB.Name = "Name6ChB";
            this.Name6ChB.Size = new System.Drawing.Size(150, 21);
            this.Name6ChB.TabIndex = 6;
            this.Name6ChB.Text = "Name 6";
            this.Name6ChB.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 317);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 45);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(151, 317);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 45);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddPresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 375);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Name6ChB);
            this.Controls.Add(this.Name5ChB);
            this.Controls.Add(this.Name4ChB);
            this.Controls.Add(this.Name3ChB);
            this.Controls.Add(this.Name2ChB);
            this.Controls.Add(this.Name1ChB);
            this.Controls.Add(this.TextLabel);
            this.MaximumSize = new System.Drawing.Size(281, 422);
            this.MinimumSize = new System.Drawing.Size(281, 422);
            this.Name = "AddPresence";
            this.Text = "AddPresence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.CheckBox Name1ChB;
        private System.Windows.Forms.CheckBox Name2ChB;
        private System.Windows.Forms.CheckBox Name3ChB;
        private System.Windows.Forms.CheckBox Name4ChB;
        private System.Windows.Forms.CheckBox Name5ChB;
        private System.Windows.Forms.CheckBox Name6ChB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
    }
}
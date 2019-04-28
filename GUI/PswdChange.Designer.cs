namespace GUI
{
    partial class PswdChange
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.PswdLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(30, 150);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 45);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(135, 150);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 45);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PswdLabel
            // 
            this.PswdLabel.AutoSize = true;
            this.PswdLabel.Location = new System.Drawing.Point(30, 90);
            this.PswdLabel.Name = "PswdLabel";
            this.PswdLabel.Size = new System.Drawing.Size(72, 34);
            this.PswdLabel.TabIndex = 2;
            this.PswdLabel.Text = "New \r\npassword:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(30, 50);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(47, 17);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Login:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(110, 50);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(100, 22);
            this.LoginTextbox.TabIndex = 5;
            // 
            // PswdChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 253);
            this.Controls.Add(this.LoginTextbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PswdLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.MaximumSize = new System.Drawing.Size(250, 300);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "PswdChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PswdChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label PswdLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox LoginTextbox;
    }
}
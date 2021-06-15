
namespace FinalTest
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.PW_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.ID_Text = new System.Windows.Forms.TextBox();
            this.PW_Text = new System.Windows.Forms.TextBox();
            this.Sign_up_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-110, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // PW_label
            // 
            this.PW_label.AutoSize = true;
            this.PW_label.Location = new System.Drawing.Point(108, 166);
            this.PW_label.Name = "PW_label";
            this.PW_label.Size = new System.Drawing.Size(23, 12);
            this.PW_label.TabIndex = 1;
            this.PW_label.Text = "PW";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(108, 94);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(29, 12);
            this.ID_label.TabIndex = 2;
            this.ID_label.Text = "이름";
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(179, 226);
            this.Login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(79, 22);
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // ID_Text
            // 
            this.ID_Text.Location = new System.Drawing.Point(199, 94);
            this.ID_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_Text.Name = "ID_Text";
            this.ID_Text.Size = new System.Drawing.Size(112, 21);
            this.ID_Text.TabIndex = 4;
            // 
            // PW_Text
            // 
            this.PW_Text.Location = new System.Drawing.Point(199, 166);
            this.PW_Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PW_Text.Name = "PW_Text";
            this.PW_Text.PasswordChar = '*';
            this.PW_Text.Size = new System.Drawing.Size(112, 21);
            this.PW_Text.TabIndex = 5;
            // 
            // Sign_up_button
            // 
            this.Sign_up_button.Location = new System.Drawing.Point(360, 10);
            this.Sign_up_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sign_up_button.Name = "Sign_up_button";
            this.Sign_up_button.Size = new System.Drawing.Size(75, 18);
            this.Sign_up_button.TabIndex = 6;
            this.Sign_up_button.Text = "Sign up";
            this.Sign_up_button.UseVisualStyleBackColor = true;
            this.Sign_up_button.Click += new System.EventHandler(this.Sign_up_button_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 294);
            this.Controls.Add(this.Sign_up_button);
            this.Controls.Add(this.PW_Text);
            this.Controls.Add(this.ID_Text);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.PW_label);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PW_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox ID_Text;
        private System.Windows.Forms.TextBox PW_Text;
        private System.Windows.Forms.Button Sign_up_button;
    }
}
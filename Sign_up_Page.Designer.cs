
namespace FinalTest
{
    partial class Sign_up_Page
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
            this.Sign_Up_button = new System.Windows.Forms.Button();
            this.Name_label = new System.Windows.Forms.Label();
            this.PW_label = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.PW_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sign_Up_button
            // 
            this.Sign_Up_button.Location = new System.Drawing.Point(152, 293);
            this.Sign_Up_button.Name = "Sign_Up_button";
            this.Sign_Up_button.Size = new System.Drawing.Size(75, 23);
            this.Sign_Up_button.TabIndex = 0;
            this.Sign_Up_button.Text = "Sign Up";
            this.Sign_Up_button.UseVisualStyleBackColor = true;
            this.Sign_Up_button.Click += new System.EventHandler(this.Sign_Up_button_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(36, 105);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(31, 15);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "이름";
            // 
            // PW_label
            // 
            this.PW_label.AutoSize = true;
            this.PW_label.Location = new System.Drawing.Point(36, 197);
            this.PW_label.Name = "PW_label";
            this.PW_label.Size = new System.Drawing.Size(25, 15);
            this.PW_label.TabIndex = 2;
            this.PW_label.Text = "PW";
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(143, 105);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(100, 23);
            this.Name_textbox.TabIndex = 3;
            // 
            // PW_textbox
            // 
            this.PW_textbox.Location = new System.Drawing.Point(143, 194);
            this.PW_textbox.Name = "PW_textbox";
            this.PW_textbox.Size = new System.Drawing.Size(100, 23);
            this.PW_textbox.TabIndex = 4;
            // 
            // Sign_up_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 372);
            this.Controls.Add(this.PW_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.PW_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Sign_Up_button);
            this.Name = "Sign_up_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sign_Up_button;
        private System.Windows.Forms.Label Sign_Up_ID_textbox;
        private System.Windows.Forms.Label PW_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox PW_textbox;
    }
}
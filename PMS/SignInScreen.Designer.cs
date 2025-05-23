﻿namespace PMS
{
    partial class SignInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.closebtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Loginbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 468);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Don\'t have an account? Sign up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxemail
            // 
            this.textBoxemail.BorderRadius = 10;
            this.textBoxemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxemail.DefaultText = "";
            this.textBoxemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxemail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.textBoxemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxemail.ForeColor = System.Drawing.Color.Black;
            this.textBoxemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxemail.Location = new System.Drawing.Point(583, 230);
            this.textBoxemail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.PasswordChar = '\0';
            this.textBoxemail.PlaceholderText = "";
            this.textBoxemail.SelectedText = "";
            this.textBoxemail.Size = new System.Drawing.Size(263, 30);
            this.textBoxemail.TabIndex = 9;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BorderRadius = 10;
            this.textBoxpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxpassword.DefaultText = "";
            this.textBoxpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxpassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.textBoxpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxpassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxpassword.Location = new System.Drawing.Point(583, 344);
            this.textBoxpassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '●';
            this.textBoxpassword.PlaceholderText = "";
            this.textBoxpassword.SelectedText = "";
            this.textBoxpassword.Size = new System.Drawing.Size(263, 30);
            this.textBoxpassword.TabIndex = 10;
            this.textBoxpassword.UseSystemPasswordChar = true;
            // 
            // closebtn
            // 
            this.closebtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.closebtn.ImageRotate = 0F;
            this.closebtn.ImageSize = new System.Drawing.Size(40, 40);
            this.closebtn.Location = new System.Drawing.Point(884, 0);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.closebtn.Size = new System.Drawing.Size(48, 44);
            this.closebtn.TabIndex = 13;
            this.closebtn.Click += new System.EventHandler(this.closeBtn_click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.HoverState.ImageSize = new System.Drawing.Size(96, 30);
            this.Loginbtn.Image = ((System.Drawing.Image)(resources.GetObject("Loginbtn.Image")));
            this.Loginbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.Loginbtn.ImageRotate = 0F;
            this.Loginbtn.ImageSize = new System.Drawing.Size(96, 30);
            this.Loginbtn.Location = new System.Drawing.Point(652, 398);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.PressedState.ImageSize = new System.Drawing.Size(96, 30);
            this.Loginbtn.Size = new System.Drawing.Size(107, 56);
            this.Loginbtn.TabIndex = 11;
            this.Loginbtn.Click += new System.EventHandler(this.loginBtn_click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(932, 558);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(571, 58);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(285, 116);
            this.guna2PictureBox3.TabIndex = 23;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 553);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignInScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInScreen";
            this.Load += new System.EventHandler(this.SignInScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxemail;
        private Guna.UI2.WinForms.Guna2TextBox textBoxpassword;
        private Guna.UI2.WinForms.Guna2ImageButton Loginbtn;
        private Guna.UI2.WinForms.Guna2ImageButton closebtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
    }
}
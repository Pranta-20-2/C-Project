﻿
namespace Library_Management_Project
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCusUserName = new System.Windows.Forms.TextBox();
            this.txtCusPass = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCusLogin = new System.Windows.Forms.Button();
            this.btnCusSignup = new System.Windows.Forms.Button();
            this.btnCusClose = new System.Windows.Forms.Button();
            this.btnCusBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtCusUserName
            // 
            this.txtCusUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCusUserName.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusUserName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCusUserName.Location = new System.Drawing.Point(150, 255);
            this.txtCusUserName.Multiline = true;
            this.txtCusUserName.Name = "txtCusUserName";
            this.txtCusUserName.Size = new System.Drawing.Size(176, 36);
            this.txtCusUserName.TabIndex = 1;
            this.txtCusUserName.Text = "Username";
            this.txtCusUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCusUserName_MouseClick);
            // 
            // txtCusPass
            // 
            this.txtCusPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCusPass.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F);
            this.txtCusPass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCusPass.Location = new System.Drawing.Point(150, 323);
            this.txtCusPass.Multiline = true;
            this.txtCusPass.Name = "txtCusPass";
            this.txtCusPass.Size = new System.Drawing.Size(176, 37);
            this.txtCusPass.TabIndex = 2;
            this.txtCusPass.Text = "Password";
            this.txtCusPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCusPass_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(111, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(111, 323);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnCusLogin
            // 
            this.btnCusLogin.BackColor = System.Drawing.Color.LightBlue;
            this.btnCusLogin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusLogin.ForeColor = System.Drawing.Color.Black;
            this.btnCusLogin.Location = new System.Drawing.Point(150, 400);
            this.btnCusLogin.Name = "btnCusLogin";
            this.btnCusLogin.Size = new System.Drawing.Size(126, 42);
            this.btnCusLogin.TabIndex = 5;
            this.btnCusLogin.Text = "Log In";
            this.btnCusLogin.UseVisualStyleBackColor = false;
            this.btnCusLogin.Click += new System.EventHandler(this.btnCusLogin_Click);
            // 
            // btnCusSignup
            // 
            this.btnCusSignup.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnCusSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCusSignup.Location = new System.Drawing.Point(150, 461);
            this.btnCusSignup.Name = "btnCusSignup";
            this.btnCusSignup.Size = new System.Drawing.Size(126, 42);
            this.btnCusSignup.TabIndex = 6;
            this.btnCusSignup.Text = "Sign Up";
            this.btnCusSignup.UseVisualStyleBackColor = true;
            this.btnCusSignup.Click += new System.EventHandler(this.btnCusSignup_Click);
            // 
            // btnCusClose
            // 
            this.btnCusClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCusClose.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusClose.ForeColor = System.Drawing.Color.Black;
            this.btnCusClose.Location = new System.Drawing.Point(387, 13);
            this.btnCusClose.Name = "btnCusClose";
            this.btnCusClose.Size = new System.Drawing.Size(31, 39);
            this.btnCusClose.TabIndex = 7;
            this.btnCusClose.Text = "X";
            this.btnCusClose.UseVisualStyleBackColor = false;
            this.btnCusClose.Click += new System.EventHandler(this.btnCusClose_Click);
            // 
            // btnCusBack
            // 
            this.btnCusBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCusBack.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusBack.ForeColor = System.Drawing.Color.Black;
            this.btnCusBack.Location = new System.Drawing.Point(24, 13);
            this.btnCusBack.Name = "btnCusBack";
            this.btnCusBack.Size = new System.Drawing.Size(88, 39);
            this.btnCusBack.TabIndex = 8;
            this.btnCusBack.Text = "Back";
            this.btnCusBack.UseVisualStyleBackColor = false;
            this.btnCusBack.Click += new System.EventHandler(this.btnCusBack_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(439, 564);
            this.Controls.Add(this.btnCusBack);
            this.Controls.Add(this.btnCusClose);
            this.Controls.Add(this.btnCusSignup);
            this.Controls.Add(this.btnCusLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtCusPass);
            this.Controls.Add(this.txtCusUserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Log In";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCusUserName;
        private System.Windows.Forms.TextBox txtCusPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCusLogin;
        private System.Windows.Forms.Button btnCusSignup;
        private System.Windows.Forms.Button btnCusClose;
        private System.Windows.Forms.Button btnCusBack;
    }
}
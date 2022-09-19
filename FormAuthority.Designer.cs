
namespace Library_Management_Project
{
    partial class FormAuthority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthority));
            this.btnAutBack = new System.Windows.Forms.Button();
            this.btnAutClose = new System.Windows.Forms.Button();
            this.btnAutLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAutPass = new System.Windows.Forms.TextBox();
            this.txtAutUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAutBack
            // 
            this.btnAutBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAutBack.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutBack.ForeColor = System.Drawing.Color.Black;
            this.btnAutBack.Location = new System.Drawing.Point(12, 12);
            this.btnAutBack.Name = "btnAutBack";
            this.btnAutBack.Size = new System.Drawing.Size(88, 39);
            this.btnAutBack.TabIndex = 16;
            this.btnAutBack.Text = "Back";
            this.btnAutBack.UseVisualStyleBackColor = false;
            this.btnAutBack.Click += new System.EventHandler(this.btnAutBack_Click);
            // 
            // btnAutClose
            // 
            this.btnAutClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAutClose.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutClose.ForeColor = System.Drawing.Color.Black;
            this.btnAutClose.Location = new System.Drawing.Point(378, 8);
            this.btnAutClose.Name = "btnAutClose";
            this.btnAutClose.Size = new System.Drawing.Size(31, 39);
            this.btnAutClose.TabIndex = 15;
            this.btnAutClose.Text = "X";
            this.btnAutClose.UseVisualStyleBackColor = false;
            this.btnAutClose.Click += new System.EventHandler(this.btnAutClose_Click);
            // 
            // btnAutLogin
            // 
            this.btnAutLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutLogin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutLogin.ForeColor = System.Drawing.Color.Black;
            this.btnAutLogin.Location = new System.Drawing.Point(139, 400);
            this.btnAutLogin.Name = "btnAutLogin";
            this.btnAutLogin.Size = new System.Drawing.Size(153, 49);
            this.btnAutLogin.TabIndex = 14;
            this.btnAutLogin.Text = "Log In";
            this.btnAutLogin.UseVisualStyleBackColor = false;
            this.btnAutLogin.Click += new System.EventHandler(this.btnAutLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(100, 315);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtAutPass
            // 
            this.txtAutPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtAutPass.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F);
            this.txtAutPass.ForeColor = System.Drawing.Color.Black;
            this.txtAutPass.Location = new System.Drawing.Point(139, 315);
            this.txtAutPass.Multiline = true;
            this.txtAutPass.Name = "txtAutPass";
            this.txtAutPass.Size = new System.Drawing.Size(176, 37);
            this.txtAutPass.TabIndex = 11;
            this.txtAutPass.Text = "Password";
            this.txtAutPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAutPass_MouseClick);
            // 
            // txtAutUserName
            // 
            this.txtAutUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtAutUserName.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutUserName.ForeColor = System.Drawing.Color.Black;
            this.txtAutUserName.Location = new System.Drawing.Point(139, 241);
            this.txtAutUserName.Multiline = true;
            this.txtAutUserName.Name = "txtAutUserName";
            this.txtAutUserName.Size = new System.Drawing.Size(176, 36);
            this.txtAutUserName.TabIndex = 10;
            this.txtAutUserName.Text = "Username";
            this.txtAutUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAutUserName_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(421, 517);
            this.Controls.Add(this.btnAutBack);
            this.Controls.Add(this.btnAutClose);
            this.Controls.Add(this.btnAutLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtAutPass);
            this.Controls.Add(this.txtAutUserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuthority";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authority";
            this.Load += new System.EventHandler(this.FormAuthority_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutBack;
        private System.Windows.Forms.Button btnAutClose;
        private System.Windows.Forms.Button btnAutLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAutPass;
        private System.Windows.Forms.TextBox txtAutUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace Library_Management_Project
{
    partial class FormCusSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCusSignup));
            this.btnCusBack = new System.Windows.Forms.Button();
            this.btnCusClose = new System.Windows.Forms.Button();
            this.pictureBoxCus = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCusSignPass = new System.Windows.Forms.TextBox();
            this.txtCusSignUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCusSignConPass = new System.Windows.Forms.TextBox();
            this.buttonCusSignupSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCusBack
            // 
            this.btnCusBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCusBack.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusBack.ForeColor = System.Drawing.Color.Black;
            this.btnCusBack.Location = new System.Drawing.Point(12, 12);
            this.btnCusBack.Name = "btnCusBack";
            this.btnCusBack.Size = new System.Drawing.Size(88, 39);
            this.btnCusBack.TabIndex = 9;
            this.btnCusBack.Text = "Back";
            this.btnCusBack.UseVisualStyleBackColor = false;
            this.btnCusBack.Click += new System.EventHandler(this.btnCusBack_Click);
            // 
            // btnCusClose
            // 
            this.btnCusClose.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusClose.ForeColor = System.Drawing.Color.Black;
            this.btnCusClose.Location = new System.Drawing.Point(397, 12);
            this.btnCusClose.Name = "btnCusClose";
            this.btnCusClose.Size = new System.Drawing.Size(31, 39);
            this.btnCusClose.TabIndex = 10;
            this.btnCusClose.Text = "X";
            this.btnCusClose.UseVisualStyleBackColor = false;
            this.btnCusClose.Click += new System.EventHandler(this.btnCusClose_Click);
            // 
            // pictureBoxCus
            // 
            this.pictureBoxCus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCus.BackgroundImage")));
            this.pictureBoxCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCus.Location = new System.Drawing.Point(154, 52);
            this.pictureBoxCus.Name = "pictureBoxCus";
            this.pictureBoxCus.Size = new System.Drawing.Size(123, 122);
            this.pictureBoxCus.TabIndex = 11;
            this.pictureBoxCus.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(113, 295);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(113, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // txtCusSignPass
            // 
            this.txtCusSignPass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCusSignPass.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F);
            this.txtCusSignPass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCusSignPass.Location = new System.Drawing.Point(152, 295);
            this.txtCusSignPass.Multiline = true;
            this.txtCusSignPass.Name = "txtCusSignPass";
            this.txtCusSignPass.Size = new System.Drawing.Size(176, 37);
            this.txtCusSignPass.TabIndex = 13;
            this.txtCusSignPass.Text = "Password";
            this.txtCusSignPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCusSignPass_MouseClick);
            this.txtCusSignPass.TextChanged += new System.EventHandler(this.txtCusSignPass_TextChanged);
            // 
            // txtCusSignUserName
            // 
            this.txtCusSignUserName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCusSignUserName.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusSignUserName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCusSignUserName.Location = new System.Drawing.Point(152, 227);
            this.txtCusSignUserName.Multiline = true;
            this.txtCusSignUserName.Name = "txtCusSignUserName";
            this.txtCusSignUserName.Size = new System.Drawing.Size(176, 36);
            this.txtCusSignUserName.TabIndex = 12;
            this.txtCusSignUserName.Text = "Username";
            this.txtCusSignUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCusSignUserName_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtCusSignConPass
            // 
            this.txtCusSignConPass.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCusSignConPass.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F);
            this.txtCusSignConPass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCusSignConPass.Location = new System.Drawing.Point(152, 358);
            this.txtCusSignConPass.Multiline = true;
            this.txtCusSignConPass.Name = "txtCusSignConPass";
            this.txtCusSignConPass.Size = new System.Drawing.Size(176, 37);
            this.txtCusSignConPass.TabIndex = 16;
            this.txtCusSignConPass.Text = "Confirm Password";
            this.txtCusSignConPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCusSignConPass_MouseClick);
            // 
            // buttonCusSignupSave
            // 
            this.buttonCusSignupSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCusSignupSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCusSignupSave.ForeColor = System.Drawing.Color.Black;
            this.buttonCusSignupSave.Location = new System.Drawing.Point(154, 440);
            this.buttonCusSignupSave.Name = "buttonCusSignupSave";
            this.buttonCusSignupSave.Size = new System.Drawing.Size(141, 49);
            this.buttonCusSignupSave.TabIndex = 18;
            this.buttonCusSignupSave.Text = "Save";
            this.buttonCusSignupSave.UseVisualStyleBackColor = false;
            this.buttonCusSignupSave.Click += new System.EventHandler(this.buttonCusSignupSave_Click);
            // 
            // FormCusSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 559);
            this.Controls.Add(this.buttonCusSignupSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCusSignConPass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtCusSignPass);
            this.Controls.Add(this.txtCusSignUserName);
            this.Controls.Add(this.pictureBoxCus);
            this.Controls.Add(this.btnCusClose);
            this.Controls.Add(this.btnCusBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCusSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCusSignup";
            this.Load += new System.EventHandler(this.FormCusSignup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCusBack;
        private System.Windows.Forms.Button btnCusClose;
        private System.Windows.Forms.PictureBox pictureBoxCus;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtCusSignPass;
        private System.Windows.Forms.TextBox txtCusSignUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCusSignConPass;
        private System.Windows.Forms.Button buttonCusSignupSave;
    }
}
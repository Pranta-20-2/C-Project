
namespace Library_Management_Project
{
    partial class FormShowBookDetAut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowBookDetAut));
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView2CusShow = new System.Windows.Forms.DataGridView();
            this.btnAutDbBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2CusShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtStudentID.Location = new System.Drawing.Point(170, 115);
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(164, 23);
            this.txtStudentID.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 53;
            this.label1.Text = "Customer ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(589, 69);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 72);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Delete Info";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(438, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 76);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Show Details";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView2CusShow
            // 
            this.dataGridView2CusShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView2CusShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2CusShow.Location = new System.Drawing.Point(12, 165);
            this.dataGridView2CusShow.Name = "dataGridView2CusShow";
            this.dataGridView2CusShow.RowHeadersWidth = 51;
            this.dataGridView2CusShow.RowTemplate.Height = 24;
            this.dataGridView2CusShow.Size = new System.Drawing.Size(862, 363);
            this.dataGridView2CusShow.TabIndex = 57;
            // 
            // btnAutDbBack
            // 
            this.btnAutDbBack.BackColor = System.Drawing.Color.Coral;
            this.btnAutDbBack.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutDbBack.ForeColor = System.Drawing.Color.Black;
            this.btnAutDbBack.Location = new System.Drawing.Point(26, 23);
            this.btnAutDbBack.Name = "btnAutDbBack";
            this.btnAutDbBack.Size = new System.Drawing.Size(88, 39);
            this.btnAutDbBack.TabIndex = 58;
            this.btnAutDbBack.Text = "Back";
            this.btnAutDbBack.UseVisualStyleBackColor = false;
            this.btnAutDbBack.Click += new System.EventHandler(this.btnAutDbBack_Click);
            // 
            // FormShowBookDetAut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 536);
            this.Controls.Add(this.btnAutDbBack);
            this.Controls.Add(this.dataGridView2CusShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShowBookDetAut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowBookDetAut";
            this.Load += new System.EventHandler(this.FormShowBookDetAut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2CusShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView2CusShow;
        private System.Windows.Forms.Button btnAutDbBack;
    }
}
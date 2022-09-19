
namespace Library_Management_Project
{
    partial class FormShowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowBook));
            this.txtAutName = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookid = new System.Windows.Forms.Label();
            this.dataGridView2CusShow = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl0 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAutDbBack = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2CusShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAutName
            // 
            this.txtAutName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtAutName.Location = new System.Drawing.Point(482, 208);
            this.txtAutName.Multiline = true;
            this.txtAutName.Name = "txtAutName";
            this.txtAutName.Size = new System.Drawing.Size(164, 26);
            this.txtAutName.TabIndex = 38;
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtBookName.Location = new System.Drawing.Point(482, 172);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(164, 23);
            this.txtBookName.TabIndex = 37;
            // 
            // txtBookId
            // 
            this.txtBookId.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtBookId.Location = new System.Drawing.Point(482, 41);
            this.txtBookId.Multiline = true;
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(164, 26);
            this.txtBookId.TabIndex = 36;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblQuantity.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(350, 252);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(98, 26);
            this.lblQuantity.TabIndex = 35;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblAuthorName.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(308, 208);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(140, 26);
            this.lblAuthorName.TabIndex = 33;
            this.lblAuthorName.Text = "Author Name:";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblBookName.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(325, 169);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(123, 26);
            this.lblBookName.TabIndex = 32;
            this.lblBookName.Text = "Book Name:";
            // 
            // lblBookid
            // 
            this.lblBookid.AutoSize = true;
            this.lblBookid.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblBookid.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookid.Location = new System.Drawing.Point(343, 41);
            this.lblBookid.Name = "lblBookid";
            this.lblBookid.Size = new System.Drawing.Size(105, 26);
            this.lblBookid.TabIndex = 31;
            this.lblBookid.Text = "BOOK ID:";
            // 
            // dataGridView2CusShow
            // 
            this.dataGridView2CusShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView2CusShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2CusShow.Location = new System.Drawing.Point(12, 327);
            this.dataGridView2CusShow.Name = "dataGridView2CusShow";
            this.dataGridView2CusShow.RowHeadersWidth = 51;
            this.dataGridView2CusShow.RowTemplate.Height = 24;
            this.dataGridView2CusShow.Size = new System.Drawing.Size(888, 297);
            this.dataGridView2CusShow.TabIndex = 41;
            this.dataGridView2CusShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2CusShow_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 44);
            this.button1.TabIndex = 42;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbl0.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.Location = new System.Drawing.Point(540, 257);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(22, 26);
            this.lbl0.TabIndex = 43;
            this.lbl0.Text = "0";
            this.lbl0.Click += new System.EventHandler(this.lbl0_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(716, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 49);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAutDbBack
            // 
            this.btnAutDbBack.BackColor = System.Drawing.Color.Coral;
            this.btnAutDbBack.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutDbBack.ForeColor = System.Drawing.Color.Black;
            this.btnAutDbBack.Location = new System.Drawing.Point(12, 12);
            this.btnAutDbBack.Name = "btnAutDbBack";
            this.btnAutDbBack.Size = new System.Drawing.Size(88, 39);
            this.btnAutDbBack.TabIndex = 47;
            this.btnAutDbBack.Text = "Back";
            this.btnAutDbBack.UseVisualStyleBackColor = false;
            this.btnAutDbBack.Click += new System.EventHandler(this.btnAutDbBack_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtStudentID.Location = new System.Drawing.Point(482, 89);
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(164, 23);
            this.txtStudentID.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 51;
            this.label1.Text = "Customer ID:";
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtMobile.Location = new System.Drawing.Point(482, 132);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(164, 23);
            this.txtMobile.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mobile:";
            // 
            // FormShowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 507);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutDbBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2CusShow);
            this.Controls.Add(this.txtAutName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblBookid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormShowBook";
            this.Load += new System.EventHandler(this.FormShowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2CusShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAutName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookid;
        private System.Windows.Forms.DataGridView dataGridView2CusShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAutDbBack;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label2;
    }
}
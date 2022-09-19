
namespace Library_Management_Project
{
    partial class FormAuthorityDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorityDashBoard));
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookid = new System.Windows.Forms.Label();
            this.btnInsertBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnShowBook = new System.Windows.Forms.Button();
            this.dataGridViewShowBook = new System.Windows.Forms.DataGridView();
            this.btnAutDbBack = new System.Windows.Forms.Button();
            this.btnCustDet = new System.Windows.Forms.Button();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txtAutName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBook)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtQuantity.Location = new System.Drawing.Point(248, 214);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(164, 31);
            this.txtQuantity.TabIndex = 30;
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtBookName.Location = new System.Drawing.Point(248, 127);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(164, 23);
            this.txtBookName.TabIndex = 27;
            // 
            // txtBookId
            // 
            this.txtBookId.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtBookId.Location = new System.Drawing.Point(248, 75);
            this.txtBookId.Multiline = true;
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(164, 26);
            this.txtBookId.TabIndex = 26;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblQuantity.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(95, 219);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(98, 26);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblBookName.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(70, 124);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(123, 26);
            this.lblBookName.TabIndex = 22;
            this.lblBookName.Text = "Book Name:";
            // 
            // lblBookid
            // 
            this.lblBookid.AutoSize = true;
            this.lblBookid.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblBookid.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookid.Location = new System.Drawing.Point(88, 75);
            this.lblBookid.Name = "lblBookid";
            this.lblBookid.Size = new System.Drawing.Size(105, 26);
            this.lblBookid.TabIndex = 21;
            this.lblBookid.Text = "BOOK ID:";
            // 
            // btnInsertBook
            // 
            this.btnInsertBook.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnInsertBook.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertBook.Location = new System.Drawing.Point(464, 2);
            this.btnInsertBook.Name = "btnInsertBook";
            this.btnInsertBook.Size = new System.Drawing.Size(132, 78);
            this.btnInsertBook.TabIndex = 31;
            this.btnInsertBook.Text = "Insert Book";
            this.btnInsertBook.UseVisualStyleBackColor = false;
            this.btnInsertBook.Click += new System.EventHandler(this.btnInsertBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdateBook.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.Location = new System.Drawing.Point(650, 56);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(131, 78);
            this.btnUpdateBook.TabIndex = 32;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDeleteBook.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(488, 161);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(137, 84);
            this.btnDeleteBook.TabIndex = 33;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnShowBook
            // 
            this.btnShowBook.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnShowBook.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBook.Location = new System.Drawing.Point(665, 186);
            this.btnShowBook.Name = "btnShowBook";
            this.btnShowBook.Size = new System.Drawing.Size(131, 87);
            this.btnShowBook.TabIndex = 34;
            this.btnShowBook.Text = "Show All Book";
            this.btnShowBook.UseVisualStyleBackColor = false;
            this.btnShowBook.Click += new System.EventHandler(this.btnShowBook_Click);
            // 
            // dataGridViewShowBook
            // 
            this.dataGridViewShowBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewShowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowBook.Location = new System.Drawing.Point(25, 308);
            this.dataGridViewShowBook.Name = "dataGridViewShowBook";
            this.dataGridViewShowBook.RowHeadersWidth = 51;
            this.dataGridViewShowBook.RowTemplate.Height = 24;
            this.dataGridViewShowBook.Size = new System.Drawing.Size(950, 264);
            this.dataGridViewShowBook.TabIndex = 35;
            // 
            // btnAutDbBack
            // 
            this.btnAutDbBack.BackColor = System.Drawing.Color.Coral;
            this.btnAutDbBack.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutDbBack.ForeColor = System.Drawing.Color.Black;
            this.btnAutDbBack.Location = new System.Drawing.Point(12, 12);
            this.btnAutDbBack.Name = "btnAutDbBack";
            this.btnAutDbBack.Size = new System.Drawing.Size(88, 39);
            this.btnAutDbBack.TabIndex = 36;
            this.btnAutDbBack.Text = "Back";
            this.btnAutDbBack.UseVisualStyleBackColor = false;
            this.btnAutDbBack.Click += new System.EventHandler(this.btnAutDbBack_Click);
            // 
            // btnCustDet
            // 
            this.btnCustDet.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCustDet.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustDet.Location = new System.Drawing.Point(832, 12);
            this.btnCustDet.Name = "btnCustDet";
            this.btnCustDet.Size = new System.Drawing.Size(143, 87);
            this.btnCustDet.TabIndex = 37;
            this.btnCustDet.Text = "Customer details";
            this.btnCustDet.UseVisualStyleBackColor = false;
            this.btnCustDet.Click += new System.EventHandler(this.btnCustDet_Click);
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lblAuthorName.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(59, 174);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(140, 26);
            this.lblAuthorName.TabIndex = 23;
            this.lblAuthorName.Text = "Author Name:";
            // 
            // txtAutName
            // 
            this.txtAutName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtAutName.Location = new System.Drawing.Point(248, 174);
            this.txtAutName.Multiline = true;
            this.txtAutName.Name = "txtAutName";
            this.txtAutName.Size = new System.Drawing.Size(164, 26);
            this.txtAutName.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(832, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 147);
            this.button1.TabIndex = 38;
            this.button1.Text = "Show Customer Book details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAuthorityDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCustDet);
            this.Controls.Add(this.btnAutDbBack);
            this.Controls.Add(this.dataGridViewShowBook);
            this.Controls.Add(this.btnShowBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnInsertBook);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtAutName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblBookid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuthorityDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAuthorityDashBoard";
            this.Load += new System.EventHandler(this.FormAuthorityDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookid;
        private System.Windows.Forms.Button btnInsertBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnShowBook;
        private System.Windows.Forms.DataGridView dataGridViewShowBook;
        private System.Windows.Forms.Button btnAutDbBack;
        private System.Windows.Forms.Button btnCustDet;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox txtAutName;
        private System.Windows.Forms.Button button1;
    }
}
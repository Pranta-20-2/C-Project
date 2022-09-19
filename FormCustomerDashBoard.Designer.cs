
namespace Library_Management_Project
{
    partial class FormCustomerDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomerDashBoard));
            this.button1 = new System.Windows.Forms.Button();
            this.btnCusAmountBook = new System.Windows.Forms.Button();
            this.btnCusSelectBook = new System.Windows.Forms.Button();
            this.btnShowBookDet = new System.Windows.Forms.Button();
            this.dataGridView2CusShow = new System.Windows.Forms.DataGridView();
            this.btnAutDbBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2CusShow)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-19, -19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCusAmountBook
            // 
            this.btnCusAmountBook.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCusAmountBook.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCusAmountBook.Location = new System.Drawing.Point(549, 42);
            this.btnCusAmountBook.Name = "btnCusAmountBook";
            this.btnCusAmountBook.Size = new System.Drawing.Size(106, 123);
            this.btnCusAmountBook.TabIndex = 2;
            this.btnCusAmountBook.Text = "Select Book Histroy";
            this.btnCusAmountBook.UseVisualStyleBackColor = false;
            this.btnCusAmountBook.Click += new System.EventHandler(this.btnCusAmountBook_Click);
            // 
            // btnCusSelectBook
            // 
            this.btnCusSelectBook.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCusSelectBook.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCusSelectBook.Location = new System.Drawing.Point(396, 42);
            this.btnCusSelectBook.Name = "btnCusSelectBook";
            this.btnCusSelectBook.Size = new System.Drawing.Size(106, 123);
            this.btnCusSelectBook.TabIndex = 3;
            this.btnCusSelectBook.Text = "Select Book";
            this.btnCusSelectBook.UseVisualStyleBackColor = false;
            this.btnCusSelectBook.Click += new System.EventHandler(this.btnCusSelectBook_Click);
            // 
            // btnShowBookDet
            // 
            this.btnShowBookDet.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnShowBookDet.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnShowBookDet.Location = new System.Drawing.Point(242, 42);
            this.btnShowBookDet.Name = "btnShowBookDet";
            this.btnShowBookDet.Size = new System.Drawing.Size(106, 123);
            this.btnShowBookDet.TabIndex = 4;
            this.btnShowBookDet.Text = "Show Book Details";
            this.btnShowBookDet.UseVisualStyleBackColor = false;
            this.btnShowBookDet.Click += new System.EventHandler(this.btnShowBookDet_Click_1);
            // 
            // dataGridView2CusShow
            // 
            this.dataGridView2CusShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView2CusShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2CusShow.Location = new System.Drawing.Point(35, 202);
            this.dataGridView2CusShow.Name = "dataGridView2CusShow";
            this.dataGridView2CusShow.RowHeadersWidth = 51;
            this.dataGridView2CusShow.RowTemplate.Height = 24;
            this.dataGridView2CusShow.Size = new System.Drawing.Size(945, 364);
            this.dataGridView2CusShow.TabIndex = 5;
            // 
            // btnAutDbBack
            // 
            this.btnAutDbBack.BackColor = System.Drawing.Color.Coral;
            this.btnAutDbBack.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutDbBack.ForeColor = System.Drawing.Color.Black;
            this.btnAutDbBack.Location = new System.Drawing.Point(12, 12);
            this.btnAutDbBack.Name = "btnAutDbBack";
            this.btnAutDbBack.Size = new System.Drawing.Size(104, 72);
            this.btnAutDbBack.TabIndex = 48;
            this.btnAutDbBack.Text = "Log Out";
            this.btnAutDbBack.UseVisualStyleBackColor = false;
            this.btnAutDbBack.Click += new System.EventHandler(this.btnAutDbBack_Click);
            // 
            // FormCustomerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 575);
            this.Controls.Add(this.btnAutDbBack);
            this.Controls.Add(this.dataGridView2CusShow);
            this.Controls.Add(this.btnShowBookDet);
            this.Controls.Add(this.btnCusSelectBook);
            this.Controls.Add(this.btnCusAmountBook);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomerDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashBoard";
            this.Load += new System.EventHandler(this.FormCustomerDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2CusShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCusAmountBook;
        private System.Windows.Forms.Button btnCusSelectBook;
        private System.Windows.Forms.Button btnShowBookDet;
        private System.Windows.Forms.DataGridView dataGridView2CusShow;
        private System.Windows.Forms.Button btnAutDbBack;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Library_Management_Project
{
    public partial class FormShowBook : Form
    {
        

        int counter;

        public FormShowBook()
        {
            InitializeComponent();
        }

        
        private void FormShowBook_Load(object sender, EventArgs e)
        {
           
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=Book_Details;Integrated Security=True");
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("Insert into ShowBook_Info (Book_Id,Customer_Id,Mobile, Book_Name, Author_Name, Quantity) values('" + txtBookId.Text + "', '" + txtStudentID.Text + "', '" + txtMobile.Text + "', '" + txtBookName.Text + "','" + txtAutName.Text + "','" + lbl0.Text + "')", sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from Book_Details", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView2CusShow.DataSource = dataTable;
                sqlConnection.Close();
            
        }
       
        private DataTable ShowBook()
        {
            DataTable Dt = new DataTable();

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=Book_Details;Integrated Security=True");

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from Book_Details", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2CusShow.DataSource = dataTable;
            return dataTable;
        }
        private void dataGridView2CusShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
            int value = e.RowIndex;
            DataTable dataTable = ShowBook();
            DataRow Dr = dataTable.Rows[value];
            txtBookId.Text = dataTable.Rows[value]["Book_Id"].ToString();
            txtBookName.Text= dataTable.Rows[value]["Book_Name"].ToString();
            txtAutName.Text= dataTable.Rows[value]["Author_Name"].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            lbl0.Text = counter.ToString();
            

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            Person p = new Person(txtBookId.Text, txtStudentID.Text, txtMobile.Text, txtBookName.Text, txtAutName.Text, lbl0.Text);
            p.Book_Id = txtBookId.Text;
            p.Customer_Id = txtStudentID.Text;
            p.Mobile = txtMobile.Text;
            p.Quantity = lbl0.Text;
            
            Regex r = new Regex(@"^[0-9]{11}$");
            
            if (string.IsNullOrEmpty(p.Book_Id))
            {
                MessageBox.Show("Provide valide Book ID ");
            }

            else if ( string.IsNullOrEmpty(p.Customer_Id))
            {
                MessageBox.Show("Provide (XX-XXXXX-X) Customer ID ");
            }
            else if (string.IsNullOrEmpty(p.Quantity))
            {
                MessageBox.Show("Select Book Quantity ");
            }
            else if (string.IsNullOrEmpty(p.Mobile))
            {
                MessageBox.Show("Provide Valid Mobile Number ");
            }
            
            
            else if(r.IsMatch(p.Mobile))
            {
                SqlConnection sqlConnection1 = new SqlConnection("Data Source=DESKTOP-NFN5O6D\\SQLEXPRESS;Initial Catalog=ShowBook_Info;Integrated Security=True");
                sqlConnection1.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert into ShowBook_Info (Book_Id,Customer_Id,Mobile,Book_Name, Author_Name,Quantity) values('" + txtBookId.Text + "', '" + txtStudentID.Text + "', '" + txtMobile.Text + "', '" + txtBookName.Text + "','" + txtAutName.Text + "','" + lbl0.Text + "')", sqlConnection1);

                int check = sqlCommand.ExecuteNonQuery();

                if (check > 0)
                {
                    MessageBox.Show(" Book Selected successfully ");
                }
                sqlConnection1.Close();


            }

            else

            {
                MessageBox.Show(" Provide 11 Digit Mobile Number ");
            }
           
            

        }

        private void btnAutDbBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCustomerDashBoard back = new FormCustomerDashBoard();
            back.Show();
        }

        private void lbl0_Click(object sender, EventArgs e)
        {
            
        }
    }
}

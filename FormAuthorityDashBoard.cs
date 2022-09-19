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

namespace Library_Management_Project
{
    public partial class FormAuthorityDashBoard : Form
    {

    public FormAuthorityDashBoard()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=Book_Details;Integrated Security=True");

        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=CusLogin;Integrated Security=True");
        private void FormAuthorityDashBoard_Load(object sender, EventArgs e)
        {


        }

        
        private void btnInsertBook_Click(object sender, EventArgs e)
        {
            Person p = new Person(txtBookId.Text, txtBookName.Text, txtAutName.Text, txtQuantity.Text);
            p.Book_Id = txtBookId.Text;
            p.Book_Name = txtBookName.Text;
            p.Author_Name = txtAutName.Text;
            p.Quantity = txtQuantity.Text;

            if (string.IsNullOrEmpty(p.Book_Id) )
            {
                MessageBox.Show("Provide valide Book ID ");
            }
            else if(string.IsNullOrEmpty(p.Book_Name))
            {
                MessageBox.Show("Provide valide Book Name ");
            }
            else if (string.IsNullOrEmpty(p.Author_Name))
            {
                MessageBox.Show("Provide Author Name ");
            }
            else if (string.IsNullOrEmpty(p.Quantity))
            {
                MessageBox.Show("Select Quantity ");
            }

            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert into Book_Details (Book_ID, Book_Name, Author_Name, Quantity) values('" + txtBookId.Text + "','" + txtBookName.Text + "','" + txtAutName.Text + "','" + txtQuantity.Text + "')", sqlConnection);
                int check = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (check > 0)
                {
                    MessageBox.Show("Inserted successfully");
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            Person p = new Person(txtBookId.Text, txtBookName.Text, txtAutName.Text, txtQuantity.Text);
            p.Book_Id = txtBookId.Text;
            p.Book_Name = txtBookName.Text;
            p.Author_Name = txtAutName.Text;
            p.Quantity = txtQuantity.Text;

            if (string.IsNullOrEmpty(p.Book_Id) )
            {
                MessageBox.Show("Provide valide Book ID ");
            }
            else if(string.IsNullOrEmpty(p.Book_Name))
            {
                MessageBox.Show("Provide valide Book Name ");
            }
            else if (string.IsNullOrEmpty(p.Author_Name))
            {
                MessageBox.Show("Provide Author Name ");
            }
            else if (string.IsNullOrEmpty(p.Quantity))
            {
                MessageBox.Show("Select Quantity ");
            }

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Book_Details set Book_Name ='" + txtBookName.Text + "' where Book_ID='" + txtBookId.Text + "'", sqlConnection);
            SqlCommand sqlCommand1 = new SqlCommand("Update Book_Details set Author_Name ='" + txtAutName.Text + "' where Book_ID='" + txtBookId.Text + "'", sqlConnection);
            SqlCommand sqlCommand3 = new SqlCommand("Update Book_Details set Quantity ='" + txtQuantity.Text + "' where Book_ID='" + txtBookId.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            int check1 = sqlCommand1.ExecuteNonQuery();
            int check2 = sqlCommand3.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0 && check1 > 0 &&  check2>0)
            {
                MessageBox.Show("updated successfully");
            }

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Book_Details where Book_ID= '" + txtBookId.Text + "'", sqlConnection);
            int check = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (check > 0)
            {
                MessageBox.Show("Deleted successfully");
            }
        }

        private void btnShowBook_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from Book_Details", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewShowBook.DataSource = dataTable;
            sqlConnection.Close();
        }

     

        private void btnAutDbBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn back = new FormLogIn();
            back.Show();
        }

        private void btnCustDet_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from CusLogin", sqlConn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewShowBook.DataSource = dataTable;
            sqlConn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormShowBookDetAut SB = new FormShowBookDetAut();
            SB.Show();
        }
    }
}

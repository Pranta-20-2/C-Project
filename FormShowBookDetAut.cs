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
    public partial class FormShowBookDetAut : Form
    {
        public FormShowBookDetAut()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=ShowBook_Info;Integrated Security=True");

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from ShowBook_Info", sqlConnection1);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2CusShow.DataSource = dataTable;
            sqlConnection1.Close();

        }

        private void FormShowBookDetAut_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=ShowBook_Info;Integrated Security=True");
            sqlConnection1.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from ShowBook_Info where Customer_Id= '" + txtStudentID.Text + "'", sqlConnection1);
            int check = sqlCommand.ExecuteNonQuery();

            if (check > 0)
            {
                MessageBox.Show("Book Deleted successfully");
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from ShowBook_Info", sqlConnection1);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2CusShow.DataSource = dataTable;
            sqlConnection1.Close();
        }

        private void btnAutDbBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAuthorityDashBoard back = new FormAuthorityDashBoard();
            back.Show();
        }
    }
}

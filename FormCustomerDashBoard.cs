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
    public partial class FormCustomerDashBoard : Form
    {
        public FormCustomerDashBoard()
        {
            InitializeComponent();
        }

        private void FormCustomerDashBoard_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=Book_Details;Integrated Security=True");

        private void btnShowBookDet_Click_1(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from Book_Details", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2CusShow.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btnCusSelectBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormShowBook SB = new FormShowBook();
            SB.Show();
        }
        SqlConnection sqlConnection1 = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=ShowBook_Info;Integrated Security=True");
        private void btnCusAmountBook_Click(object sender, EventArgs e)
        {
            
            sqlConnection1.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select* from ShowBook_Info", sqlConnection1);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2CusShow.DataSource = dataTable;
            sqlConnection1.Close();
            

        }

        private void btnAutDbBack_Click(object sender, EventArgs e)
        {
            AbstractInherit Ai = new AbstractInherit();
            Ai.ThankYou();
            this.Close();
            FormLogIn back = new FormLogIn();
            back.Show();
        }
    }
}

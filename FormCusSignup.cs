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
    public partial class FormCusSignup : Form
    {
        public FormCusSignup()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=CusLogin;Integrated Security=True");
        private void FormCusSignup_Load(object sender, EventArgs e)
        {

        }

        private void txtCusSignUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCusSignUserName.Text == "Username")
            {
                txtCusSignUserName.Clear();
            }
        }

        private void txtCusSignPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCusSignPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCusSignPass.Text == "Password")
            {
                txtCusSignPass.Clear();
            }

        }

        private void txtCusSignConPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCusSignConPass.Text == "Confirm Password")
            {
                txtCusSignConPass.Clear();
            }

        }

        private void btnCusBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form back = new FormCustomer();
            back.Show();
        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCusSignupSave_Click(object sender, EventArgs e)
        {
            if(txtCusSignPass.Text==txtCusSignConPass.Text)
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert into CusLogin (Username,Password) values('" + txtCusSignUserName.Text + "','" + txtCusSignPass.Text + "')", sqlConnection);
                int check = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (check > 0)
                {
                    MessageBox.Show("Successfully Done");
                }

            }
            else
            {
                MessageBox.Show("....... Password Not Match .....\n ...... Try Again ......");
            }
            
        }
    }
}

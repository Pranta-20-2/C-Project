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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btnCusClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnCusBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn back = new FormLogIn();
            back.Show();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=CusLogin;Integrated Security=True");
        private void btnCusLogin_Click(object sender, EventArgs e)
        {
            AbstractInherit Ai = new AbstractInherit();
            Ai.Welcome();
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "select * from CusLogin where Username = '" + txtCusUserName.Text + "' and Password ='" + txtCusPass.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                FormCustomerDashBoard CD = new FormCustomerDashBoard();
                CD.Show();
            }

            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void txtCusUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCusUserName.Text == "Username")
            {
                txtCusUserName.Clear();
            }
        }

        private void txtCusPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCusPass.Text == "Password")
            {
                txtCusPass.Clear();
                txtCusPass.PasswordChar = '*';
            }

        }

        private void btnCusSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCusSignup CS = new FormCusSignup();
            CS.Show();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}

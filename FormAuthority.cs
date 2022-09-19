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
    public partial class FormAuthority : Form
    {
        public FormAuthority()
        {
            InitializeComponent();
        }

        private void btnAutClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnAutBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn back = new FormLogIn();
            back.Show();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-NFN5O6D\SQLEXPRESS;Initial Catalog=Author_Login;Integrated Security=True");
        private void btnAutLogin_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "select * from Author_Login where Username = '" +txtAutUserName.Text + "' and Password ='" + txtAutPass.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                FormAuthorityDashBoard AD = new FormAuthorityDashBoard();
                AD.Show();
            }

            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void txtAutUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAutUserName.Text == "Username")
            {
                txtAutUserName.Clear();
            }
        }

        private void txtAutPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAutPass.Text == "Password")
            {
                txtAutPass.Clear();
                txtAutPass.PasswordChar = '*';
            }
        }

        private void FormAuthority_Load(object sender, EventArgs e)
        {

        }
    }
}

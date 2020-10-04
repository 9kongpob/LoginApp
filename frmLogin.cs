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

namespace LoginApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            connectionString = @"Data Source=DESKTOP-2IN1SGU\SQLEXPRESS;Integrated Security=True;Connect Timeout=600;
                                Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            string query = "Select * form tbl_Login where username = '" +txtUsername.Text.Trim()+"' and password = '" +txtPassword.Text.Trim()+"'";
            /*SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                frmMain objFrmMain = new frmMain();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connnectDataBase();
        }

        void connnectDataBase()
        {
            string connectionString = null;
            SqlConnection cnn;
            connectionString = @"Data Source=DESKTOP-2IN1S2GU\SQLEXPRESS;Integrated Security=True;Connect Timeout=600;
                                Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connected to Database Success.");
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can not Connect Database.");
            }
        }
    }
}

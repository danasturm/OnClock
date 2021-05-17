using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnClock
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private static SqlConnection ConnectToDb()
        {
            string connectionString = @"Data Source=.;Initial Catalog=Pontare;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        private static void CloseConnection(SqlConnection conn, SqlCommand command)
        {
            command.Dispose();
            conn.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginForm();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginForm();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void LoginForm()
        {
            DataTable result = Login(textBox1.Text, textBox2.Text);
            if (result.Rows.Count == 1)
            {
                this.Hide();
                string role = result.Rows[0]["Role"].ToString();

                switch (role)
                {
                    case "User":
                        MainForm mf = new MainForm();
                        mf.Show();
                        break;
                    case "Admin":
                        AdminForm af = new AdminForm();
                        af.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD");
            }
        }

        public DataTable Login(String Username, String Password)
        {
            SqlConnection conn = ConnectToDb();
            SqlCommand cmd = new SqlCommand("Select * from LogIn where Username=@Username and Password=@Password", conn);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            return dt;
        }
    }
}

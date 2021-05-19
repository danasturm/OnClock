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
    public partial class AdminForm : Form
    {
        
        public AdminForm()
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

        private void btn_logoutadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }

        private void txt_country_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectToDb();
            string sqlQuery = "select Country from LocationFactory";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            SqlDataReader DR1 = sqlCommand.ExecuteReader();
            if (DR1.Read())
            {
                txt_country.Text = DR1.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void lbl_location_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectToDb();
            string sqlQuery = "select LocationFactory from LocationFactory";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            SqlDataReader DR1 = sqlCommand.ExecuteReader();
            if (DR1.Read())
            {
                txt_location.Text = DR1.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectToDb();
            string sqlQuery = "select IdLocation, Gate from LocationFactory";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dgw_gate.DataSource = dt;
            conn.Close();
        }

        private void btn_submitadmin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectToDb();

            string sql = "insert into AdminSetLocation(IdLocation) values (@IdLocation)";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlParameter idLocation = command.Parameters.Add("@IdLocation", SqlDbType.Int);
            int index = dgw_gate.SelectedCells[0].RowIndex;
            idLocation.Value = dgw_gate.Rows[index].Cells[0].Value;
           

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Gate changed successfully");
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();

            CloseConnection(conn, command);
        }
    }
}

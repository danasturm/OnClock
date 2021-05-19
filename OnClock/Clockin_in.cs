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
    public partial class Clockin_in : Form
    {
        public Clockin_in()
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

        private void btn_backtoselect_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void Clockin_in_Load(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectToDb();
            string sqlQuery = "select * from Employee";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txt_employeeid_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectToDb();
            string sqlQuery = "select * from Employee where IdMember='" + txt_employeeid.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection(conn, sqlCommand);
        }

        private void txt_employeename_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectToDb();
            string sqlQuery = "select * from Employee where LastName='" + txt_employeename.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection(conn, sqlCommand);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectToDb();
            
            string sql = "insert into OnClock(IdMember, IdLocation, ClockIn) values (@IdMember, @IdLocation, @ClockIn)";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlParameter idMember = command.Parameters.Add("@IdMember", SqlDbType.Int);
            SqlParameter idLocation = command.Parameters.Add("@IdLocation", SqlDbType.Int);
            SqlParameter clockIn = command.Parameters.Add("@ClockIn", SqlDbType.DateTime);
            int index = dataGridView1.SelectedCells[0].RowIndex;
            idMember.Value = dataGridView1.Rows[index].Cells[0].Value;
            clockIn.Value = DateTime.Now;

            string sqlQuery = "select IdLocation from AdminSetLocation";
            SqlCommand command2 = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command2);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            DataRow dataRow = dt.Rows[dt.Rows.Count - 1]; 
            idLocation.Value = Convert.ToInt32(dataRow["IdLocation"]);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show($"Welcome, {dataGridView1.Rows[index].Cells[1].Value} {dataGridView1.Rows[index].Cells[2].Value}");
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();

            CloseConnection(conn, command);
        }

    
    }
}

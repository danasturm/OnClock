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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_clockin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clockin_in clocking = new Clockin_in();
            clocking.Show();
        }

        private void btn_clockout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clockin_out clocking = new Clockin_out();
            clocking.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.Show();
        }
    }
}

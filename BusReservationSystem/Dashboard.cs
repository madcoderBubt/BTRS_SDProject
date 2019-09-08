using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusReservationSystem
{
    public partial class Dashboard : Form
    {
        UserLog _userLog;
        public Dashboard(UserLog userLog)
        {
            InitializeComponent();
            _userLog = userLog;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Open About us dialog
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }

        //open login window while closing dashboard
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _userLog.Show();
        }
    }
}

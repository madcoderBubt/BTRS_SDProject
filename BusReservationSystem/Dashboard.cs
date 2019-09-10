using BusReservationSystem.Classes;
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
            aboutUsToolStripMenuItem.PerformClick();
        }

        //open login window while closing dashboard
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _userLog.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            dataGridView1.DataSource = bus.GetBuses();
            lblCurrentUser.Text = LogInfo.user_name +
                " ( " + LogInfo.user_counter+ " )";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInfo.user_name = null;
            LogInfo.user_id = -1;
            LogInfo.user_role = -1;
            LogInfo.user_counter = null;
            this.Close();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/madcoder-bubt/");
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm currentUser = new UserForm();
            currentUser.ShowDialog(this);
        }
    }
}

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
            _userLog = userLog; // for avoiding unexpected system running.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PessengerListForm pessengerList = new PessengerListForm();
            pessengerList.ShowDialog(this);
        }

        //Open About us dialog
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            aboutUsToolStripMenuItem.PerformClick();
        }

        //open login window while closing dashboard
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogInfo.CleanSession();
            _userLog.Show();
        }

        //Set default content while loading
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            dataGridView1.DataSource = bus.GetBuses();
            lblCurrentUser.Text = LogInfo.user_name +
                " ( " + LogInfo.user_counter+ " )";
            if (LogInfo.user_role != 1)
                adminToolStripMenuItem.Enabled = false;
            else
                adminToolStripMenuItem.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LogInfo.CleanSession();
            this.Close();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens HyperLink on default browser.
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/madcoder-bubt/");
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm currentUser = new UserForm();
            currentUser.ShowDialog(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //searching here
        }
    }
}

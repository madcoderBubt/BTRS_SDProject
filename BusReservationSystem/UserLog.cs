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
    public partial class UserLog : Form
    {
        Point _mousePoint;
        public UserLog()
        {
            InitializeComponent();
            this.Width = 317;
            this.Height = 271;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LinkRegister_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.Width == 317)
            {
                this.Width = 667;
                foreach (Control c in grpRegister.Controls)
                {
                    c.TabStop = true;
                }
            }
            else
            {
                this.Width = 317;
                foreach (Control c in grpRegister.Controls)
                {
                    c.TabStop = false;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mousePoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mousePoint.X;
                int dy = e.Location.Y - _mousePoint.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(this);
            dashboard.Show();
            this.Hide();
        }
    }
}

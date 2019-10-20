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
    public partial class UserLog : Form
    {
        Point _mousePoint;
        public UserLog()
        {
            InitializeComponent();
            //Initial size of window
            this.Width = 313;
            this.Height = 271;
            foreach (Control c in grpRegister.Controls)
            {
                c.TabStop = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //Minimize Window
            this.WindowState = FormWindowState.Minimized;
        }

        //Open Register Section
        //Window size control
        private void LinkRegister_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.Width == 313)
            {
                //this.Width = 667;
                timer2.Start();
                foreach (Control c in grpRegister.Controls)
                {
                    c.TabStop = true;
                }
            }
            else
            {
                //this.Width = 313;
                timer1.Start();
                foreach (Control c in grpRegister.Controls)
                {
                    c.TabStop = false;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Move window using mouse
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //get mouse click location
            _mousePoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //move window with mouse
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mousePoint.X;
                int dy = e.Location.Y - _mousePoint.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        //Open About us dialog
        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog(this);
        }

        //LogIn Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            bool b = a.Login(txtLog_Phone.Text, txtLog_Passsword.Text);
            if (b)
            {
                Dashboard dashboard = new Dashboard(this);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Full_name = txtRegister_Name.Text;
            a.Password = txtRegister_Password.Text;
            a.Phone_no = txtRegister_Phone.Text;
            a.Role = Int32.Parse(cmbRegister_Role.SelectedValue.ToString());
            a.Counter = cmbRegister_Counter.SelectedValue.ToString();

            if (a.Register())
            {
                MessageBox.Show("Registered Successful!");
            }
            else
            {
                MessageBox.Show("Registered Unsucced!");
            }
        }

        private void UserLog_Load(object sender, EventArgs e)
        {
            Account account = new Account();
            DataTable roles = account.GetRoles();
            cmbRegister_Role.DataSource = roles;
            cmbRegister_Role.DisplayMember = "name";
            cmbRegister_Role.ValueMember = "id";

            DataTable counters = account.GetConters();
            cmbRegister_Counter.DataSource = counters;
            cmbRegister_Counter.DisplayMember = "name";
            cmbRegister_Counter.ValueMember = "name";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width > 313)
            {
                this.Width -= 2;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Width < 653)
            {
                this.Width += 2;
            }
            else
            {
                timer2.Stop();
            }
        }
    }
}

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

        private void BtnPassenger_Click(object sender, EventArgs e)
        {
            //Pessanger List Button Click
            PessengerListForm pessengerList = new PessengerListForm(dataGridView1.CurrentRow.Cells["no"].Value.ToString());
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
            //Initialize DataGridView
            RefreshGrid();
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn()
            {
                Name = "btnDel",
                HeaderText = "Del Button",
                Text = "Delete",
                UseColumnTextForButtonValue = true,

            };
            dataGridView1.Columns.Add(buttonColumn);
            //Initialize Bus Type in search combo box
            cmbBusType.DataSource = bus.GetBusType();
            cmbBusType.ValueMember = "id";
            cmbBusType.DisplayMember = "type";
            cmbBusType.Text = "Bus Type";
            //Log status
            lblCurrentUser.Text = LogInfo.user_name +
                " ( " + LogInfo.user_counter+ " )";
            if (LogInfo.user_role != 1)
                adminToolStripMenuItem.Enabled = false;
            else
                adminToolStripMenuItem.Enabled = true;
        }

        //Exit Application
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
            //Menu: Help > About Us
            About about = new About();
            about.ShowDialog(this);
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menu: Help > Contact Us
            //Opens HyperLink on default browser.
            System.Diagnostics.Process.Start("https://madcoderbubt.github.io/MadCoderPersonal");
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menu: Log > User Info
            UserForm currentUser = new UserForm();
            currentUser.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Search: search Button
            Bus bus = new Bus();
            DataTable data = new DataTable();
            //MessageBox.Show(dtpBusTime.Value.ToShortDateString());
            data = bus.GetBuses(txtCounter.Text, Int32.Parse(cmbBusType.SelectedValue.ToString()), dtpBusTime.Value);
            dataGridView1.DataSource = data;
            dataGridView1.Sort(dataGridView1.Columns["date"], ListSortDirection.Ascending);
        }

        private void btnResetClick(object sender, EventArgs e)
        {
            //Search: Reset Button
            RefreshGrid();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells["no"].Value.ToString();
            string a = dataGridView1.CurrentRow.Cells["avail_seat"].Value.ToString();
            //Ticket Booking Form
            TicketBookingForm tbf = new TicketBookingForm(s,a,this);
            tbf.ShowDialog(this);
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            PrintTicketForm ptf = new PrintTicketForm(dataGridView1.CurrentRow.Cells["no"].Value.ToString());
            ptf.ShowDialog(this);
        }

        public void RefreshGrid()
        {
            Bus bus = new Bus();
            DataTable dataTable = new DataTable();
            dataTable = bus.GetBuses();
            dataGridView1.DataSource = bus.GetBuses();
            dataGridView1.Sort(dataGridView1.Columns["date"], ListSortDirection.Ascending);
        }

        private void BtnCancelTicket_Click(object sender, EventArgs e)
        {
            CancelTicketForm ctf = new CancelTicketForm(this);
            ctf.ShowDialog(this);
        }

        private void BtnFindBus_Click(object sender, EventArgs e)
        {
            //txtCounter.Text = dataGridView1.Columns["btnDel"].Index.ToString();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnDel"].Index)
            {
                Bus bus = new Bus();
                if (MessageBox.Show("Are you sure about deleting this Bus?","Warning!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    bus.DelBus(dataGridView1.CurrentRow.Cells["no"].Value.ToString());
                RefreshGrid();
            }
        }

        private void AsignBussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignBusForm asignBus = new AsignBusForm();
            asignBus.ShowDialog(this);
        }

        private void AsignRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignCounterForm asignCounter = new AsignCounterForm();
            asignCounter.ShowDialog(this);
        }
    }
}

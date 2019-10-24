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
    public partial class CancelTicketForm : Form
    {
        Dashboard _dashboard;
        public CancelTicketForm(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }

        private void CancelTicketForm_Load(object sender, EventArgs e)
        {
            txtCounter.Text = LogInfo.user_counter;
        }

        private void CkbEnable_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbEnable.Checked)
            {
                foreach (Control item in grpPassengerInfo.Controls)
                {
                    if(item is TextBox)
                        item.Enabled = true;
                }
            }
            else
            {
                foreach (Control item in grpPassengerInfo.Controls)
                {
                    if(item is TextBox)
                        item.Enabled = false;
                }
            }
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            Bus bus = new Bus();

            if(txtBusNo.Text != "" && txtTicketNo.Text != "")
                data = bus.GetPassenger(txtBusNo.Text.Trim(), txtCounter.Text.Trim(), int.Parse(txtTicketNo.Text));

            txtFullName.Text = data.Rows[0]["full_name"].ToString();
            txtPhoneNo.Text = data.Rows[0]["phone_no"].ToString();
            txtFrom.Text = data.Rows[0]["start_loc"].ToString();
            txtTo.Text = data.Rows[0]["end_loc"].ToString();
            txtSeatLen.Text = data.Rows[0]["seat_length"].ToString();
            txtPrice.Text = data.Rows[0]["Price"].ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (Control item in grpPassengerInfo.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger();
            passenger.bus_no = txtBusNo.Text;
            passenger.counter = txtCounter.Text;
            passenger.ticket_no = int.Parse(txtTicketNo.Text);
            passenger.seat_length = int.Parse(txtSeatLen.Text);

            Bus bus = new Bus();
            bus.DeletePassenger(passenger);
            _dashboard.RefreshGrid();
            btnReset.PerformClick();
        }
    }
}

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
    public partial class TicketBookingForm : Form
    {
        string bus_no;
        string _availBus;
        Dashboard _dashboard;
        public TicketBookingForm(string no, string availBus, Dashboard d)
        {
            InitializeComponent();
            bus_no = no;
            _availBus = availBus;
            _dashboard = d;
        }

        private void TicketBookingForm_Load(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            txtBusNo.Text = bus_no;
            txtFrom.Text = LogInfo.user_counter;
            txtTicketNo.Text = (bus.CountPessanger(bus_no) + 1).ToString();
            lblAvailSeat.Text = "Out of " + _availBus;

            cmbDestination.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDestination.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDestination.Items.Clear();
            Account account = new Account();
            cmbDestination.DataSource = bus.GetConters(bus_no);
            cmbDestination.ValueMember = "name";
            cmbDestination.DisplayMember = "name";
            //cmbDestination.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void BtnBookNow_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger();
            passenger.bus_no = txtBusNo.Text;
            passenger.counter = txtFrom.Text;
            passenger.start_loc = txtFrom.Text;
            passenger.end_loc = cmbDestination.Text;
            passenger.full_name = txtFullName.Text;
            passenger.phone_no = txtPhoneNo.Text;
            /*passenger.seat_length = */int.TryParse(txtSeatLen.Text,out passenger.seat_length);
            /*passenger.ticket_no = */int.TryParse(txtTicketNo.Text,out passenger.ticket_no);

            if (txtFullName.Text != "" && txtPhoneNo.Text != "" && txtSeatLen.Text != "")
            {
                Bus bus = new Bus();
                bool s = false;
                if (MessageBox.Show("৳" + passenger.GetPrice().ToString(), "Price for U!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    s = bus.SetPassenger(passenger);
                }
                if (s)
                    MessageBox.Show("Updated Successfully");
                else
                    MessageBox.Show("Opps Something Worng!");
            }
            else
                MessageBox.Show("Please Fill the form.");
            _dashboard.RefreshGrid();
        }

        private void TicketBookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dashboard.RefreshGrid();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item.Enabled == true)
                    item.Text = string.Empty;
            }
        }
    }
}

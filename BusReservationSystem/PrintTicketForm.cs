using BusReservationSystem.Classes;
using Microsoft.Reporting.WinForms;
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
    public partial class PrintTicketForm : Form
    {
        string _busNo;
        public PrintTicketForm(string busNO)
        {
            InitializeComponent();
            _busNo = busNO;
        }

        private void PrintTicketForm_Load(object sender, EventArgs e)
        {
            txtBusNo.Text = _busNo;
            txtCounter.Text = LogInfo.user_counter;
            txtCounter.Enabled = false;
            txtTicket.Text = "";
            /*
             //Binding Data with Report Viewer & RDLC
             * ReportDataSource rds = new ReportDataSource();
             * rds.name = "PassengerList";
             * rds.value = bus.GetPessanger("MG-36");
             */

            Bus bus = new Bus();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PassengerList", bus.GetPessanger(_busNo)));
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
        }
    }
}

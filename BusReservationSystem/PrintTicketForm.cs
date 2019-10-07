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
            txtBusNo.Enabled = false;
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

        private void BtnPrintData_Click(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            DataTable data1 = new DataTable();
            data1 = bus.GetPessanger(_busNo);
            var data = from row in data1.AsEnumerable()
                       where row.Field<int>("ticket_no") == int.Parse(txtTicket.Text)
                       select row;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PassengerList", data.CopyToDataTable()));
            reportViewer1.RefreshReport();
        }
    }
}

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
        public PrintTicketForm()
        {
            InitializeComponent();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void PrintTicketForm_Load(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            //ReportDataSource reportDataSource = new ReportDataSource();
            //reportDataSource.Name = "DataSet1";
            //reportDataSource.Value = bus.GetPessanger("MG-36");
            //reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PassengerList", bus.GetPessanger("MG-36")));
            reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class PessengerListForm : Form
    {
        public PessengerListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Bus bus = new Classes.Bus();
            DataTable data = new DataTable();
            data = bus.GetPessanger(txtBusNo.Text);
            dataGridView1.DataSource = data;
        }

        private void PessengerListForm_Load(object sender, EventArgs e)
        {
            Classes.Bus bus = new Classes.Bus();
            DataTable data = new DataTable();
            data = bus.GetPessanger(txtBusNo.Text);
            dataGridView1.DataSource = data;
        }
    }
}

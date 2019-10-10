using BusReservationSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusReservationSystem
{
    public partial class BusListForm : Form
    {
        //Connection String [for connecting with database]
        private readonly string conStr = ConfigurationManager.ConnectionStrings["BTRS_Db"].ConnectionString;

        public BusListForm()
        {
            InitializeComponent();
        }

        private void BusListForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn()
            {
                Name = "btnDel",
                HeaderText = "Del Buttons",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(buttonColumn);

            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn()
            {
                Name = "btnReasign",
                HeaderText = "View",
                Text = "Reasign",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(buttonColumn1);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnDel"].Index)
            {
                Bus bus = new Bus();
                if (MessageBox.Show("Are you sure about deleting this Bus?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    bus.DelBus(dataGridView1.CurrentRow.Cells["no"].Value.ToString());
                RefreshGrid();
            }
            else if(e.ColumnIndex == dataGridView1.Columns["btnReasign"].Index)
            {
                AsignCounterForm asignCounter = new AsignCounterForm(dataGridView1.CurrentRow.Cells["no"].Value.ToString());
                asignCounter.ShowDialog(this);
            }
        }

        private void RefreshGrid()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                //Select All Busses based on counter
                string sql = "Select * from [Bus]";
                SqlCommand cmd = new SqlCommand(sql, con);
                da.SelectCommand = cmd;
                da.Fill(dataTable);
            }
            dataGridView1.DataSource = dataTable;
        }
    }
}

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
    public partial class AsignCounterForm : Form
    {
        //Connection String [for connecting with database]
        private readonly string conStr = ConfigurationManager.ConnectionStrings["BTRS_Db"].ConnectionString;

        AsignBusForm _asignBus;
        string _busNo;
        public AsignCounterForm(string busNo)
        {
            InitializeComponent();
            _busNo = busNo;
            _asignBus = null;
        }
        public AsignCounterForm(string busNo, AsignBusForm asignBus)
        {
            InitializeComponent();
            _asignBus = asignBus;
            _busNo = busNo;
        }

        private void AsignCounterForm_Load(object sender, EventArgs e)
        {
            txtBusNo.Text = _busNo;

            Account account = new Account();
            cmbCounter.DataSource = account.GetConters();
            cmbCounter.DisplayMember = "name";
            cmbCounter.ValueMember = "name";
            cmbCounter.Text = "Counter";

            btnUpdate.Enabled = false;
            RefreshGrid();
        }

        private void AsignCounterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_asignBus != null)
                _asignBus.Close();
        }

        private void RefreshGrid()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                //Select All Busses based on counter
                string sql = "Select * from [Bus_Counter] where [bus_no] = @busNo";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@busNo", _busNo);
                da.SelectCommand = cmd;
                da.Fill(dataTable);
            }
            cmbCounter.Text = "Counter";
            dataGridView1.DataSource = dataTable;
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbCounter.SelectedValue = dataGridView1.CurrentRow.Cells["counter_name"].Value;
            dtpDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["date"].Value.ToString());
            dtpTime.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["time"].Value.ToString());
            btnUpdate.Enabled = true;
            btnAddUpdate.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cmbCounter.Text = "Counter";
            btnUpdate.Enabled = false;
            btnAddUpdate.Enabled = true;
        }

        private void BtnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    string sql = "Insert into [Bus_Counter] values('" +
                        cmbCounter.SelectedValue + "', '" +
                        txtBusNo.Text + "', '" +
                        dtpDate.Value.Date + "', '" +
                        dtpTime.Value.TimeOfDay + "')";
                    SqlCommand cmd = new SqlCommand(sql, sqlCon);
                    sqlCon.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        RefreshGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

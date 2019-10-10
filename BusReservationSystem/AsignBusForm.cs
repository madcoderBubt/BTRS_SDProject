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
    public partial class AsignBusForm : Form
    {
        //Connection String [for connecting with database]
        private readonly string conStr = ConfigurationManager.ConnectionStrings["BTRS_Db"].ConnectionString;

        public AsignBusForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(conStr))
                {
                    int seat = int.Parse(txtTotalSeat.Text);
                    string sql = "Insert into [Bus] values('" +
                        txtBusNo.Text + "', " +
                        cmbBusType.SelectedValue + ", " +
                        seat + ", " +
                        seat + ")";
                    SqlCommand cmd = new SqlCommand(sql, sqlCon);
                    sqlCon.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        sqlCon.Close(); //closing connection for unintendent error
                        AsignCounterForm asignCounter = new AsignCounterForm(txtBusNo.Text, this);
                        asignCounter.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void AsignBusForm_Load(object sender, EventArgs e)
        {
            Bus bus = new Bus();
            //Bus Types for combo box
            cmbBusType.DataSource = bus.GetBusType();
            cmbBusType.DisplayMember = "type";
            cmbBusType.ValueMember = "id";
            cmbBusType.Text = "Type";
            
        }
    }
}

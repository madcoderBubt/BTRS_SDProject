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

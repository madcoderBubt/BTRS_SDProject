using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BusReservationSystem.Classes
{
    class Bus
    {
        //Connection String [for connecting with database]
        private readonly string conStr = ConfigurationManager.ConnectionStrings["BTRS_Db"].ConnectionString;

        public DataTable GetBuses()
        {
            //Get List of Busses from Database & return as DataTable 
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "select [Bus].*, [Bus_Counter].time from [Bus] full outer join [Bus_Counter] on [Bus].[no] = [Bus_Counter].[bus_no] where [Bus_Counter].[counter_name] = @currentCounter";
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@currentCounter", LogInfo.user_counter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable GetPessanger(string busNo)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(conStr)) 
            {
                string sql = "select * from [Passenger] where bus_no = @busNo";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@busNo", busNo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
            }
            return data;
        }
    }
}

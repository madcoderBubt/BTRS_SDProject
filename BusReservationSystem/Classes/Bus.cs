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
                string sql = "select [Bus].*, [Bus_Counter].[date], [time] from [Bus] full outer join [Bus_Counter] on [Bus].[no] = [Bus_Counter].[bus_no] where [Bus_Counter].[counter_name] = @currentCounter";
                SqlCommand cmd = new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@currentCounter", LogInfo.user_counter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable GetBuses(string destination, int busType, DateTime busDate)
        {
            //Get List of Busses from Database & return as DataTable 
            //For searching Busses with requirments
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "select [Bus].*, [Bus_Counter].[date], [time] from [Bus] "
                    + "full outer join [Bus_Counter] on [Bus].[no] = [Bus_Counter].[bus_no] where [Bus_Counter].[counter_name] = @currentCounter "
                    + "/*and [Bus].[no] like @busNo */ and [Bus].[type] = @busType and [Bus_Counter].[date] = @busDate";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@currentCounter", LogInfo.user_counter);
                cmd.Parameters.AddWithValue("@busNo", destination);
                cmd.Parameters.AddWithValue("@busType", busType);
                cmd.Parameters.AddWithValue("@busDate", busDate.ToShortDateString());
                //System.Windows.Forms.MessageBox.Show(busDate.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable GetBusType()
        {
            //Get Bus Type
            DataTable data = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                string sql = "select * from [Bus_Type]";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                //cmd.Parameters.AddWithValue("@busNo", busNo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
            }
            return data;
        }

        public DataTable GetPessanger(string busNo)
        {
            //Get Pessanger List for speacific bus
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

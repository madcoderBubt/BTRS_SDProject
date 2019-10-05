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
                    + "and [Bus].[type] = @busType and [Bus_Counter].[date] = @busDate "
                    + "and [Bus].[no] = any( select [Bus_Counter].[bus_no] from [Bus_Counter] where counter_name like @counterName)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@currentCounter", LogInfo.user_counter);
                cmd.Parameters.AddWithValue("@counterName", destination + "%");
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

        public int CountPessanger(string busNo)
        {
            int count;
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                DataTable data = new DataTable();
                string sql = "select count(*) as [counts] from [Passenger] where bus_no = @busNo";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@busNo", busNo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                count = Int32.Parse(data.Rows[0][0].ToString());
            }
            return count;
        }

        public bool SetPassenger(Passenger p)
        {
            bool b;
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                string sql = "Insert into [Passenger] values "
                    + "( " 
                    + p.ticket_no + ", '"
                    + p.full_name + "', '"
                    + p.phone_no + "', '"
                    + p.bus_no + "', '"
                    + p.start_loc + "', '"
                    + p.end_loc + "', "
                    + p.seat_length + ", '"
                    + p.counter + "', "
                    + p.GetPrice() + " )";
                    //+ "(@ticketNo, '@fullName', '@phoneNo', '@busNo', '@startLoc', '@endLoc', @seatLength, '@counter', @price)";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                //cmd.Parameters.AddWithValue("@ticketNo", p.ticket_no);
                //cmd.Parameters.AddWithValue("@fullName", p.full_name);
                //cmd.Parameters.AddWithValue("@phoneNo", p.phone_no);
                //cmd.Parameters.AddWithValue("@busNo", p.bus_no);
                //cmd.Parameters.AddWithValue("@startLoc", p.start_loc);
                //cmd.Parameters.AddWithValue("@endLoc", p.end_loc);
                //cmd.Parameters.AddWithValue("@seatLength", p.seat_length);
                //cmd.Parameters.AddWithValue("@counter", p.counter);                
                //cmd.Parameters.AddWithValue("@price", p.GetPrice());
                sqlCon.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    string sqlUpdate = "Update [Bus] set [avail_seat] = " 
                        + (GetAvailSeat(p.bus_no) - p.seat_length) 
                        + "where [no] = '" + p.bus_no+"'";
                    SqlCommand cmd2 = new SqlCommand(sqlUpdate, sqlCon);
                    cmd2.ExecuteNonQuery();
                    b = true;
                }
                else
                    b = false;
            }
            return b;
        }

        public DateTime GetTime(string busNo, string counterName, DateTime? date)
        {
            DateTime date1, time1 ;
            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                string sql = "select [date], [time] from [Bus_Counter] where [counter_name] = @counterName and [bus_no] = @busNo";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.Parameters.AddWithValue("@counterName", counterName);
                cmd.Parameters.AddWithValue("@busNo", busNo);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);
                date1 = DateTime.Parse(data.Rows[0][0].ToString());
                time1 = DateTime.Parse(data.Rows[0][1].ToString());
            }
            return date1.Add(time1.TimeOfDay);
        }

        public DataTable GetConters(string search)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "SELECT [counter_name] as [name] FROM [Bus_Counter] where [Bus_Counter].[bus_no] = @searchText";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@searchText", search);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
            }
            return dt;
        }

        public int GetAvailSeat(string busNo)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "select [avail_seat] from [Bus] where [no] = '" +busNo+"'";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
            }
            return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}

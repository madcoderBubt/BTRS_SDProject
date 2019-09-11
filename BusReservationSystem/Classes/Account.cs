using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BusReservationSystem.Classes
{
    public class Account
    {
        //Properties
        public int User_id { get; set; }
        public string Full_name { get; set; }
        public string Password { get; set; }
        public string Phone_no { get; set; }
        public string Counter { get; set; }
        public int Role { get; set; }
        //Connection String [for connecting with database]
        private readonly string conStr = ConfigurationManager.ConnectionStrings["BTRS_Db"].ConnectionString;

        //Login Method
        public bool Login(string phoneNum, string password)
        {
            bool isSuccess = false;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "SELECT [user_id],[full_name],[counter],[role] FROM [User] WHERE [phone_no] = @phone_no AND [password] = @password;";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@phone_no", phoneNum);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                int row = dt.Rows.Count;
                if (row > 0)
                {
                    LogInfo.user_id = int.Parse(dt.Rows[0][0].ToString());
                    LogInfo.user_name = dt.Rows[0][1].ToString();
                    LogInfo.user_role = int.Parse(dt.Rows[0][3].ToString());
                    LogInfo.user_counter = dt.Rows[0][2].ToString();
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            return isSuccess;
        }

        //Register Method
        public bool Register()
        {
            //System.Windows.Forms.MessageBox.Show(Properties.PropertyName<Account>(x => x.user_id));
            bool isSuccess = false;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "INSERT INTO [User]([full_name],[phone_no] ,[password],[counter],[role]) VALUES (@fullName, @phone, @pass, @counter, @role)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@fullName", Full_name);
                cmd.Parameters.AddWithValue("@phone", Phone_no);
                cmd.Parameters.AddWithValue("@pass", Password);
                cmd.Parameters.AddWithValue("@counter", Counter);
                cmd.Parameters.AddWithValue("@role", Role);
                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            return isSuccess;
        }

       //Get Roles
       public DataTable GetRoles()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "SELECT * FROM [Role]";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
            }
            return dt;
        }

        //Get Counters
        public DataTable GetConters()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "SELECT * FROM [counter]";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);
            }
            return dt;
        }
    }
}

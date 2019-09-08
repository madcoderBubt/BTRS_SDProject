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
        public int user_id { get; set; }
        //public string full_name { get; set; }
        //public string password { get; set; }
        //public string phone_no { get; set; }
        //public string counter { get; set; }
        //public int role { get; set; }
        private readonly string conStr = ConfigurationManager.ConnectionStrings["BTRS_Db"].ConnectionString;

        public bool Login(string phoneNum, string password)
        {
            bool isSuccess = false;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string sql = "SELECT * FROM User WHERE phone_no = @phone_no && password = @password;";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@phone_no", phoneNum);
                cmd.Parameters.AddWithValue("@password", password);

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

        public void Register()
        {
            System.Windows.Forms.MessageBox.Show(Properties.PropertyName<Account>(x => x.user_id));
        }

       
    }
}

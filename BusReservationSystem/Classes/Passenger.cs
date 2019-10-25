using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BusReservationSystem.Classes
{
    class Passenger
    {
        //Connection String [for connecting with database]
        //private readonly string conStr = ConfigurationManager.ConnectionStrings["BTRS_Db"].ConnectionString;

        public int ticket_no;
        public string full_name;
        public string phone_no;
        public string bus_no;
        public string start_loc;
        public string end_loc;
        public int seat_length;
        public string counter;
        
        public decimal GetPrice()
        {
            double hours = 0;
            decimal price;
            Bus b = new Bus();
            DateTime time1 = b.GetTime(bus_no, start_loc, null);
            DateTime time2 = b.GetTime(bus_no, end_loc, null);
            hours = (time2 - time1).TotalHours;
            if (hours <= 1)
                price = 75.50m * seat_length;
            else
                price = 75.50m * seat_length + (decimal)((hours - 1) * 60) * seat_length;
            return price;
        }
    }
}

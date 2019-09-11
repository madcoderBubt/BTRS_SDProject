using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusReservationSystem.Classes
{
    public static class LogInfo
    {
        //for Login Session
        //So that we can know who is the current user
        //also his/her role and counter name.
        public static int user_id;
        public static string user_name;
        public static string user_counter;
        public static int user_role;

        //Clean Data if logout occured.
        public static void CleanSession()
        {
            LogInfo.user_name = null;
            LogInfo.user_id = -1;
            LogInfo.user_role = -1;
            LogInfo.user_counter = null;
        }
    }
}

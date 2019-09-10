using BusReservationSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusReservationSystem
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            txtId.Text = LogInfo.user_id.ToString();
            txtName.Text = LogInfo.user_name;
            txtCounter.Text = LogInfo.user_counter;
            txtRole.Text = LogInfo.user_role.ToString();
        }
    }
}

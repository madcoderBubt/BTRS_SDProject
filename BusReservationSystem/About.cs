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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void picSudha_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://madcoderbubt.github.io/MadCoderPersonal/");
        }
    }
}

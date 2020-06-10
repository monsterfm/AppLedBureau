using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AppLedBureau
{
    public partial class LED : Form
    {
        public LED()
        {
            InitializeComponent();
            trackBarBlue.Maximum = 255;
            trackBarBlue.Minimum = 0;
            trackBarGreen.Maximum = 255;
            trackBarGreen.Minimum = 0;
            trackBarRed.Maximum = 255;
            trackBarRed.Minimum = 0;
            serialPort1.Open();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            byte[] color = new byte[3];
            color[0] = (byte)trackBarRed.Value;
            byte[] green = new byte[1];
            color[1] = (byte)trackBarGreen.Value;
            byte[] blue = new byte[1];
            color[2] = (byte)trackBarBlue.Value;
            serialPort1.Write(color, 0, 3);
        }

        private void InstantApply_CheckedChanged(object sender, EventArgs e)
        {
            if (InstantApply.Checked == true)
                Apply.Enabled = false;
            else
                Apply.Enabled = true;
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            if (InstantApply.Checked == true)
            {
                serialPort1.Write(trackBarRed.Value.ToString());
                serialPort1.Write(trackBarGreen.Value.ToString());
                serialPort1.Write(trackBarBlue.Value.ToString());
            }
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            if (InstantApply.Checked == true)
            {
                serialPort1.Write(trackBarRed.Value.ToString());
                serialPort1.Write(trackBarGreen.Value.ToString());
                serialPort1.Write(trackBarBlue.Value.ToString());
            }
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            if (InstantApply.Checked == true)
            {
                serialPort1.Write(trackBarRed.Value.ToString());
                serialPort1.Write(trackBarGreen.Value.ToString());
                serialPort1.Write(trackBarBlue.Value.ToString());
            }
        }
    }
}

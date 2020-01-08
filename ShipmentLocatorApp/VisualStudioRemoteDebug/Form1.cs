using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStudioRemoteDebug
{
    public partial class Form1 : Form
    {
        int seconds = 180;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimeTo.Text = $"{seconds/60}:00";
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            
            lblTimeTo.Text = (seconds / 60).ToString("00") + ":" + (seconds % 60).ToString("00");

            if (seconds == 0) { timer1.Stop(); Alarm(); }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Alarm()
        {
            this.BackColor = Color.Green;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

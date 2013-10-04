using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using System.Text;
using System.Windows.Forms;

namespace Remit
{
    public partial class Remit : Form
    {
        private bool Running = false;
        private int days,hours, minutes, seconds;
        private VisualStyleRenderer vsr;
        private VisualStyleElement vse;
        public Remit()
        {   
            vse = VisualStyleElement.Taskbar.BackgroundTop.Normal;
            vsr = new VisualStyleRenderer(vse);
            
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            vsr.DrawBackground(e.Graphics, this.ClientRectangle);
            base.OnPaint(e);
        }

        private void updateDisplay()
        {
            lSec.Text = seconds.ToString("D2");
            lDaysHourMin.Text = days.ToString("D2") + ":" + hours.ToString("D2") + ":" + minutes.ToString("D2");

        }
        private void ticker_Tick(object sender, EventArgs e)
        {
            if (Running)
            {
                seconds++;
                if (seconds > 59)
                {
                    seconds = 0;
                    minutes++;
                }
                if (minutes > 59)
                {
                    minutes = 0;
                    hours++;
                }
                if (hours > 23)
                {
                    hours = 0;
                    days++;
                }
                updateDisplay();
                GC.Collect();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Running = true;
            ticker.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Running = false;
            ticker.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            days = hours = minutes = seconds = 0;
            updateDisplay();
        }

        
    }
}

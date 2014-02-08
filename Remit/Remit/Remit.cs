/*
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301, USA.
 * 
 * by Wade Harkins (vdtdev@gmail.com)
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace Remit
{
    /// <summary>
    /// Standard Remit UI
    /// </summary>
    public partial class Remit : Form
    {
        private bool Running = false;
        private int days,hours, minutes, seconds;
        private VisualStyleRenderer vsr;
        private VisualStyleElement vse;
        
        /// <summary>
        /// Class constructor accepting a starting time value
        /// </summary>
        /// <param name="time">Array of integers specifying 
        /// <code>{days,hours,minutes,seconds}</code>
        /// </param>
        public Remit(int[] time)
        {
            /* set the timer values, so that it can continue if it just 
             * switched over from normal mode */
            days = time[0];
            hours = time[1];
            minutes = time[2];
            seconds = time[3];

            bool vs = true; // visual styles work
            InitializeComponent();
            /* Just encase something odd happens and visual styles aren't available, don't
             * break the program entirely :) */
            try
            {
                vse = VisualStyleElement.Taskbar.BackgroundTop.Normal;
                vsr = new VisualStyleRenderer(vse);
            }
            catch (Exception ex)
            {
                vs = false; // ok, no they don't :(
                MessageBox.Show(
                    String.Format("Unable to aquire Visual Style renderer:\n {0}", ex.Message),
                    "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // don't bother forcing user painting if we couldn't get the vsr
            if (vs)
            {
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            }


        }

        /// <summary>
        /// Default constructor for the Remit timer window
        /// </summary>
        public Remit()
            : this(new int[] { 0, 0, 0, 0 })
        {
            // main constructor handles things :]
        }
        /// <summary>
        /// Painting override to render the visual style based background
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            vsr.DrawBackground(e.Graphics, this.ClientRectangle);
            base.OnPaint(e);
        }

        /// <summary>
        /// Update the "timer" labels to reflect the amount of time passed
        /// </summary>
        private void updateDisplay()
        {
            lSec.Text = seconds.ToString("D2");
            lDaysHourMin.Text = days.ToString("D2") + ":" + hours.ToString("D2") + ":" + minutes.ToString("D2");

        }
        /// <summary>
        /// Handle timer ticks (1x each second)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                GC.Collect(); // force garbage collection (for now...) to keep it from eating memory
            }
        }

        /// <summary>
        /// "Start" button clicked, start the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            Running = true;
            ticker.Start();
        }

        /// <summary>
        /// "Stop" button clicked, stop the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            Running = false;
            ticker.Stop();
        }

        /// <summary>
        /// Reset the timer back to 00:00:00 00 and update the display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            days = hours = minutes = seconds = 0;
            updateDisplay();
        }

        private void btnMicro_Click(object sender, EventArgs e)
        {
            Micro microMode = new Micro(new int[] { days, hours, minutes, seconds },ticker.Enabled, ref ticker);
            microMode.Show();
            microMode.FormClosed+=new FormClosedEventHandler(onMicroClose);
            microMode.ExitMicroModeEvent += new EventHandler(onExitMicroMode);
            this.Hide();
            
        }

        /// <summary>
        /// Exit micro mode and restore this view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onExitMicroMode(object sender, EventArgs e)
        {
            //this.Show();
            Button f = (Button)sender;
            Micro m = (Micro)f.FindForm();
            this.Show();
            int[] t = m.Time;
            days = t[0];
            hours = t[1];
            minutes = t[2];
            seconds = t[3];
            this.ticker.Enabled = m.Active;
            //e.Cancel = true;
            m.Close();
            this.Show();
        }

        /// <summary>
        /// Handles exiting the program when a micro-mode view of a timer is closed
        /// If this form is hidden, then assume we are exiting and quit
        /// Otherwise, copy the time from the micro form and use it as the new time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void onMicroClose(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                Application.DoEvents();
                Application.Exit();
            }
            else
            {
                Micro m = (Micro)sender;
                int[] t = m.Time;
                days = t[0];
                hours = t[1];
                minutes = t[2];
                seconds = t[3];
                updateDisplay();
            }
        }
    }
}

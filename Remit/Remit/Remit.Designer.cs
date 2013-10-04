namespace Remit
{
    partial class Remit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remit));
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.lHeadS = new System.Windows.Forms.Label();
            this.lHeadM = new System.Windows.Forms.Label();
            this.lHeadH = new System.Windows.Forms.Label();
            this.lSec = new System.Windows.Forms.Label();
            this.lDaysHourMin = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lHeadD = new System.Windows.Forms.Label();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.layoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTable
            // 
            this.layoutTable.BackColor = System.Drawing.Color.Transparent;
            this.layoutTable.ColumnCount = 6;
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutTable.Controls.Add(this.lHeadS, 4, 0);
            this.layoutTable.Controls.Add(this.lHeadM, 3, 0);
            this.layoutTable.Controls.Add(this.lHeadH, 2, 0);
            this.layoutTable.Controls.Add(this.lSec, 4, 1);
            this.layoutTable.Controls.Add(this.lDaysHourMin, 1, 1);
            this.layoutTable.Controls.Add(this.btnStart, 1, 2);
            this.layoutTable.Controls.Add(this.btnStop, 2, 2);
            this.layoutTable.Controls.Add(this.btnReset, 3, 2);
            this.layoutTable.Controls.Add(this.lHeadD, 1, 0);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(0, 0);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 3;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.layoutTable.Size = new System.Drawing.Size(304, 162);
            this.layoutTable.TabIndex = 0;
            // 
            // lHeadS
            // 
            this.lHeadS.AutoSize = true;
            this.lHeadS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lHeadS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lHeadS.Location = new System.Drawing.Point(233, 0);
            this.lHeadS.Name = "lHeadS";
            this.lHeadS.Size = new System.Drawing.Size(48, 32);
            this.lHeadS.TabIndex = 10;
            this.lHeadS.Text = "seconds";
            this.lHeadS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lHeadM
            // 
            this.lHeadM.AutoSize = true;
            this.lHeadM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lHeadM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lHeadM.Location = new System.Drawing.Point(163, 0);
            this.lHeadM.Name = "lHeadM";
            this.lHeadM.Size = new System.Drawing.Size(64, 32);
            this.lHeadM.TabIndex = 8;
            this.lHeadM.Text = "minutes";
            this.lHeadM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lHeadH
            // 
            this.lHeadH.AutoSize = true;
            this.lHeadH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lHeadH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lHeadH.Location = new System.Drawing.Point(93, 0);
            this.lHeadH.Name = "lHeadH";
            this.lHeadH.Size = new System.Drawing.Size(64, 32);
            this.lHeadH.TabIndex = 7;
            this.lHeadH.Text = "hours";
            this.lHeadH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lSec
            // 
            this.lSec.AutoSize = true;
            this.lSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSec.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSec.ForeColor = System.Drawing.Color.Lime;
            this.lSec.Location = new System.Drawing.Point(233, 32);
            this.lSec.Name = "lSec";
            this.lSec.Size = new System.Drawing.Size(48, 82);
            this.lSec.TabIndex = 0;
            this.lSec.Text = "00";
            this.lSec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lDaysHourMin
            // 
            this.lDaysHourMin.AutoSize = true;
            this.lDaysHourMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layoutTable.SetColumnSpan(this.lDaysHourMin, 3);
            this.lDaysHourMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDaysHourMin.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDaysHourMin.ForeColor = System.Drawing.Color.Lime;
            this.lDaysHourMin.Location = new System.Drawing.Point(23, 32);
            this.lDaysHourMin.Name = "lDaysHourMin";
            this.lDaysHourMin.Size = new System.Drawing.Size(204, 82);
            this.lDaysHourMin.TabIndex = 1;
            this.lDaysHourMin.Text = "00:00:00";
            this.lDaysHourMin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 117);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(63, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 117);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(63, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(163, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lHeadD
            // 
            this.lHeadD.AutoSize = true;
            this.lHeadD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lHeadD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lHeadD.Location = new System.Drawing.Point(23, 0);
            this.lHeadD.Name = "lHeadD";
            this.lHeadD.Size = new System.Drawing.Size(64, 32);
            this.lHeadD.TabIndex = 5;
            this.lHeadD.Text = "days";
            this.lHeadD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ticker
            // 
            this.ticker.Interval = 1000;
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // Remit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 162);
            this.Controls.Add(this.layoutTable);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Remit";
            this.Text = "Remit";
            this.layoutTable.ResumeLayout(false);
            this.layoutTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTable;
        private System.Windows.Forms.Label lSec;
        private System.Windows.Forms.Label lDaysHourMin;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lHeadS;
        private System.Windows.Forms.Label lHeadM;
        private System.Windows.Forms.Label lHeadH;
        private System.Windows.Forms.Label lHeadD;
        private System.Windows.Forms.Timer ticker;
    }
}


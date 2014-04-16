namespace Remit
{
    partial class DialogTask
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTask, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTask
            // 
            this.txtTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTask.ForeColor = System.Drawing.Color.Lime;
            this.txtTask.Location = new System.Drawing.Point(7, 11);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(155, 21);
            this.txtTask.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(168, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(42, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Tag = "Stop";
            this.btnStop.Text = "OK";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // DialogTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(217, 45);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogTask";
            this.Text = "Name Task";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnStop;
    }
}
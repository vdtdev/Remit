using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Remit
{
    public partial class DialogTask : Form
    {
        public DialogTask()
        {
            InitializeComponent();
        }
        public String TaskTitle
        {
            get
            {
                return txtTask.Text;
            }
        }
    }
}

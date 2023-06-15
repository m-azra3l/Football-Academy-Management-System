using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Football_Academy_Management_System
{
    public partial class Calender : Form
    {
        public Calender()
        {
            InitializeComponent();
        }
     
        private void picMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}

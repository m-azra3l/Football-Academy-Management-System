using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Football_Academy_Management_System
{
    public partial class main : Form
    {
        

        public main()
        {
            InitializeComponent();
            
        }
     

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit Club Manager") == MsgBoxResult.Yes)
            {
                Application.Exit();
            }
        }

        
       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newplayer newMDIChild = new newplayer();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void performanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performance newMDIChild = new performance();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventory newMDIChild = new inventory();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void tournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tournament newMDIChild = new tournament();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }    

        private void injuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            injury newMDIChild = new injury();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fine newMDIChild = new fine();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void suspensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suspension newMDIChild = new suspension();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void adminCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admincredentials newMDIChild = new admincredentials();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calender newMDIChild = new Calender();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator newMDIChild = new Calculator();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

       

        private void teamPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teamperformance newMDIChild = new teamperformance();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About newMDIChild = new About();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        /*private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit Club Manager") == MsgBoxResult.Yes)
            {
                Application.Exit();
            }
        }*/

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy HH:MM:ss ");
        }

        
    }
}

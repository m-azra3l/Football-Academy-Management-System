namespace Football_Academy_Management_System
{
    partial class main
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
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamPerformanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injuryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.adminCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.toolsMenu,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1354, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.Image = ((System.Drawing.Image)(resources.GetObject("fileMenu.Image")));
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(62, 22);
            this.fileMenu.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.performanceToolStripMenuItem,
            this.teamPerformanceToolStripMenuItem,
            this.equipmentToolStripMenuItem,
            this.tournamentToolStripMenuItem,
            this.injuryToolStripMenuItem,
            this.fineToolStripMenuItem,
            this.suspensionToolStripMenuItem});
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.ShowShortcutKeys = false;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("playerToolStripMenuItem.Image")));
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.playerToolStripMenuItem.Text = "&Player ";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("performanceToolStripMenuItem.Image")));
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.performanceToolStripMenuItem.Text = "&Player Performance";
            this.performanceToolStripMenuItem.Click += new System.EventHandler(this.performanceToolStripMenuItem_Click);
            // 
            // teamPerformanceToolStripMenuItem
            // 
            this.teamPerformanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teamPerformanceToolStripMenuItem.Image")));
            this.teamPerformanceToolStripMenuItem.Name = "teamPerformanceToolStripMenuItem";
            this.teamPerformanceToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.teamPerformanceToolStripMenuItem.Text = "&Club Performance";
            this.teamPerformanceToolStripMenuItem.Click += new System.EventHandler(this.teamPerformanceToolStripMenuItem_Click);
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("equipmentToolStripMenuItem.Image")));
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            this.equipmentToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.equipmentToolStripMenuItem.Text = "&Inventory";
            this.equipmentToolStripMenuItem.Click += new System.EventHandler(this.equipmentToolStripMenuItem_Click);
            // 
            // tournamentToolStripMenuItem
            // 
            this.tournamentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tournamentToolStripMenuItem.Image")));
            this.tournamentToolStripMenuItem.Name = "tournamentToolStripMenuItem";
            this.tournamentToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tournamentToolStripMenuItem.Text = "&Tournament";
            this.tournamentToolStripMenuItem.Click += new System.EventHandler(this.tournamentToolStripMenuItem_Click);
            // 
            // injuryToolStripMenuItem
            // 
            this.injuryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("injuryToolStripMenuItem.Image")));
            this.injuryToolStripMenuItem.Name = "injuryToolStripMenuItem";
            this.injuryToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.injuryToolStripMenuItem.Text = "&Injury";
            this.injuryToolStripMenuItem.Click += new System.EventHandler(this.injuryToolStripMenuItem_Click);
            // 
            // fineToolStripMenuItem
            // 
            this.fineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fineToolStripMenuItem.Image")));
            this.fineToolStripMenuItem.Name = "fineToolStripMenuItem";
            this.fineToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.fineToolStripMenuItem.Text = "&Fine";
            this.fineToolStripMenuItem.Click += new System.EventHandler(this.fineToolStripMenuItem_Click);
            // 
            // suspensionToolStripMenuItem
            // 
            this.suspensionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("suspensionToolStripMenuItem.Image")));
            this.suspensionToolStripMenuItem.Name = "suspensionToolStripMenuItem";
            this.suspensionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.suspensionToolStripMenuItem.Text = "&Suspension";
            this.suspensionToolStripMenuItem.Click += new System.EventHandler(this.suspensionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminCredentialsToolStripMenuItem});
            this.editMenu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenu.Image = ((System.Drawing.Image)(resources.GetObject("editMenu.Image")));
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(65, 22);
            this.editMenu.Text = "&Edit";
            // 
            // adminCredentialsToolStripMenuItem
            // 
            this.adminCredentialsToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCredentialsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminCredentialsToolStripMenuItem.Image")));
            this.adminCredentialsToolStripMenuItem.Name = "adminCredentialsToolStripMenuItem";
            this.adminCredentialsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.adminCredentialsToolStripMenuItem.Text = "&Admin Credential";
            this.adminCredentialsToolStripMenuItem.Click += new System.EventHandler(this.adminCredentialsToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.calenderToolStripMenuItem});
            this.toolsMenu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolsMenu.Image")));
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(71, 22);
            this.toolsMenu.Text = "&Tools";
            this.toolsMenu.Click += new System.EventHandler(this.toolsMenu_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculatorToolStripMenuItem.Image")));
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.calculatorToolStripMenuItem.Text = "&Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // calenderToolStripMenuItem
            // 
            this.calenderToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calenderToolStripMenuItem.Image")));
            this.calenderToolStripMenuItem.Name = "calenderToolStripMenuItem";
            this.calenderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.calenderToolStripMenuItem.Text = "&Calender";
            this.calenderToolStripMenuItem.Click += new System.EventHandler(this.calenderToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 715);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.White;
            this.lblDateTime.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Black;
            this.lblDateTime.Location = new System.Drawing.Point(1168, 748);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(196, 23);
            this.lblDateTime.TabIndex = 9;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 737);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem injuryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamPerformanceToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}




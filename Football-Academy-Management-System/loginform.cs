using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using Microsoft.VisualBasic;

namespace Football_Academy_Management_System
{
    public partial class loginform : Form
    {
        SqlCeConnection con = new SqlCeConnection();
        public loginform()
        {
            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf");
            InitializeComponent();
        }
        private void loginform_Load(object sender, EventArgs e)
        {
            
            SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
            con.Open();

            {
            }
        }
       
        private void login_Click(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection();
            con.ConnectionString = "Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf");
            con.Open();
            string password = pass.Text;  
            SqlCeCommand cmd = new SqlCeCommand("select password from admin where password='" + pass.Text +  "'", con);  
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);  
            DataTable dt = new DataTable();  
            da.Fill(dt);  
            if (dt.Rows.Count > 0)  
            {  
                MessageBox.Show("Login success! Welcome to Club Manager");
                
                
               
                //this.Dispose();
                this.Visible = false;
                main manager = new main();
                manager.Show();
            }  
            else  
            {  
                MessageBox.Show("Invalid password! Please enter the correct password");
                ClearData(); 
            }  
            con.Close();  
        }

        private void ClearData()
        {
            pass.Text = "";
            

        }
        private void cancel_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit Club Manager") == MsgBoxResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit Club Manager") == MsgBoxResult.Yes)
            {
                Application.Exit();
            }
        }

        
        }
    }


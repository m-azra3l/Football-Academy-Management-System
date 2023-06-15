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

namespace Football_Academy_Management_System
{
    public partial class admincredentials : Form
    {
        public admincredentials()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";


        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
                SqlCeConnection con = new SqlCeConnection();
                con.ConnectionString = "Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf");
                con.Open();
                string password = textBox1.Text;
                SqlCeCommand cmd = new SqlCeCommand("select password from admin where password='" + textBox1.Text + "'", con);
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0 & textBox2.Text != "")
                {
                    try
                    {
                        SqlCeConnection con1 = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                        con1.Open();


                        String sql = "Update admin set password='" + textBox2.Text + "'";

                        SqlCeCommand cmd1 = new SqlCeCommand(sql, con1);
                        cmd1.ExecuteNonQuery();

                        con1.Close();
                        MessageBox.Show("Your password has been updated successfully..");


                        this.Close();
                    }
                    catch (SqlCeException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid password! Please enter the correct password");
                    ClearData();
                }
                con.Close();
            }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        }
    }


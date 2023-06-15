﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.IO;
namespace Football_Academy_Management_System
{
    public partial class tournament : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
        SqlCeCommand cmd;
        SqlCeDataAdapter adapt;
        public tournament()
        {
            InitializeComponent();
            DisplayData();
        }

        private void tournament_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerDataSet.tournament' table. You can move, or remove it, as needed.
            this.tournamentTableAdapter.Fill(this.managerDataSet.tournament);
            
        }
        private void DisplayData()
        {

            DataTable dt = new DataTable();
            adapt = new SqlCeDataAdapter("select * from tournament", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            comboBox1.Text = "Select Style";
            comboBox2.Text = "Select Finish Position";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                    con.Open();

                    String sql = "INSERT INTO tournament(Year,Name,Host,Style,No_of_Teams,Finish_Position,Kickoff_Date,Closing_Date,Location,Duration,Matches_Played,Matches_Won,Matches_Lost,Matches_Drawn,Goals_Scored,Goals_Conceded,Yellow_Cards,Red_Cards) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')";
                    SqlCeCommand cmd = new SqlCeCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details saved successfully... ");
                    DisplayData();
                    ClearData();
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please provide details!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from tournament where Year='" + textBox1.Text + "'", con);
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = (dr["Year"].ToString());
                    textBox2.Text = (dr["Name"].ToString());
                    textBox3.Text = (dr["Host"].ToString());
                    textBox4.Text = (dr["No_of_Teams"].ToString());
                    textBox5.Text = (dr["Location"].ToString());
                    textBox6.Text = (dr["Duration"].ToString());
                    textBox7.Text = (dr["Matches_Played"].ToString());
                    textBox8.Text = (dr["Matches_Won"].ToString());
                    textBox9.Text = (dr["Matches_Lost"].ToString());
                    textBox10.Text = (dr["Matches_Drawn"].ToString());
                    textBox11.Text = (dr["Goals_Scored"].ToString());
                    textBox12.Text = (dr["Goals_Conceded"].ToString());
                    textBox13.Text = (dr["Yellow_Cards"].ToString());
                    textBox14.Text = (dr["Red_Cards"].ToString());
                    comboBox1.Text = (dr["Style"].ToString());
                    comboBox2.Text = (dr["Finish_Position"].ToString());
                    dateTimePicker1.Text = (dr["Kickoff_Date"].ToString());
                    dateTimePicker2.Text = (dr["Closing_Date"].ToString());
                }

                con.Close();

            }
            else
            {
                MessageBox.Show("Please enter year then click on search to display information for editing and updating...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    String Connection2 = (@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                    String Query = "update tournament set Year='" + this.textBox1.Text + "',Name='" + this.textBox2.Text + "',Host='" + this.textBox3.Text + "',No_of_Teams='" + this.textBox4.Text + "',Location='" + this.textBox5.Text + "',Duration='" + this.textBox6.Text + "',Matches_Played='" + this.textBox7.Text + "',Matches_Won='" + this.textBox8.Text + "',Matches_Lost='" + this.textBox9.Text + "',Matches_Drawn='" + this.textBox10.Text + "',Goals_Scored='" + this.textBox11.Text + "',Goals_Conceded='" + this.textBox12.Text + "',Yellow_Cards='" + this.textBox13.Text + "',Red_Cards='" + this.textBox14.Text + "',Style='" + this.comboBox1.Text + "',Finish_Position='" + this.comboBox2.Text + "',Kickoff_Date='" + this.dateTimePicker1.Text + "',Closing_Date='" + this.dateTimePicker2.Text + "' where Year='" + this.textBox1.Text + "';";
                    SqlCeConnection Conn2 = new SqlCeConnection(Connection2);
                    SqlCeCommand Command2 = new SqlCeCommand(Query, Conn2);
                    SqlCeDataReader Reader2;
                    Conn2.Open();
                    Reader2 = Command2.ExecuteReader();
                    MessageBox.Show("Details updated successfully...");
                    while (Reader2.Read())
                    {
                    }
                    Conn2.Close();
                    DisplayData();
                    ClearData();
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter year then click on search to fetch details for update or view..");
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                cmd = new SqlCeCommand("delete tournament where Year=@year", con);
                con.Open();
                cmd.Parameters.AddWithValue("@year", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Details deleted successfully...");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please enter year to delete record...");
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

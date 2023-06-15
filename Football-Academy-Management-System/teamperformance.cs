using System;
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
    public partial class teamperformance : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
        SqlCeCommand cmd;
        SqlCeDataAdapter adapt;
         
        public teamperformance()
        {
            InitializeComponent();
            DisplayData();
        }

        private void teamperformance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerDataSet.teamperformance' table. You can move, or remove it, as needed.
            this.teamperformanceTableAdapter.Fill(this.managerDataSet.teamperformance);
            
           
        }
        private void DisplayData()
        {
            
            DataTable dt = new DataTable();
            adapt = new SqlCeDataAdapter("select * from teamperformance", con);
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
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from teamperformance where Year='" + textBox11.Text + "'", con);
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = (dr["Matches_Played"].ToString());
                    textBox2.Text = (dr["Matches_Won"].ToString());
                    textBox3.Text = (dr["Matches_Lost"].ToString());
                    textBox4.Text = (dr["Matches_Drawn"].ToString());
                    textBox5.Text = (dr["Goals_Scored"].ToString());
                    textBox6.Text = (dr["Goals_Conceded"].ToString());
                    textBox7.Text = (dr["Yellow_Cards"].ToString());
                    textBox8.Text = (dr["Red_Cards"].ToString());
                    textBox9.Text = (dr["Tournaments_Participated"].ToString());
                    textBox10.Text = (dr["Tournaments_Won"].ToString());
                    textBox11.Text = (dr["Year"].ToString());
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
                    String Query = "update teamperformance set Year='" + this.textBox11.Text + "',Matches_Played='" + this.textBox1.Text + "',Matches_Won='" + this.textBox2.Text + "',Matches_Lost='" + this.textBox3.Text + "',Matches_Drawn='" + this.textBox4.Text + "',Goals_Scored='" + this.textBox5.Text + "',Goals_Conceded='" + this.textBox6.Text + "',Yellow_Cards='" + this.textBox7.Text + "',Red_Cards='" + this.textBox8.Text + "',Tournaments_Participated='" + this.textBox9.Text + "',Tournaments_Won='" + this.textBox10.Text + "' where Year='" + this.textBox11.Text + "';";
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
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                  try
                {
                    SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                    con.Open();

                    String sql = "INSERT INTO teamperformance(Year,Matches_Played,Matches_Won,Matches_Lost,Matches_Drawn,Goals_Scored,Goals_Conceded,Yellow_Cards,Red_Cards,Tournaments_Participated,Tournaments_Won) VALUES('" + textBox11.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                cmd = new SqlCeCommand("delete teamperformance where Year=@year", con);
                con.Open();
                cmd.Parameters.AddWithValue("@year", textBox11.Text);
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

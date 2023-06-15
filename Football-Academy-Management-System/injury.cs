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
    public partial class injury : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
        SqlCeCommand cmd;
        SqlCeDataAdapter adapt;
        public injury()
        {
            InitializeComponent();
            DisplayData();
        }

        private void injury_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerDataSet.injury' table. You can move, or remove it, as needed.
            this.injuryTableAdapter.Fill(this.managerDataSet.injury);

        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlCeDataAdapter("select * from injury", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox3.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                    con.Open();

                    String sql = "INSERT INTO injury(Player_Name,Injury_Type,Date_Injured,Duration) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "')";
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
                SqlCeCommand cmd = new SqlCeCommand("select * from injury where Player_Name='" + textBox1.Text + "'", con);
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = (dr["Player_Name"].ToString());
                    textBox2.Text = (dr["Injury_Type"].ToString());
                    dateTimePicker1.Text = (dr["Date_Injured"].ToString());
                    textBox3.Text = (dr["Duration"].ToString());

                }
                
                con.Close();
                
            }
            else
            {
                MessageBox.Show("Please enter player name to search for editing or delete...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                con.Open();
                String Query = "update injury set Player_Name='" + this.textBox1.Text + "',Injury_Type='" + this.textBox2.Text + "',Date_Injured='" + this.dateTimePicker1.Text + "',Duration='" + this.textBox3.Text + "' where Player_Name='" + this.textBox1.Text + "';";
                SqlCeCommand cmd = new SqlCeCommand(Query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details updated successfully...");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please enter player name then click on search to fetch details for update or view..");
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                cmd = new SqlCeCommand("delete injury where Player_Name=@name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Details deleted successfully...");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please enter player name to delete...");
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
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

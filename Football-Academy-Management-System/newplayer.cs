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
using System.Data.OleDb;

namespace Football_Academy_Management_System
{
    public partial class newplayer : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
        SqlCeCommand cmd;
        
        public newplayer()
        {
            InitializeComponent();
            DisplayData();

        }
        private void DisplayData()
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
            con.Open();
            DataTable dt = new DataTable();
            SqlCeDataAdapter adapt;
            adapt = new SqlCeDataAdapter("select * from player", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            /*OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=manager.accdb");
            con.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adapt;
            adapt = new OleDbDataAdapter("select * from player", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();*/
        }
        //Clear Data  
        private void ClearData()
        {
            reg_id.Text = "";
            firstname.Text = "";
            middlename.Text = "";
            lastname.Text = "";
            nickname.Text = "";
            gender.Text = "Select Gender";
            birthdate.Text = "";
            position.Text = "Select Position";
            role.Text = "";
            playermobile.Text = "";
            email.Text = "";
            playeraddress.Text = "";
            parentname.Text = "";
            parentmobile.Text = "";
            parentaddress.Text = "";
            playerimage.Text = "";
            passport.Image = passport.Image;
        }
        private void chooseimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialogS
                playerimage.Text = opf.FileName;
                passport.Image = Image.FromFile(opf.FileName);
                /*MemoryStream ms1 = new MemoryStream();
                passport.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                */
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            try
            {
              /* MemoryStream ms1 = new MemoryStream();
                passport.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img_arr1 = new byte[ms1.Length];
                ms1.Read(img_arr1, 0, img_arr1.Length);*/
                SqlCeConnection con = new SqlCeConnection(@"Data Source=" +System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                con.Open();

                String sql = "INSERT INTO player(Reg_ID,First_Name,Middle_Name,Last_Name,Nickname,Gender,Birthdate,Position,Player_Role,Player_Mobile,Email,Player_Address,Parent_Name,Parent_Mobile,Parent_Address,Passport) VALUES('" + reg_id.Text + "','" + firstname.Text + "','" + middlename.Text + "','" + lastname.Text + "','" + nickname.Text + "','" + gender.SelectedText + "','" + birthdate.Text + "','" + position.SelectedText + "','" + role.Text + "','" + playermobile.Text + "','" + email.Text + "','" + playeraddress.Text + "','" + parentname.Text + "','" + parentmobile.Text + "','" + parentaddress.Text + "','" + playerimage.Text + "')";
                SqlCeCommand cmd = new SqlCeCommand(sql, con);
                cmd.ExecuteNonQuery();
                /*String sql2 = "insert into player(Passport)Value('" + img_arr1 + "')";
                SqlCeCommand cmd2 = new SqlCeCommand(sql2, con);
                cmd2.ExecuteNonQuery();*/
                MessageBox.Show("Your data has been saved successfully.. ");

                DisplayData();
                ClearData();
                con.Close();/*
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=manager.accdb");
                OleDbCommand cmd = con.CreateCommand();
                con.Open();

                cmd.CommandText = "insert into player(Reg_ID,First_Name,Middle_Name,Last_Name,Nickname,Gender,Birthdate,Position,Player_Role,Player_Mobile,Email,Player_Address,Parent_Name,Parent_Mobile,Parent_Address) values('" + reg_id.Text + "','" + firstname.Text + "','" + middlename.Text + "','" + lastname.Text + "','" + nickname.Text + "','" + gender.SelectedText + "','" + birthdate.Text + "','" + position.SelectedText + "','" + role.Text + "','" + playermobile.Text + "','" + email.Text + "','" + playeraddress.Text + "','" + parentname.Text + "','" + parentmobile.Text + "','" + parentaddress.Text + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your data has been saved successfully.. ");

                DisplayData();
                con.Close();*/

            }
            catch(SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void newplayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'managerDataSet.player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.managerDataSet.player);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reg_id.Text != "")
            {
                SqlCeConnection con = new SqlCeConnection(@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("select * from player where Reg_ID='" + reg_id.Text + "'", con);
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    reg_id.Text = (dr["Reg_ID"].ToString());
                    firstname.Text = (dr["First_Name"].ToString());
                    middlename.Text = (dr["Middle_Name"].ToString());
                    lastname.Text = (dr["Last_Name"].ToString());
                    nickname.Text = (dr["Nickname"].ToString());
                    gender.Text = (dr["Gender"].ToString());
                    birthdate.Text = (dr["Birthdate"].ToString());
                    position.Text = (dr["Position"].ToString());
                    role.Text = (dr["Player_Role"].ToString());
                    playermobile.Text = (dr["Player_Mobile"].ToString());
                    email.Text = (dr["Email"].ToString());
                    playeraddress.Text = (dr["Player_Address"].ToString());
                    parentname.Text = (dr["Parent_Name"].ToString());
                    parentmobile.Text = (dr["Parent_Mobile"].ToString());
                    parentaddress.Text = (dr["Parent_Address"].ToString());
                    playerimage.Text = (dr["Passport"].ToString());
                   
                    
                }
                con.Close();

                if (playerimage.Text !="")
                {

                    passport.Image = Image.FromFile(playerimage.Text);
                   
                }
                else
                {
                    passport.Image = passport.Image;
                    MessageBox.Show("Can't find player passport, please upload another...");

                }
            }

                //}
            //SqlCeCommand cmd2 = new SqlCeCommand("select * from player where Reg_ID='" + reg_id.Text + "'", con);

             /*   try

            {



                SqlCeDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {

                    byte[] img_arr1 = (byte[])dr["Passport"];
                    MemoryStream ms1 = new MemoryStream(img_arr1);
                    ms1.Seek(0, SeekOrigin.Begin);
                    passport.Image = Image.FromStream(ms1);

                }

                else

                {

             MessageBox.Show("Your Data is not inserted in database try again");

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
               */

            else
            {
                MessageBox.Show("Please enter Reg_ID then click on search to display information for editing and updating...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reg_id.Text != "")
            {
                try
                {
                    String Connection2 = (@"Data Source=" + System.IO.Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "manager.sdf"));
                    String Query = "update player set Reg_ID='" + this.reg_id.Text + "',First_Name='" + this.firstname.Text + "',Middle_Name='" + this.middlename.Text + "',Last_Name='" + this.lastname.Text + "',Nickname='" + this.nickname.Text + "',Gender='" + this.gender.Text + "',Birthdate='" + this.birthdate.Text + "',Position='" + this.position.Text + "',Player_Role='" + this.role.Text + "',Player_Mobile='" + this.playermobile.Text + "',Email='" + this.email.Text + "',Player_Address='" + this.playeraddress.Text + "',Parent_Name='" + this.parentname.Text + "',Parent_Mobile='" + this.parentmobile.Text + "',Parent_Address='" + this.parentaddress.Text + "',Passport='" + this.playerimage.Text + "' where Reg_ID='" + this.reg_id.Text + "';";
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
                MessageBox.Show("Please enter Reg_ID then click on search to fetch details for update or view..");
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reg_id.Text != "")
            {
                cmd = new SqlCeCommand("delete player where Reg_ID=@reg", con);
                con.Open();
                cmd.Parameters.AddWithValue("@reg", reg_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Details deleted successfully...");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please enter Reg_ID to delete record...");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            reg_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            middlename.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            lastname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            nickname.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            gender.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            birthdate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            position.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            role.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            playermobile.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            email.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            playeraddress.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            parentname.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            parentmobile.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            parentaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            playerimage.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();

            if (playerimage.Text != "")
            {

                passport.Image = Image.FromFile(playerimage.Text);

            }
            else
            {
                passport.Image = passport.Image;
                MessageBox.Show("Can't find player passport, please upload another...");

            }

         }

        private void button4_Click(object sender, EventArgs e)
        { 
            /*printinfo pri = new printinfo();
            
            pri.Show();
            printinfo newMDIChild = new printinfo();
            newMDIChild.MdiParent = this.MdiParent;
            newMDIChild.Show();*/
            printinfo pri = new printinfo();
            pri.label29.Text = reg_id.Text.ToString();
            pri.label21.Text = firstname.Text.ToString();
            pri.label23.Text = middlename.Text.ToString();
            pri.label24.Text = lastname.Text.ToString();
            pri.label27.Text = nickname.Text.ToString();
            pri.label25.Text = gender.Text.ToString();
            pri.label22.Text = birthdate.Text.ToString();
            pri.label26.Text = position.Text.ToString();
            pri.label28.Text = role.Text.ToString();
            pri.label31.Text = playermobile.Text.ToString();
            pri.label30.Text = email.Text.ToString();
            pri.richTextBox1.Text = playeraddress.Text.ToString();
            pri.label19.Text = parentname.Text.ToString();
            pri.label20.Text = parentmobile.Text.ToString();
            pri.richTextBox2.Text = parentaddress.Text.ToString();
            if (playerimage.Text != "")
            {

                pri.pictureBox1.Image = Image.FromFile(playerimage.Text);

            }
            else
            {
                pri.pictureBox1.Image = passport.Image;
                MessageBox.Show("Can't find player passport to display...");

            }
            pri.MdiParent = this.MdiParent;
            pri.Show();
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

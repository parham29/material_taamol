
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taamol
{   
    class Managment
    {
        SqlCommand com;
        OrderedDictionary hshTable;
        Bunifu.Framework.UI.BunifuCustomDataGrid allmembersgrid;
        DataView dataView;
        int i = 0;
        int x = 22;
        int noofcontrols = 0;
        Label[] l1 = new Label[25];
        public Managment() {
            com = new SqlCommand();
            com.Connection = connect.conn();
            
        }
        
        public void addmember(MemberModel member,long price)
        {
            com.CommandText= "exec addmember @member_name,@member_family,@member_gender,@member_DOB,@member_meli_code,@member_address,@member_telephone,@member_registration_date,@member_expire_date,@member_mobile,@gym_id,@member_cost";
            //com = new SqlCommand("exec addmember @member_name,@member_family,@member_gender,@member_DOB,@member_meli_code,@member_address,@member_telephone,@member_registration_date,@member_expire_date,@member_mobile,@gym_id", connect.conn());
            com.Parameters.Clear();
            com.Parameters.Add("@member_name", SqlDbType.NVarChar, 50).Value = member.Name;
            com.Parameters.Add("@member_family", SqlDbType.NVarChar, 50).Value = member.Family;
            com.Parameters.Add("@member_gender", SqlDbType.Int, 4).Value = member.Gender;
            com.Parameters.Add("@member_DOB", SqlDbType.DateTime, 8).Value = member.DOB;
            com.Parameters.Add("@member_meli_code", SqlDbType.NVarChar, 10).Value = member.Melicode;
            com.Parameters.Add("@member_address", SqlDbType.NVarChar, 50).Value = member.Address;
            com.Parameters.Add("@member_telephone", SqlDbType.NVarChar, 11).Value = member.Phone;
            com.Parameters.Add("@member_registration_date", SqlDbType.NVarChar, 50).Value = member.Registration_date;
            com.Parameters.Add("@member_expire_date", SqlDbType.NVarChar, 50).Value = member.Expire_date;
            com.Parameters.Add("@member_mobile", SqlDbType.NVarChar, 11).Value = member.Mobile; 
            com.Parameters.Add("@gym_id", SqlDbType.Int, 4).Value = member.Gymid;
            com.Parameters.Add("@member_cost", SqlDbType.BigInt, 8).Value = price;
            

            try
            {
                if (com.Connection.State == ConnectionState.Closed)
                {
                    com.Connection.Open();

                }
                com.ExecuteNonQuery();
                //MessageBox.Show("hello world");
              /*  int n = (int)com.ExecuteScalar();
                if (n != -29)
                {
                

                }
                else
                {

                } */


            }
            catch (Exception)
            {

            }
            finally
            {
                com.Connection.Close();

            }

        }

        public void getgymsnames(ComboBox cmb, int managerid)
        {
            com.CommandText = "exec getgymsnames @manager_id";
            com.Parameters.Clear();
            com.Parameters.Add("@manager_id", SqlDbType.Int, 4).Value = managerid;
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter(com);
            da1.Fill(ds1);
            cmb.DataSource = ds1.Tables[0];
            cmb.ValueMember = ds1.Tables[0].Columns[0].ColumnName;
            cmb.DisplayMember = ds1.Tables[0].Columns[1].ColumnName;

        }
        public OrderedDictionary getgymsnamesAndid( int managerid,Panel panel)
        {
            hshTable = new OrderedDictionary();
            try
            {

                
                com.CommandText = "exec getgymsnames @manager_id";
                com.Parameters.Clear();
                com.Parameters.Add("@manager_id", SqlDbType.NVarChar, 50).Value = managerid;
                

                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    hshTable.Add(reader[1].ToString(), (int)reader[0]);
                    l1[i] = new Label();

                    l1[i].Location = new System.Drawing.Point(x, 0);
                    l1[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    l1[i].Text = reader[1].ToString();
                    l1[i].Click += new EventHandler(button_Click);
                    panel.Controls.Add(l1[i]);
                    panel.AutoSize = true;
                    panel.Show();
                    panel.Refresh();

                    i++;
                    x = x + 200;
                    noofcontrols++;



                }
                //dataGridView1.DataSource = sequence;
            }
            finally
            {
                com.Connection.Close();

            }
            return hshTable;

        }

        public MemberModel extendData(int member_id,int gym_id) {
            MemberModel member = new MemberModel();

            try
            {
                
                //ArrayList sequence = new ArrayList();
                com.CommandText = "exec getMemberExtentionData @member_id, @gym_id";
                com.Parameters.Clear();
                com.Parameters.Add("@member_id", SqlDbType.NVarChar, 50).Value = member_id;
                com.Parameters.Add("@gym_id", SqlDbType.NVarChar, 50).Value = gym_id;
                
                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    
                    member.Member_id = (int)reader[0];
                    member.Name = reader[1].ToString();
                    member.Family = reader[2].ToString();
                    member.Gender = (int)reader[3];
                    member.Melicode = reader[4].ToString();
                    member.Gymid = (int)reader[5];
                    member.Gym_name= reader[6].ToString();

                }
                //dataGridView1.DataSource = sequence;
            }
            finally
            {
                com.Connection.Close();
                
            }
            return member;



        }

        public void readAllmembers(int gym_id,Bunifu.Framework.UI.BunifuCustomDataGrid grid) {
           
            allmembersgrid = grid;
            try
            {
                
                //ArrayList sequence = new ArrayList();
                com.CommandText = "exec readAllMembers @gym_id";
                com.Parameters.Clear();
                com.Parameters.Add("@gym_id", SqlDbType.NVarChar, 50).Value = gym_id;
             
                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                
                var dataTable = new DataTable();
                dataTable.Load(reader);
                dataView = new DataView(dataTable);
                grid.DataSource = dataView;
                grid.Columns[11].Visible = false;
                grid.Columns[10].Visible = false;
                

            }
            finally
            {
                com.Connection.Close();

            }

            


        }
        protected void button_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            readAllmembers((int)hshTable[label.Text.ToString()], allmembersgrid);
            
            
        }
        public DataView DView
        {
            get { return dataView; }
            set { dataView = value; }
        }


    }
}

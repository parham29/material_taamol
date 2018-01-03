
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        Bunifu.Framework.UI.BunifuSeparator line_member;
        Bunifu.Framework.UI.BunifuTextbox txt_search;
        DataView dataView;
        int i = 0;
        int x = 22;
        int noofcontrols = 0;
        Label[] l1 = new Label[25];
        private static Managment instance;
        private Managment() {
            com = new SqlCommand();
            com.Connection = connect.conn();
            
        }

        public static Managment getInstance() {

           

                if (instance == null) {
                    instance = new Managment();

                }
                return instance;
            
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
        public OrderedDictionary getgymsnamesAndid( int managerid,Panel panel, Bunifu.Framework.UI.BunifuSeparator memeber_line, Bunifu.Framework.UI.BunifuTextbox txt_search)
        {
            hshTable = new OrderedDictionary();
            this.line_member = memeber_line;
            this.txt_search = txt_search;
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
                    l1[i].AutoSize = true;
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



        public MemberModel geteditData(int member_id)
        {
            MemberModel member = new MemberModel();

            try
            {

                //ArrayList sequence = new ArrayList();
                com.CommandText = "exec GetMemberData @member_id";
                com.Parameters.Clear();
                com.Parameters.Add("@member_id", SqlDbType.Int, 4).Value = member_id;
              

                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {

                    
                    member.Name = reader[1].ToString();
                    member.Family = reader[2].ToString();
                    member.Gender = (int)reader[3];
                    member.Melicode = reader[4].ToString();
                    member.Address = reader[5].ToString();
                    member.Phone = reader[6].ToString();
                    member.Mobile = reader[7].ToString();

                }
                //dataGridView1.DataSource = sequence;
            }
            finally
            {
                com.Connection.Close();

            }
            return member;



        }

        public void EditMember(int member_id, string member_name, string member_family, int member_gender, string member_address, string member_telephone, string member_mobile) {
            com.CommandText = "exec EditMember @member_id, @member_name, @member_family,@member_gender, @member_address, @member_telephone,@member_mobile";

            com.Parameters.Clear();
            com.Parameters.Add("@member_id", SqlDbType.Int, 4).Value = member_id;
            com.Parameters.Add("@member_name", SqlDbType.NVarChar, 50).Value = member_name;
            com.Parameters.Add("@member_family", SqlDbType.NVarChar, 50).Value = member_family;
            com.Parameters.Add("@member_gender", SqlDbType.Int, 4).Value = member_gender;
            com.Parameters.Add("@member_address", SqlDbType.NVarChar, 50).Value = member_address;
            com.Parameters.Add("@member_telephone", SqlDbType.NVarChar, 50).Value = member_telephone;
            com.Parameters.Add("@member_mobile", SqlDbType.NVarChar, 50).Value = member_mobile;






            try
            {
                if (com.Connection.State == ConnectionState.Closed)
                {
                    com.Connection.Open();

                }
                com.ExecuteNonQuery();


            }
            catch (Exception)
            {

            }
            finally
            {
                com.Connection.Close();

            }
        }
















        public void extendmember(int member_id,int gym_id, Int64 member_cost, int period_time) {


            com.CommandText = "exec extendMember @member_id,@gym_id,@member_cost,@period_time";
            //com = new SqlCommand("exec addmember @member_name,@member_family,@member_gender,@member_DOB,@member_meli_code,@member_address,@member_telephone,@member_registration_date,@member_expire_date,@member_mobile,@gym_id", connect.conn());
            com.Parameters.Clear();
           
            com.Parameters.Add("@member_id", SqlDbType.Int, 4).Value = member_id;
            com.Parameters.Add("@gym_id", SqlDbType.Int, 4).Value = gym_id;
            com.Parameters.Add("@member_cost", SqlDbType.BigInt, 8).Value = member_cost;
            com.Parameters.Add("@period_time", SqlDbType.Int, 4).Value = period_time;
            


            try
            {
                if (com.Connection.State == ConnectionState.Closed)
                {
                    com.Connection.Open();

                }
                com.ExecuteNonQuery();


            }
            catch (Exception)
            {

            }
            finally
            {
                com.Connection.Close();

            }

        }
        public managerModel getManagerName(int manager_id) {

            managerModel manager = new managerModel();

            try
            {

               
                com.CommandText = "exec getGymsOfManager @manager_id";
                com.Parameters.Clear();
                com.Parameters.Add("@manager_id", SqlDbType.Int, 4).Value = manager_id;


                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {

                    manager.Name = reader[5].ToString();
                    manager.Family = reader[6].ToString();
                    



                }
                
            }
            finally
            {
                com.Connection.Close();

            }

            return manager;

        }



        public void readAllmembers(int gym_id,Bunifu.Framework.UI.BunifuCustomDataGrid grid) {
           
            allmembersgrid = grid;
            try
            {
                
                
                com.CommandText = "exec readAllMembers @gym_id";
                com.Parameters.Clear();
                com.Parameters.Add("@gym_id", SqlDbType.NVarChar, 50).Value = gym_id;
             
                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                
                var dataTable = new DataTable();
                
                dataTable.Load(reader);
                dataTable.Columns.Add("monghazi", typeof(string));
                dataView = new DataView(dataTable);
                
                grid.DataSource = dataView;
                grid.Columns[11].Visible = false;
                grid.Columns[10].Visible = false;
                grid.Columns[7].Visible = false;
                
                grid.Columns[0].HeaderText = "name";
                grid.Columns[1].HeaderText = "family";
                grid.Columns[2].HeaderText = "gender";
                grid.Columns[3].HeaderText = "DOB";
                grid.Columns[4].HeaderText = "melli code";
                grid.Columns[5].HeaderText = "address";
                grid.Columns[6].HeaderText = "telephone";
                 
             
                    line_member.Width = l1[0].Width;
                    line_member.Left = l1[0].Left;
               
                for (int i = 0; i<grid.RowCount-1; i++) {
                   
                            
                  System.TimeSpan diffResult = (DateTime)grid.Rows[i].Cells[8].Value - (DateTime)DateTime.Now  ;
                    
                    String s =diffResult.Days>0?"valid":"invalid";
                    
                    grid.Rows[i].Cells[12].Value = s;
                    
                   
                }
                



            }
            finally
            {
                com.Connection.Close();

            }

            


        }

        public void getFinancials(int manager_id,int type, Bunifu.Framework.UI.BunifuCustomDataGrid grid) {


            
            try
            {


                com.CommandText = "exec getFinancialsOfmanager @manager_id,@financialtype";
                com.Parameters.Clear();
                com.Parameters.Add("@manager_id", SqlDbType.Int, 4).Value = manager_id;
                com.Parameters.Add("@financialtype", SqlDbType.Int, 4).Value = type;

                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();

                var dataTable = new DataTable();

                dataTable.Load(reader);
               
                dataView = new DataView(dataTable);

                grid.DataSource = dataView;
               


                




            }
            finally
            {
                com.Connection.Close();

            }
        }
        public void deletMember(int member_id,int gym_id) {
            com.CommandText = "exec deleteMemeber @member_id,@gym_id";

            
            com.Parameters.Clear();
            com.Parameters.Add("@member_id", SqlDbType.Int, 4).Value = member_id;
            com.Parameters.Add("@gym_id", SqlDbType.Int, 4).Value = gym_id;



            try
            {
                if (com.Connection.State == ConnectionState.Closed)
                {
                    com.Connection.Open();

                }
                com.ExecuteNonQuery();


            }
            catch (Exception)
            {

            }
            finally
            {
                com.Connection.Close();

            }
        }
        protected void button_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            txt_search.text = "";
            readAllmembers((int)hshTable[label.Text.ToString()], allmembersgrid);
            line_member.Width = label.Width;
            line_member.Left = label.Left;


        }

        public void refreshmembersgrid(int gym_id) {

            readAllmembers(gym_id, allmembersgrid);
        }
        public DataView DView
        {
            get { return dataView; }
            set { dataView = value; }
        }


    }
}

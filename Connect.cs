using System;
using System.Data.SqlClient;

public class connect
{
    public SqlConnection conn() {

        SqlConnection conn = new SqlConnection("server=.\\PTSSQLSERVER; database = Gyms_Managment; uid = fapzadmin; pwd = 13243546");
        return conn;
    }
}

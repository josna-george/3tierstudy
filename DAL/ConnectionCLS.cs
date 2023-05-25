using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionCLS

    {
        SqlConnection con;
        SqlCommand cmd;
        public ConnectionCLS()
        {
            con = new SqlConnection(@"server=DESKTOP-VCFINVS\MSSQLSERVER01 ;database=Test;Integrated Security=true;");
        }
        public int Fn_NonQuery(string sqlquery)
        {
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public string Fn_Scalar(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
        public SqlDataReader Fn_Reader(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            cmd = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet Fn_DataSet(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            return (dt);
        }
        


    

    }
}


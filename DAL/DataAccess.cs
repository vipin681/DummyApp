using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace DAL
{
   public  class DataAccess
    {
        private readonly string _Connection = string.Empty;
        public DataAccess()
        {
            _Connection = WebConfigurationManager.AppSettings["constr"].ToString();

        }
        public DataTable DataSet(string SPname)
        {
            SqlConnection con = new SqlConnection(_Connection);
            SqlDataAdapter da = new SqlDataAdapter(SPname, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ExecuteNonQuery(string SPname, params SqlParameter[] sqlparam)
        {
            SqlConnection con = new SqlConnection(_Connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = SPname;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(sqlparam);

            int check;
            con.Open();
            check = cmd.ExecuteNonQuery();
            con.Close();

            return check;


        }
        public DataTable data(string SPname, params SqlParameter[] sqlparam)
        {
            SqlConnection con = new SqlConnection(_Connection);
            SqlCommand cmd = new SqlCommand(SPname, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(sqlparam);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

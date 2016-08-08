using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data.SqlClient;

namespace BAL
{
   public class UserBLL
    {
        DataAccess dam = new DataAccess();
        public int AddUser(UserBLL entUser)
        {
            SqlParameter[] sqlparam = new SqlParameter[8];
            sqlparam[0] = new SqlParameter();
            sqlparam[1] = new SqlParameter();
            sqlparam[2] = new SqlParameter();
            sqlparam[3] = new SqlParameter();
            sqlparam[4] = new SqlParameter();
            sqlparam[5] = new SqlParameter();
            sqlparam[6] = new SqlParameter();
            sqlparam[7] = new SqlParameter();
            return dam.ExecuteNonQuery("", sqlparam);
        }
    }
}

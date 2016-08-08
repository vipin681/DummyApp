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
        public int AddUser(User entUser)
        {
            SqlParameter[] sqlparam = new SqlParameter[7];
            sqlparam[0] = new SqlParameter("@paramFirstName",entUser.FirstName);
            sqlparam[1] = new SqlParameter("@paramLastName",entUser.LastName);
            sqlparam[2] = new SqlParameter("@paramPhone",entUser.Phone);
            sqlparam[3] = new SqlParameter("@paramemail",entUser.email);
            sqlparam[4] = new SqlParameter("@paramPassword",entUser.Password);
            sqlparam[5] = new SqlParameter("@paramRole",entUser.Role);
            sqlparam[6] = new SqlParameter("@paramIsActive",entUser.IsActive);
           return dam.ExecuteNonQuery("Sp_InsertUpdateUserDetail", sqlparam);
        }

      
    }
}

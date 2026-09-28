using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace product_management_system.BL
{
    class CLS_LOGIN
    {
        public DataTable login(String ID, String PWD)
         {
             DAL.Data_access_layer dal = new DAL.Data_access_layer();
             SqlParameter[] param = new SqlParameter[2];
            param[0]=new SqlParameter("@ID",SqlDbType.VarChar,50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

           
            DataTable dt = new DataTable();
            dt = dal.selectData("ST_LOGIN", param);
            dal.close();
            return dt;


         }// login_method

    } //end of CLS_LOGIN


} // end of namespace 

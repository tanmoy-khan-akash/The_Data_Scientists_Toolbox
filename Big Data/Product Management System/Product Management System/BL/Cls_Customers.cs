using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace product_management_system.BL
{
    class Cls_Customers
    {
        public void ADD_CUSTOMER(string name, string tel, string address, string fbAccount)
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@tel", SqlDbType.NVarChar, 50);
            param[1].Value = tel;

            param[2] = new SqlParameter("@address", SqlDbType.NVarChar,50);
            param[2].Value = address;

            param[3] = new SqlParameter("@fbaccount", SqlDbType.NVarChar, 50);
            param[3].Value = fbAccount;

            dal.executecommand("ADD_CUSTOMER", param);
            dal.close();
        }
        public void EDIT_CUSTOMER(string name, string tel, string address, string fbAccount, int id)
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@tel", SqlDbType.NVarChar, 50);
            param[1].Value = tel;

            param[2] = new SqlParameter("@address", SqlDbType.NVarChar, 50);
            param[2].Value = address;

            param[3] = new SqlParameter("@fbaccount", SqlDbType.NVarChar, 50);
            param[3].Value = fbAccount;

            param[4] = new SqlParameter("@id", SqlDbType.Int);
            param[4].Value = id;

            dal.executecommand("EDIT_CUSTOMER", param);
            dal.close();
        }
        public void DELETE_CUSTOMER(int id)
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dal.executecommand("DELETE_CUSTOMER", param);
            dal.close();
        }
        public DataTable get_all_customers()
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();

            DataTable dt = new DataTable();
            dt = dal.selectData("get_all_customers", null);
            dal.close();
            return dt;
        }
        public DataTable search_customer(string word)
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@word", SqlDbType.NVarChar, 50);
            param[0].Value = word;
            dt = dal.selectData("search_customer", param);
            dal.close();
            return dt;


        }
    }
}

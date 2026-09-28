using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace product_management_system.BL
{
    class Cls_product
    {
        public DataTable GET_all_categories()
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();
           
            DataTable dt = new DataTable();
            dt = dal.selectData("GET_all_categories",null);
            dal.close();
            return dt;


        }// login_method

        public void add_product(string product_id , string label ,int quantity , string prices,byte [] image,int cat_id)
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@product_id", SqlDbType.NVarChar,50);
            param[0].Value = product_id;
            param[1] = new SqlParameter("@label", SqlDbType.NVarChar,50);
            param[1].Value = label;

            param[2] = new SqlParameter("@quantity", SqlDbType.Int);
            param[2].Value = quantity;

            param[3] = new SqlParameter("@prices", SqlDbType.NVarChar, 50);
            param[3].Value = prices;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = image;

            param[5] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[5].Value = cat_id;

            dal.executecommand("add_new_product", param);
            dal.close();
        }

        public void update_product(string product_id, string label, int quantity, string prices, byte[] image, int cat_id)
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@product_id", SqlDbType.NVarChar, 50);
            param[0].Value = product_id;
            param[1] = new SqlParameter("@label", SqlDbType.NVarChar, 50);
            param[1].Value = label;

            param[2] = new SqlParameter("@quantity", SqlDbType.Int);
            param[2].Value = quantity;

            param[3] = new SqlParameter("@prices", SqlDbType.NVarChar, 50);
            param[3].Value = prices;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = image;

            param[5] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[5].Value = cat_id;

            dal.executecommand("update_product", param);
            dal.close();
        }// end update_product


        public DataTable verify_product(string id)
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();

            DataTable dt = new DataTable();
            SqlParameter [] param =new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[0].Value = id;

            dt = dal.selectData("varify_product", param);
            dal.close();
            return dt;


        }// end of verify_product

        public DataTable GET_all_product_info()
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();

            DataTable dt = new DataTable();
            dt = dal.selectData("GET_all_product_info", null);
            dal.close();
            return dt;


        }// end GET_all_product_info

        public DataTable search_product(string search)
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 50);
            param[0].Value = search;

            dt = dal.selectData("search_product", param);
            dal.close();
            return dt;
        }//end search

        public void delete_product(string id)
        {
             DAL.Data_access_layer dal = new DAL.Data_access_layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            dal.executecommand("delete_product", param);
            dal.close();
        }//end delete_product


        public DataTable get_image(string id)
        {
            DAL.Data_access_layer dal = new DAL.Data_access_layer();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            dt = dal.selectData("get_image", param);
            dal.close();
            return dt;
        }//end search

    }
}

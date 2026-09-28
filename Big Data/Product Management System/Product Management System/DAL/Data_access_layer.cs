using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    /// han ana b3ml el library de 3lashan 2der akon client 3la sql 
using System.Data;

namespace product_management_system.DAL
{
    class Data_access_layer
    {
        SqlConnection sql_con;



        public Data_access_layer()   //this constracter initialize connection object
        {
            sql_con= new SqlConnection(@"Server =.\SQLEXPRESS; Database =product_DB; Integrated Security =true") ;

        }// end of constructor



        public void open()  // method to open the connection
        {
            if (sql_con.State != ConnectionState.Open)
            {
                sql_con.Open();
            }// end if
        }// end _open _method



        public void close() // method to close the connection
        {
            if (sql_con.State == ConnectionState.Open)
            {
                sql_con.Close();
            }// end if
        }// end _close _method

        public DataTable selectData (String storage_procedure , SqlParameter [] param) // method to read data from database 
        {
            SqlCommand sqlcomm =new SqlCommand();
            sqlcomm.CommandType=CommandType.StoredProcedure;
            sqlcomm.CommandText=storage_procedure;
            sqlcomm.Connection = sql_con;
            if(param !=null )
            {
              for (int i = 0; i < param.Length; i++)
                {
                    sqlcomm.Parameters.Add(param[i]);
                }// end_of_fo
               
            }// end of if
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable DT = new DataTable();
            sda.Fill(DT);
            return DT;

        }// end_of_selectData


        public void executecommand(string storage_procedure, SqlParameter[] param) // method to insert,update and delete data from database
        { 
            SqlCommand sqlcomm =new SqlCommand();
            sqlcomm.CommandType=CommandType.StoredProcedure;
            sqlcomm.CommandText=storage_procedure; // write command in it
            sqlcomm.Connection = sql_con;
            if (param != null)
            {
                sqlcomm.Parameters.AddRange(param);

            }// end_of_if

            sqlcomm.ExecuteNonQuery(); // didnt return anything 

        }// end _of_executecommand



    }// end _of_ Data_access_layer
}// end _namespace

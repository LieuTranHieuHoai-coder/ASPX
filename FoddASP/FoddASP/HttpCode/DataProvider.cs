using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace FoddASP.HttpCode
{
    public class DataProvider
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B1PJQ57\HIEUHOAI;Initial Catalog=Rau;Integrated Security=True");
        public static void Connect()
        {
            if (ConnectionState.Broken == conn.State || ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
        }

        public static bool executeNonQuery(string sQuery,SqlParameter[] sParams)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sQuery, conn);
                cmd.Parameters.AddRange(sParams);
                
                if(cmd.ExecuteNonQuery()>0)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
                
            }
            catch (Exception)
            {
                return false;
                //throw;
            }
        }

        //lấy về id tang tụ đông

        public static int executeScalar(string sQuery , SqlParameter[] sParams)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sQuery, conn);
                cmd.Parameters.AddRange(sParams);
                cmd.ExecuteNonQuery();
                sQuery = "Select * @@identity";
                cmd =new SqlCommand(sQuery, conn);
                int id = (int)cmd.ExecuteScalar();
                conn.Close();
                return id;
            }
            catch (Exception err)
            {
                
                throw;
            }
            
        }
        //Lấy table thông thường 
        public static DataTable getDataTable(string sQuery/*, SqlParameter[] sParams*/)
        {
           
           
            try
            {

                Connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sQuery,conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception err)
            {

                return null;
            }
           
        }
        //Lấy table kiểu có param 
        public static DataTable getDataTable_Param(string sQuery, SqlParameter[] sParams)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {

                Connect();
                cmd.CommandText = sQuery;
                cmd.Parameters.AddRange(sParams);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();

            }
            catch (Exception err)
            {

                return null;
            }
            return dt;
        }



        public static bool KTTK(string sQuery)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sQuery, conn);
                DataTable dt = new DataTable();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
                
            }
            catch (Exception)
            {
                return false;
                //throw;
            }

          
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Revolution_
{
    public class DataAccess
    {

        private static String myConnectionString;

        public DataAccess()
        {
            myConnectionString = WebConfigurationManager.ConnectionStrings["BookExchangeConnectionString"].ConnectionString;
        }

        public static DataTable selectQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                myConnectionString = WebConfigurationManager.ConnectionStrings["BookExchangeConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(myConnectionString);
                conn.Open();
                SqlCommand com = new SqlCommand(query, conn);
                dt.Load(com.ExecuteReader());
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

    }
}
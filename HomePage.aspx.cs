using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Revolution_
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BookExchangeConnectionString"].ConnectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandType = CommandType.Text;
                com.CommandText = "select * from Product";
                conn.Open();

                SqlDataReader reader = com.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    do
                    {
                        lblDisplay.Text += "<table>";
                        lblDisplay.Text += "<tr>";
                        lblDisplay.Text += "<td><img src='App_images\\" + reader["Image"] + "'width='30%' height='30%'/>" + "</td>";
                        lblDisplay.Text += "<td>";
                        lblDisplay.Text += "</tr>";
                        lblDisplay.Text += "<tr>";
                        lblDisplay.Text += "<B>Name: </B>" + reader["Product_Name"] + "<br/>";
                        lblDisplay.Text += "<B>Price: </B>" + reader["Price"] + "<br/>";
                        lblDisplay.Text += "<a href=ProductDetails.aspx?id=" + reader["productId"] + ">" + "More Info" + "</a>" + "<br/>";
                        lblDisplay.Text += "</td>";
                        lblDisplay.Text += "</tr>";
                        lblDisplay.Text += "</table>";
                    } while (reader.Read());
                    
                }
                conn.Close();
                conn.Dispose();
                com.Dispose();
                
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
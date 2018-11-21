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
    public partial class ProductDetails : System.Web.UI.Page 
    {
        Cart myCart;
        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Request.QueryString["id"];
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BookExchangeConnectionString"].ConnectionString);
            conn.Open();
            String query = "Select * from Product where productId ='" + id + "'";
            SqlCommand com = new SqlCommand(query, conn);

            com.CommandType = CommandType.Text;
            SqlDataReader reader = com.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                lblDisplay.Text += "<table>";
                lblDisplay.Text += "<tr>";
                lblDisplay.Text += "<td><img src='App_images\\" + reader["Image"] + "'width='30%' height='30%'/>" + "</td>";
                lblDisplay.Text += "<td>";
                lblDisplay.Text += "</tr>";
                lblDisplay.Text += "<tr>";
                lblDisplay.Text += "<B>Name: </B>" + reader["Product_Name"] + "<br/>";
                lblDisplay.Text += "<B>Price: </B>" + reader["Price"] + "<br/>";
                lblDisplay.Text += "<B>Quantity: </B>" + reader["Quantity"] + "<br/>";
                lblDisplay.Text += btnAdd + "<br/>";
                lblDisplay.Text += "</td>";
                lblDisplay.Text += "</tr>";
                lblDisplay.Text += "</table>";
            }
            conn.Close();
            conn.Dispose();
            com.Dispose();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if(Session["myCart"] == null)
            {
                myCart = new Cart();
                Session["myCart"] = myCart;
            }
            string ID = Request.QueryString["id"];
            myCart = (Cart)Session["myCart"];
            DataTable dt = DataAccess.selectQuery("Select * from Product where productId = " + ID);
            DataRow dr = dt.Rows[0];
            myCart.insert(new BookItem(Int32.Parse(ID), dr["ISBN"].ToString(), dr["Product_Name"].ToString(), double.Parse(dr["Price"].ToString()), 1, dr["Image"].ToString()));
            Response.Redirect("ShoppingCart.aspx");
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Revolution_
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        private void GetImage()
        {
            if(upload.HasFile)
            {
               upload.PostedFile.SaveAs(Server.MapPath("App_images") + "\\" + upload.FileName);
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BookExchangeConnectionString"].ConnectionString);
                conn.Open();
                
                String add = "insert into Product(ISBN,Product_Name,Price,Quantity,Image,Userid) values(@ISBN,@Product_Name,@Price,@Quantity,@Image,10)";
                SqlCommand com = new SqlCommand(add, conn);

                com.Parameters.AddWithValue("@ISBN", txtISBN.Value);
                com.Parameters.AddWithValue("@Product_Name", txtProductName.Value);
                com.Parameters.AddWithValue("@Price", txtPrice.Value);
                com.Parameters.AddWithValue("@Quantity", txtQuantity.Value);
                com.Parameters.AddWithValue("@Image", upload.FileName);

                GetImage();
                com.ExecuteNonQuery();
                MessageBox.Show(upload.FileName);
                Response.Redirect("HomePage.aspx");

                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
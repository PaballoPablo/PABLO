using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using Privacy;

namespace Revolution_
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BookExchangeConnectionString"].ConnectionString);
                conn.Open();
                String insert = "insert into USERS(Fname,LName,Title,Email,Username,Password,Admin) values(@Fname,@LName,@Title,@Email,@Username,@Password,0)";
                SqlCommand com = new SqlCommand(insert, conn);

                com.Parameters.AddWithValue("@Fname", txtFirstName.Value);
                com.Parameters.AddWithValue("@LName", txtLastName.Value);
                com.Parameters.AddWithValue("@Title", txtTitle.Value);
                com.Parameters.AddWithValue("@Email", txtEmail.Value);
                com.Parameters.AddWithValue("@Username", txtUsername.Value);
                com.Parameters.AddWithValue("@Password", txtPassword.Value);

                com.ExecuteNonQuery();
                Response.Redirect("HomePage.aspx");
                MessageBox.Show("Home");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
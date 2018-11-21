using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Privacy;

namespace Revolution_
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["BookExchangeConnectionString"].ConnectionString);
            conn.Open();
            String CheckUser = "select count(*) from USERS where Username='" + txtUsername.Value + "'";
            SqlCommand userCom = new SqlCommand(CheckUser, conn);
            int temp = Convert.ToInt32(userCom.ExecuteScalar().ToString());
            conn.Close();
            if(temp == 1)
            {
                conn.Open();
                String CheckPass = "select Password from USERS where Username='" + txtUsername.Value + "'";
                SqlCommand passCom = new SqlCommand(CheckPass, conn);
                String pass = passCom.ExecuteScalar().ToString();
                if(pass == txtPassword.Value)
                {
                    Session["New"] = txtUsername.Value;
                    Response.Redirect("HomePage.aspx");
                    conn.Close();
                }
            }
        }
    }
}
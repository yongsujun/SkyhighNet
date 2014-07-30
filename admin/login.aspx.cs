using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_Default : System.Web.UI.Page
{

    private string cnStr = ConfigurationManager.ConnectionStrings["SkyhighConnectionString"].ConnectionString;
    private sqlComm sqlCmm = new sqlComm();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["state"] == "logout")
        {
            Session["login"] = null;
            //Response.Redirect("/Default.aspx");
        }
    }

    protected void SubmitForm(object sender, EventArgs e)
    {
        string query = "SELECT COUNT(*) FROM staffs WHERE S_UserID = @UserName and S_Pwd = @UserPwd";

        using (SqlConnection conn = new SqlConnection(cnStr))
        {

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("UserName", txtLoginID.Text);
                cmd.Parameters.AddWithValue("UserPwd", sqlCmm.Encryptdata(txtLoginPwd.Text));

                conn.Open();

                if ((int)cmd.ExecuteScalar() > 0)
                {
                    
                    Session["login"] = txtLoginID.Text;
                    Response.Redirect("/Default.aspx");
                }
                else
                {
                    lblLoginError.Text = "Login error";
                }

            }

        }
    }
}
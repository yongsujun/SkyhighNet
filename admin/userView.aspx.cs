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

    protected void Page_Load(object sender, EventArgs e)
    {
        ///////////////////////////////////////////////////
        ///Getting submenu////////////////////////////////

        subMenu sm = new subMenu();
        lbladminMenu.Text = sm.getMenu("admin");

        ////////////////////////////////////////////////////

        using (SqlConnection con = new SqlConnection(cnStr))
        {
            con.Open();
            //con.InfoMessage += new SqlInfoMessageEventHandler(con_InfoMessage);
            SqlDataReader dr;
            string sql = "SELECT [S_ID],[S_UserID], [S_FirstName], [S_LastName], [S_Role], [S_Address1], [S_Address2], [S_Contact], [S_Email] FROM [Staffs] where S_ID ='" + Request.QueryString["id"] + "'";
            using (SqlCommand com = new SqlCommand(sql, con))
            {
                dr = com.ExecuteReader();
            }
            
            if (dr.Read())
            {
                lblUserID.Text = dr["S_UserID"].ToString();
                lblFullName.Text = dr["S_FirstName"].ToString() + " " + dr["S_LastName"].ToString();
                lblRole.Text = sm.getRole(Int32.Parse(dr["S_Role"].ToString()));
                lblAdd1.Text = dr["S_Address1"].ToString();
                lblAdd2.Text = dr["S_Address2"].ToString();
                lblContact.Text = dr["S_Contact"].ToString();
                lblEmail.Text = dr["S_Email"].ToString();
                lblSID.Text = dr["S_ID"].ToString();
            }
            con.Close();
        }

    }

    
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("/admin/addNew.aspx?id=" + Request.QueryString["id"] + 
            "&page=" + Request.QueryString["page"]);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("/admin/userList.aspx?page=" + Request.QueryString["page"]);
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("/admin/delete.aspx?id=" + Request.QueryString["id"] +
            "&page=" + Request.QueryString["page"] + "&table=Staffs");
    }
    /*
    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        string message = "Message from server side";
        ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + message + "');", true);
    }
    protected void btnDelete_Click2(object sender, EventArgs e)
    {

    }*/
}
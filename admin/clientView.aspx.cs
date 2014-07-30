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
            string sql = "SELECT [C_ID],[C_Company], [C_FirstName], [C_LastName], [C_Add1], [C_Add2], [C_Tel], [C_Fax], [C_Mobile], [C_Email] FROM [Clients] where C_ID ='" + Request.QueryString["id"] + "'";
            using (SqlCommand com = new SqlCommand(sql, con))
            {
                dr = com.ExecuteReader();
            }
            
            if (dr.Read())
            {
                lblClientID.Text = dr["C_ID"].ToString();
                lblCompany.Text = dr["C_Company"].ToString();
                lblFullName.Text = dr["C_FirstName"].ToString() + " " + dr["C_LastName"].ToString();
                lblAdd1.Text = dr["C_Add1"].ToString();
                lblAdd2.Text = dr["C_Add2"].ToString();
                lblContact.Text = "T) " + dr["C_Tel"].ToString() + "    F) " + dr["C_Fax"].ToString()
                     + "    M) " + dr["C_Mobile"].ToString();
                lblEmail.Text = dr["C_Email"].ToString();
               
            }
            con.Close();
        }

    }

    
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("/admin/clientAdd.aspx?id=" + Request.QueryString["id"] + 
            "&page=" + Request.QueryString["page"]);
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("/admin/clientList.aspx?page=" + Request.QueryString["page"]);
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("/admin/delete.aspx?id=" + Request.QueryString["id"] +
            "&page=" + Request.QueryString["page"] + "&table=Clients");
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
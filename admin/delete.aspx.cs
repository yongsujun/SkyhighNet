using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["table"] == "Staffs")
        {
            lbltitle.Text = "<h4 class='panel-title'>User Delete</h4>";
            hfTable.Value = Request.QueryString["table"];
            hfField.Value = "S_ID";
            hfReturn.Value = "/admin/userView.aspx?id=" + Request.QueryString["id"] +
            "&page=" + Request.QueryString["page"];
            hfReturn1.Value = "/admin/userList.aspx?page=" + Request.QueryString["page"];
        }
        else if (Request.QueryString["table"] == "Clients")
        {
            lbltitle.Text = "<h4 class='panel-title'>Clients Delete</h4>";
            hfTable.Value = Request.QueryString["table"];
            hfField.Value = "C_ID";
            hfReturn.Value = "/admin/clientView.aspx?id=" + Request.QueryString["id"] +
            "&page=" + Request.QueryString["page"];
            hfReturn1.Value = "/admin/clientList.aspx?page=" + Request.QueryString["page"];
        }
        
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        sqlComm sqCmm = new sqlComm();
        string cnStr = ConfigurationManager.ConnectionStrings["SkyhighConnectionString"].ConnectionString;
        sqCmm.OpenConnection(cnStr);
        sqCmm.DeleteRecord(Int32.Parse(Request.QueryString["id"]), hfTable.Value, hfField.Value);
        sqCmm.CloseConnection();
        Response.Redirect(hfReturn1.Value);
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect(hfReturn.Value);
    }
}
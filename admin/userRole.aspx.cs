using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ///////////////////////////////////////////////////
        ///Getting submenu////////////////////////////////

        subMenu sm = new subMenu();
        lbladminMenu.Text = sm.getMenu("admin");

        ////////////////////////////////////////////////////
        if (IsPostBack)
        {
            if (hfIndex.Value != "")
            {
                sqlComm sqCmm = new sqlComm();
                string cnStr = ConfigurationManager.ConnectionStrings["SkyhighConnectionString"].ConnectionString;
                sqCmm.OpenConnection(cnStr);
                sqCmm.DeleteRole(Int32.Parse(hfIndex.Value));
                sqCmm.CloseConnection();
                Response.Redirect("/admin/userRole.aspx");
            }
        }
    }

    
    protected void roleDelete()
    {
        if (hfIndex.Value != "" & IsPostBack)
        {
            sqlComm sqCmm = new sqlComm();
            string cnStr = ConfigurationManager.ConnectionStrings["SkyhighConnectionString"].ConnectionString;
            sqCmm.OpenConnection(cnStr);
            sqCmm.DeleteRole(Int32.Parse(hfIndex.Value));
            sqCmm.CloseConnection();
        }
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        sqlComm sqCmm = new sqlComm();
        string cnStr = ConfigurationManager.ConnectionStrings["SkyhighConnectionString"].ConnectionString;
        sqCmm.OpenConnection(cnStr);
        sqCmm.InsertRoles(txtNewRole.Text);
        sqCmm.CloseConnection();
        Response.Redirect("/admin/userRole.aspx");
    }
}
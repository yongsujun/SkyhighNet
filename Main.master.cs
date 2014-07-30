using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["login"] == null)
        //{
        //    string strPage = Page.AppRelativeVirtualPath;

        //    if (strPage != "~/admin/login.aspx")
        //    {
        //        Response.Redirect("/admin/login.aspx");
        //    }
        //    lblLogin.Text = Session["login"] + "<li><a href='/admin/login.aspx'>LOG IN</a></li>";
            


        //}
        //else
        //{
        //    lblLogin.Text = "<li><a href='/admin/login.aspx?state=logout'>LOG OUT</a></li>";
        //}
        

    }
    protected void logOut(object sender, EventArgs e)
    {
        Session["login"] = null;
    }
}

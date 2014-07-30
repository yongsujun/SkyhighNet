using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SkyhighConnectedLayer;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ///////////////////////////////////////////////////
        ///Getting submenu////////////////////////////////

        subMenu sm = new subMenu();
        lbladminMenu.Text = sm.getMenu("admin");

        ////////////////////////////////////////////////////
        SkyhighConnDAL skyDAL = new SkyhighConnDAL();
        lblError.Text = skyDAL.errorMsg;
    }
}
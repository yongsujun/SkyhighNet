using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SkyhighConnectedLayer;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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

        lbltitle.Text = "<h4 class='panel-title'>Add New Client</h4>";
        if (!IsPostBack)
        {
            lbltitle.Text = "<h4 class='panel-title'>Edit Client</h4>";
            if (Request.QueryString["id"] != null)
            {
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
                        txtCompany.Text = dr["C_Company"].ToString();
                        txtFirstName.Text = dr["C_FirstName"].ToString();
                        txtLastName.Text = dr["C_LastName"].ToString();
                        txtTel.Text = dr["C_Tel"].ToString();
                        txtFax.Text = dr["C_Fax"].ToString();
                        txtMobile.Text = dr["C_Mobile"].ToString();
                        txtAdd1.Text = dr["C_Add1"].ToString();
                        txtAdd2.Text = dr["C_Add2"].ToString();
                        txtEmail.Text = dr["C_Email"].ToString();

                    }
                    con.Close();
                }
            }
        }
    }

    protected void SubmitForm(object sender, EventArgs e)
    {

        string company = txtCompany.Text;
        string fName = txtFirstName.Text;
        string lName = txtLastName.Text;
        string tel = txtTel.Text;
        string fax = txtFax.Text;
        string mobile = txtMobile.Text;
        string add1 = txtAdd1.Text;
        string add2 = txtAdd2.Text;
        string email = txtEmail.Text;
        

        //SkyhighConnDAL skyDAL = new SkyhighConnDAL();
        sqlComm sqCmm = new sqlComm();

        if (Request.QueryString["id"] != null)
        {
            sqCmm.OpenConnection(cnStr);
            sqCmm.EditClients(Int32.Parse(Request.QueryString["id"]), company, fName, lName, tel, fax, mobile, add1, add2, email);
            sqCmm.CloseConnection();
            Response.Redirect("/admin/clientView.aspx?id=" + Request.QueryString["id"] + "&page=" + Request.QueryString["page"]);
        }
        else
        {
            sqCmm.OpenConnection(cnStr);
            sqCmm.InsertClients(company, fName, lName, tel, fax, mobile, add1, add2, email);
            sqCmm.CloseConnection();
            Response.Redirect("/admin/clientList.aspx");
        }

    }
}
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
        if (!IsPostBack)
        {    
        
            if (Request.QueryString["id"] != null)
            {
                using (SqlConnection con = new SqlConnection(cnStr))
                {
                    con.Open();
                    //con.InfoMessage += new SqlInfoMessageEventHandler(con_InfoMessage);
                    SqlDataReader dr;
                    string sql = "SELECT [S_ID],[S_UserID], [S_FirstName], [S_LastName], [S_Role], [S_DOB], [S_Address1], [S_Address2], [S_Contact], [S_Email] FROM [Staffs] where S_ID ='" + Request.QueryString["id"] + "'";
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        dr = com.ExecuteReader();
                    }
            
                    if (dr.Read())
                    {
                        txtID.Text = dr["S_UserID"].ToString();
                        txtID.ReadOnly = true;
                        txtFName.Text = dr["S_FirstName"].ToString();
                        txtLName.Text = dr["S_LastName"].ToString();
                        ddRole.SelectedValue = dr["S_Role"].ToString();
                        txtDOB.Text = dr["S_DOB"].ToString();
                        txtAdd1.Text = dr["S_Address1"].ToString();
                        txtAdd2.Text = dr["S_Address2"].ToString();
                        txtContact.Text = dr["S_Contact"].ToString();
                        txtEmail.Text = dr["S_Email"].ToString();
               
                    }
                    con.Close();
                }
            }
        }
    }
    
    private void IdCheck(string ID)
    {
        //sqlComm sqCmm = new sqlComm();
        string query = "SELECT COUNT(*) FROM staffs WHERE S_UserID = @UserName";

        using (SqlConnection conn = new SqlConnection(cnStr))
        {

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("UserName", ID);

                conn.Open();

                if ((int)cmd.ExecuteScalar() > 0)
                {
                    txtID.Text = "";
                    lblIDError.Text = "ID '"+ID+"' is being used";
                }
                else
                {
                    lblIDError.Text = "";
                }

            }

        }

    }
    protected void SubmitForm(object sender, EventArgs e)
    {
        
        string userID = txtID.Text;
        string userPWD = txtPWD.Text;
        string userFName = txtFName.Text;
        string userLName = txtLName.Text;
        string userRole = ddRole.Text;
        string userDOB = txtDOB.Text;
        string userAdd1 = txtAdd1.Text;
        string userAdd2 = txtAdd2.Text;
        string userContact = txtContact.Text;
        string userEmail = txtEmail.Text;
        IdCheck(userID);
        

        //SkyhighConnDAL skyDAL = new SkyhighConnDAL();
        sqlComm sqCmm = new sqlComm();
        
        if (Request.QueryString["id"] != null)
        {
            sqCmm.OpenConnection(cnStr);
            sqCmm.EditStaffs(Int32.Parse(Request.QueryString["id"]), sqCmm.Encryptdata(userPWD), userFName, userLName, userRole, userDOB, userAdd1, userAdd2,
                userContact, userEmail);
            sqCmm.CloseConnection();
            Response.Redirect("/admin/userView.aspx?id="+Request.QueryString["id"] + "&page=" + Request.QueryString["page"]);
        }
        else
        {
            sqCmm.OpenConnection(cnStr);
            sqCmm.InsertStaffs(userID, sqCmm.Encryptdata(userPWD), userFName, userLName, userRole, userDOB, userAdd1, userAdd2,
                userContact, userEmail);
            sqCmm.CloseConnection();
            Response.Redirect("/admin/userList.aspx");
        }
        
    }


    protected void txtID_TextChanged(object sender, EventArgs e)
    {
        IdCheck(txtID.Text);
    }
}
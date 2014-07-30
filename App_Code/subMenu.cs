using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// subMenu의 요약 설명입니다.
/// </summary>
public class subMenu
{
    private string cnStr = ConfigurationManager.ConnectionStrings["SkyhighConnectionString"].ConnectionString;
    public subMenu()
	{
		//
		// TODO: 여기에 생성자 논리를 추가합니다.
		//
	}
    private string menuStr;
    private string role;
    public string getMenu(string menuType)
    {
         
        if (menuType == "admin")
        {
            menuStr = "<a href='userList.aspx' class='list-group-item'>User List</a>" +
                      "<a href='userRole.aspx' class='list-group-item'>User Role</a>" +
                      "<a href='clientList.aspx' class='list-group-item'>Clients</a>" +
                      "<a href='priceView.aspx' class='list-group-item'>Price Info</a>" +
                      "<a href='report.aspx' class='list-group-item'>Report</a>";
        }
        return menuStr;
    }

    public string getRole(int roleNumber)
    {

        using (SqlConnection con = new SqlConnection(cnStr))
        {
            con.Open();
            //con.InfoMessage += new SqlInfoMessageEventHandler(con_InfoMessage);
            SqlDataReader dr;
            string sql = "SELECT [R_Roles] FROM [Roles] where R_Index =" + roleNumber;
            using (SqlCommand com = new SqlCommand(sql, con))
            {
                dr = com.ExecuteReader();
            }

            if (dr.Read())
            {
                role = dr["R_Roles"].ToString();
            }
            con.Close();
        }
        
        
        return role;   
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkyhighConnectedLayer;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// userList의 요약 설명입니다.
/// </summary>
public class userList
{
	public userList()
	{		
	}
    
    private string cnStr = ConfigurationManager.ConnectionStrings["SkyhighConnectionString"].ConnectionString;
    
    
    
    public DataSet select()
    {
        
        //SkyhighConnDAL skyDAL = new SkyhighConnDAL();

        //skyDAL.OpenConnection(cnStr);

        string sql = "SELECT [S_ID],[S_UserID], [S_FirstName], [S_LastName], [S_Role] FROM [Staffs] order by S_ID desc";
        SqlDataAdapter da = new SqlDataAdapter(sql, cnStr);
        
        DataSet ds = new DataSet();
        
        da.Fill(ds);
        

        return ds;

    }

    public DataSet selectRole()
    {        

        string sql = "SELECT [R_Index], [R_Roles] FROM [Roles] where R_Index > 0 order by R_Index desc";
        SqlDataAdapter da = new SqlDataAdapter(sql, cnStr);

        DataSet ds = new DataSet();

        da.Fill(ds);


        return ds;

    }

    public DataSet selectClients()
    {

        string sql = "SELECT [C_ID], [C_Company], [C_FirstName], [C_LastName] FROM [Clients] order by C_ID desc";
        SqlDataAdapter da = new SqlDataAdapter(sql, cnStr);

        DataSet ds = new DataSet();

        da.Fill(ds);


        return ds;

    }


}
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
    
    
    /// <summary>
    /// set or get the Current Page Number
    /// </summary>
    public int CurrentPage
    {
        get
        {
            //get current page number
            object obj = this.ViewState["_CurrentPage"];
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return (int)obj;
            }
        }
        set
        {
            //set in viewstate the current page number
            this.ViewState["_CurrentPage"] = value;
        }
    }

    /// <summary>
    /// set or get ObjectDataSource that's use to bind the control
    /// Like(Repeater or Datalist)
    /// </summary>
    public ObjectDataSource Ods { get; set; }

    /// <summary>
    /// set or get Control Name EX. (Repeater1 or Datalist1)
    /// </summary>
    public object ObjectControl { get; set; }

    /// <summary>
    /// set or get count of pages
    /// page size determine how many records will appears in every page
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    /// bind controls with data
    /// enable and disable controls depending on page number
    /// check for object Control if it a Repeater or a DataList
    /// </summary>
    /// <returns>the count of pages</returns>
    private int GetItems()
    {
        
        //create new instance of PagedDataSource
        PagedDataSource objPds = new PagedDataSource();
        //set number of pages will appear
        objPds.PageSize = PageSize;
        objPds.DataSource = Ods.Select();

        
        objPds.AllowPaging = true;
        
        int count = objPds.PageCount;
        objPds.CurrentPageIndex = CurrentPage;
        if (objPds.Count > 0)
        {
            //dispaly controls if there are pages
            btnPrevious.Visible = true;
            btnNext.Visible = true;
            btnLastRecord.Visible = true;
            btnFirstRecord.Visible = true;
            lblCurrentPage.Visible = true;
            lblCurrentPage.Text = "Page " +
              Convert.ToString(CurrentPage + 1) + " of " +
              Convert.ToString(objPds.PageCount);
        }
        else
        {
            //disable controls if there are no pages
            btnPrevious.Visible = false;
            btnNext.Visible = false;
            btnLastRecord.Visible = false;
            btnFirstRecord.Visible = false;
            lblCurrentPage.Visible = false;
        }
        btnPrevious.Enabled = !objPds.IsFirstPage;
        btnNext.Enabled = !objPds.IsLastPage;
        btnLastRecord.Enabled = !objPds.IsLastPage;
        btnFirstRecord.Enabled = !objPds.IsFirstPage;
        //check for object control if it a DataList
        //we will use DList Variable
        //if (ObjectControl is DataList)
        //{
        //    DList = (DataList)ObjectControl;
        //    DList.DataSource = objPds;
        //    DList.DataBind();
        //}
        //check for object control if it a Repeater
        //we will use Rep Variable
        //else if (ObjectControl is Repeater)
        //{
        //    Rep = (Repeater)ObjectControl;
        //    Rep.DataSource = objPds;
        //    Rep.DataBind();
        //}
        
        Repeater1 = (Repeater)ObjectControl;
        
        Repeater1.DataSource = objPds;
        Repeater1.DataBind();
        
        return count;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        string cnStr = ConfigurationManager.ConnectionStrings["SkyhighConnectionString"].ConnectionString;

        //SkyhighConnDAL skyDAL = new SkyhighConnDAL();

        //skyDAL.OpenConnection(cnStr);
        Ods = odsUserList;
        Repeater1.DataSource = Ods.Select();
        if (Request.QueryString["page"] != null & !IsPostBack)
        {
            CurrentPage = Int32.Parse(Request.QueryString["page"]);
        }
       
        //Getting total count
        /////////////////////////////////////////////////
        ObjectControl = Repeater1;
               
        string sql = "select count(*) from Clients";
       
        int count = 0;

        using (SqlConnection cn = new SqlConnection(cnStr))
        {
            using (SqlCommand cmdCount = new SqlCommand(sql, cn))
            {
                cn.Open();
                count = (int)cmdCount.ExecuteScalar();
                lblTotal.Text = "(Total : "+count.ToString()+")";
                cn.Close();
            }
        }
        /////////////////////////////////////////////////////

        //

        PageSize = 10;
        GetItems();
        ///////////////////////////////////////////////////
        ///Getting submenu////////////////////////////////
        
        subMenu sm = new subMenu();
        lbladminMenu.Text = sm.getMenu("admin");

        ////////////////////////////////////////////////////
        //skyDAL.CloseConnection();if( !IsPostBack )

        

    }

    protected void btnPrevious_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;

        GetItems();
    }
    protected void btnFirstRecord_Click(object sender, EventArgs e)
    {
        CurrentPage = 0;

        GetItems();
    }
    protected void btnNext_Click(object sender, EventArgs e)
    {
        //go to next page
        CurrentPage += 1;

        GetItems();
    }
    protected void btnLastRecord_Click(object sender, EventArgs e)
    {
        //go to last page
        CurrentPage = GetItems() - 1;

        GetItems();
    }
    protected void addNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("/admin/clientAdd.aspx");
    }

    
}
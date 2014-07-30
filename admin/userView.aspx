<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="userView.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 147px
        }
    </style>
    
    


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <div class="container">

      <div class="row row-offcanvas row-offcanvas-right">

        <div class="col-xs-12 col-sm-9">
          <p class="pull-right visible-xs">
            <button type="button" class="btn btn-primary btn-xs" data-toggle="offcanvas">Toggle nav</button>
          </p>
          <div class="jumbotron">
            
            
                <div class="panel panel-primary">
                <!-- Default panel contents -->
                <div class="panel-heading"><h4>User View</h4></div>

                <!-- Table -->
                <table class="table">
                    <tr>
                        <td class="auto-style1" style="background-color:lightblue">
                            User ID</td>
                        <td>
                            <asp:Label ID="lblUserID" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="background-color: lightblue">
                            Full Name</td>
                        <td>
                            <asp:Label ID="lblFullName" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="background-color: lightblue">
                            Role</td>
                        <td>
                            <asp:Label ID="lblRole" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="background-color: lightblue">
                            Address</td>
                        <td>
                            <asp:Label ID="lblAdd1" runat="server" Text=""></asp:Label>

                            <asp:Label ID="lblAdd2" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="background-color: lightblue">
                            Contact</td>
                        <td>
                            <asp:Label ID="lblContact" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="background-color: lightblue">
                            Email</td>
                        <td>
                            <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td class="text-right"><asp:Label ID="lblSID" Visible = "false" runat="server" Text=""></asp:Label>
                            &nbsp;<asp:Button ID="btnBack" runat="server" CssClass="btn-default" Text="BACK" OnClick="btnBack_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnEdit" runat="server" CssClass="btn-default" Text="EDIT" OnClick="btnEdit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            


                            <asp:Button ID="btnDelete" runat="server" CssClass="btn-default" Text="DELETE" OnClick="btnDelete_Click" />
                        </td>
                    </tr>
                </table>
            </div>
              


           
          </div>
          </div>

        <div class="col-xs-6 col-sm-3 sidebar-offcanvas" id="sidebar" role="navigation">
          <div class="list-group">
            <asp:Label id="lbladminMenu" runat="server" Text="Label"> 
               
           </asp:Label>  
          </div>
        </div><!--/span-->
      </div><!--/row-->

      <hr>

      <footer>
        
      </footer>

    </div><!--/.container-->

    </form>

</asp:Content>


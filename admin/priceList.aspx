<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="priceList.aspx.cs" Inherits="admin_Default" %>
<%@ Import Namespace="System.Data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
            <div class="panel panel-success">
              <div class="panel-heading">
                <h4 class="panel-title">Clients List</h4>
              </div>
              <div class="panel-body">
                

              <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                
                <table class="table table-hover">
                  <thead>
                    <tr>
                      <th>Client ID</th>
                      <th>First Name</th>
                      <th>Last Name</th>
                      <th>Role</th>
                    </tr>
                  </thead>
                  <tbody>
                </HeaderTemplate>
                <ItemTemplate>    
                    <tr>
                      <td><%# Eval("C_ID") %></td>
                      <td><a href="/admin/clientView.aspx?id=<%# Eval("C_ID") %>&page=<%=CurrentPage%>"><%# Eval("C_Company") %></a></td>
                      <td><%# Eval("C_FirstName") %></td>
                      <td><%# Eval("C_LastName") %></td>
                    </tr>
                </ItemTemplate>    
                <FooterTemplate>
                   </tbody>
                    
                   </table>
                </FooterTemplate>
                
                  
            
            </asp:Repeater>
                <table class="table-condensed" style="width:100%">
                    <tr>
                        <td>
                            <asp:Button ID="btnFirstRecord" runat="server" CssClass="btn-default" Text="<<" OnClick="btnFirstRecord_Click" />
                            <asp:Button ID="btnPrevious" runat="server" CssClass="btn-default" Text="<" OnClick="btnPrevious_Click" />
                            <asp:Label ID="lblCurrentPage" runat="server" Text="Label"></asp:Label>
                            <asp:Button ID="btnNext" runat="server" CssClass="btn-default" Text=">" OnClick="btnNext_Click" />
                            <asp:Button ID="btnLastRecord" runat="server" CssClass="btn-default" Text=">>" OnClick="btnLastRecord_Click" />

                        </td>
                        <td style="text-align:right">
                            <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
                  <asp:Button ID="addNew" runat="server" Text="Add New User" OnClick="addNew_Click"/>
                        </td>

                    </tr>
                </table>


              </div>
            </div>
  
              
              
                   

              </div>

          
            <asp:ObjectDataSource ID="odsUserList" runat="server" SelectMethod="selectClients" TypeName="userList"></asp:ObjectDataSource>

          
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


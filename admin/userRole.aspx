<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="userRole.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type = "text/javascript">
        function Confirm(index_value) {
            var hidden = document.getElementById('<%=hfIndex.ClientID%>');
            
            
            

            if (confirm("Do you want to detete?"))
            {
               hidden.value = index_value;
               form1.submit();
                
            }
            else
            {

            }
        }
    </script>
    <form id="form1" runat="server">
        <asp:ScriptManager ID='ScriptManager1' runat='server' EnablePageMethods='true' />
        <div class="container">
            
    

            <asp:HiddenField ID="hfIndex" runat="server" />
      <div class="row row-offcanvas row-offcanvas-right">

        <div class="col-xs-12 col-sm-9">
          <p class="pull-right visible-xs">
            <button type="button" class="btn btn-primary btn-xs" data-toggle="offcanvas">Toggle nav</button>
          </p>
          <div class="jumbotron">
            <h2>Creating or Deleting User Roles</h2>
            
                <div class="panel panel-primary">
                  <div class="panel-heading">
                    <h5 class="panel-title">Roles</h5>
                  </div>
                  <div class="panel-body">
                      <table class="table">
                    <tr><td>
                        <asp:TextBox ID="txtNewRole" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnNew" runat="server" Text="ADD" OnClick="btnNew_Click" />

                        </td>
                    </tr>
                </table>

                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="odsRoleList">
                <HeaderTemplate>
                
                <table class="table table-hover">
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Roles</th>
                      <th>Delete</th>                      
                    </tr>
                  </thead>
                  <tbody>
                </HeaderTemplate>
                <ItemTemplate>    
                    <tr>
                      <td><%# Eval("R_Index") %></td>
                      <td><%# Eval("R_Roles") %></td>
                      <td>
                          <a href='javascript:Confirm(<%# Eval("R_Index") %>)'>[Delete]</a>
                           
                          
                          </td>
                      
                    </tr>
                </ItemTemplate>    
                <FooterTemplate>
                   </tbody>
                    
                   </table>
                    
                </FooterTemplate>
                
                  
            
            </asp:Repeater>
            <asp:ObjectDataSource ID="odsRoleList" runat="server" SelectMethod="selectRole" TypeName="userList"></asp:ObjectDataSource>
                  </div>
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


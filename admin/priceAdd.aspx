<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="priceAdd.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 119px;
        }
        .auto-style2 {
            width: 119px;
            height: 36px;
        }
        .auto-style3 {
            width: 348px;
            height: 36px;
        }
        .auto-style4 {
            width: 348px
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">

      <div class="row row-offcanvas row-offcanvas-right">

        <div class="col-xs-12 col-sm-9">
          <p class="pull-right visible-xs">
            <button type="button" class="btn btn-primary btn-xs" data-toggle="offcanvas">Toggle nav</button>
          </p>
          <div class="jumbotron">
            
              <div class="panel panel-primary">
              <div class="panel-heading">
                  <asp:Label ID="lbltitle" runat="server" Text="Label"></asp:Label>
              </div>
              <div class="panel-body">
                  <form id="clientForm" runat="server">
                  <table class="table-responsive" style="width:100%">
                      <tr>
                          <td class="auto-style2">
                              Company
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="txtCompany" runat="server" CssClass="form-control" Width="90%" Height="30"></asp:TextBox>
                              
                          </td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCompany" Font-Size="XX-Small" ForeColor="Red">* Compay Name Required</asp:RequiredFieldValidator>
                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2">
                              First Name
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" Width="90%" Height="30"></asp:TextBox>
                              
                          </td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFirstName" ForeColor="Red" Font-Size="X-Small">* First Name Required</asp:RequiredFieldValidator>
                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2">
                              Last Name
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" Width="90%" Height="30"></asp:TextBox>
                              
                          </td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtLastName" ForeColor="Red" Font-Size="X-Small">* Last Name Required</asp:RequiredFieldValidator>
                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2">
                              Tel
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="txtTel" runat="server" CssClass="form-control" Width="90%" Height="30"></asp:TextBox>
                          </td>
                          <td>

                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2">
                              Fax
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="txtFax" runat="server" CssClass="form-control" Width="90%" Height="30"></asp:TextBox>
                          </td>
                          <td>

                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2">
                              Mobile
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" Width="90%" Height="30"></asp:TextBox>
                          </td>
                          <td>

                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2">
                              Email
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="90%" Height="30"></asp:TextBox>
                              
                          </td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" ForeColor="Red" Font-Size="X-Small">* Email Required</asp:RequiredFieldValidator>

                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2">
                              Address Line 1
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="txtAdd1" runat="server" CssClass="form-control" Width="90%" Height="30"></asp:TextBox>
                          </td>
                          <td>

                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style2">
                              Address Line 2
                          </td>
                          <td class="auto-style3">
                              <asp:TextBox ID="txtAdd2" runat="server" CssClass="form-control" Width="90%" Height="30"></asp:TextBox>
                          </td>
                          <td>

                          </td>
                      </tr>
                      <tr>
                          <td class="auto-style1">
                              <asp:Button ID="btnAdd" OnClick="SubmitForm" runat="server" Text="SUBMIT"  />
                          </td>
                          <td class="auto-style4">
                             
                          </td>
                          <td>

                          </td>
                      </tr>
                  </table></form>
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
<
</asp:Content>


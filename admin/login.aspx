<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="container">

     <div class="row row-offcanvas row-offcanvas-right">       
        <div class="col-xs-12 col-sm-9"> 

        <div class="panel panel-primary">
          <div class="panel-heading">
             <h3 class="panel-title">Log In</h3>
          </div><!--/.panel-heading-->
          <div class="panel-body">
            

     
              
         
          
            
            <form id="loginForm" runat="server">              
                <div class="col-md-12">
                    <div class="row">
                        <asp:Label ID="lblLoginError" runat="server" Text=""></asp:Label>
                    </div>

                    <div class="row">
                        <div class="col-md-3">
                        User ID
                        </div>
                        <div class="col-md-9">
                        <asp:TextBox ID="txtLoginID" runat="server" CssClass="form-control" Width="50%"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLoginID" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Enter ID to Login</asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-3">
                        Password
                        </div>
                        <div class="col-md-9">
                        <asp:TextBox ID="txtLoginPwd" runat="server" CssClass="form-control"  Width="50%" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLoginPwd" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Enter Password to Login</asp:RequiredFieldValidator>
                        </div>
                    </div>

              </div>
              <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                  <div class="checkbox">
                    <label>
                      <input type="checkbox"> Remember me
                    </label>
                  </div>
                </div>
              
                <div class="col-sm-offset-2 col-sm-10">
                  <asp:Button id="btnSubmit" runat="server"  CssClass="btn-default" Text="LOGIN" OnClick="SubmitForm" />
                </div>
              </div>
                 
            </form>
                       
         </div>
 
        <div class="col-xs-6 col-sm-3 sidebar-offcanvas" id="sidebar" role="navigation">            
        </div><!--/span-->
          
      </div>

      <hr>

      <footer>
        
      </footer>


          </div><!--/.panel-body-->
         </div><!--/.panel panel-default-->



      
     
    </div><!--/.container-->

</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="addNew.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">

      <div class="row row-offcanvas row-offcanvas-right">

        <div class="col-xs-12 col-sm-9">
          <p class="pull-right visible-xs">
            <button type="button" class="btn btn-primary btn-xs" data-toggle="offcanvas">Toggle nav</button>
          </p>
          <div class="jumbotron">
            <h3>New User Input</h3>            
          </div>
            <form id="userForm" runat="server">
                <div class="row">
                    <div class="col-md-12">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                        <div class="row">
                        <div class="col-md-3">
                        User ID
                        </div>
                        <div class="col-md-9">
                        <asp:TextBox id="txtID" runat="server" Width="30%" CssClass="form-control" OnTextChanged="txtID_TextChanged" AutoPostBack="True"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorID" runat="server" ControlToValidate="txtID" ErrorMessage="ID Required" ForeColor="Red">*</asp:RequiredFieldValidator>    
                            <asp:Label ID="lblIDError" runat="server" ForeColor="Red"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3">
                        Password
                        </div>
                        <div class="col-md-9">
                        <asp:TextBox id="txtPWD" CssClass="form-control" Width="30%" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                    </div><br />
                    <div class="row">
                        <div class="col-md-3">
                        Re-Password
                        </div>
                        <div class="col-md-9">
                        <asp:TextBox id="txtRePWD" CssClass="form-control" Width="30%" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPWD" ControlToValidate="txtRePWD" ErrorMessage="Password should be same" ForeColor="Red">*</asp:CompareValidator>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3">
                        First Name
                        </div>
                        <div class="col-md-9">
                        <asp:TextBox id="txtFName"  CssClass="form-control" runat="server" Width="30%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFName" ErrorMessage="First Name  Required" ForeColor="Red">*</asp:RequiredFieldValidator>    
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3">
                        Last Name
                        </div>
                        <div class="col-md-9">
                        <asp:TextBox id="txtLName" CssClass="form-control"  runat="server" Width="30%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLName" ErrorMessage="Last Name Required" ForeColor="Red">*</asp:RequiredFieldValidator>    
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3">
                        Date of Birth
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox id="txtDOB" CssClass="form-control"  runat="server" Width="30%"></asp:TextBox>                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDOB" ErrorMessage="Date of Birth Required" ForeColor="Red">*</asp:RequiredFieldValidator>    
                        </div>
                    </div><br />
                    <div class="row">
                        <div class="col-md-3">
                        Role
                        </div>
                        <div class="col-md-9">
                            <asp:DropDownList ID="ddRole" CssClass="form-control" runat="server" Width="30%" DataSourceID="SDSRole" DataTextField="R_Roles" DataValueField="R_Index">
                                
                            </asp:DropDownList>
                                                   
                            <asp:SqlDataSource ID="SDSRole" runat="server" ConnectionString="<%$ ConnectionStrings:SkyhighConnectionString %>" SelectCommand="SELECT * FROM [Roles]"></asp:SqlDataSource>
                                                   
                        </div>
                    </div><br />
                    <div class="row">
                        <div class="col-md-3">
                        Address Line 1
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox id="txtAdd1" CssClass="form-control"  runat="server" Width="70%"></asp:TextBox>                        
                        </div>
                    </div><br />
                    <div class="row">
                        <div class="col-md-3">
                        Address Line 2
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox id="txtAdd2" CssClass="form-control"  runat="server" Width="70%"></asp:TextBox>                        
                        </div>
                    </div><br />
                    <div class="row">
                        <div class="col-md-3">
                        Contact
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox id="txtContact" CssClass="form-control"  runat="server" Width="70%"></asp:TextBox>                        
                        </div>
                    </div><br />
                    <div class="row">
                        <div class="col-md-3">
                        Email
                        </div>
                        <div class="col-md-9">
                            <asp:TextBox id="txtEmail" CssClass="form-control"  runat="server" Width="70%"></asp:TextBox>                        
                        </div>
                    </div><br />
                    </div>
                </div>

   
   <asp:Button id="btnSubmit" runat="server"  CssClass="btn-default" Text="Submit" OnClick="SubmitForm" />
</form> 

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

</asp:Content>


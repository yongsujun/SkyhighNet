<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="delete.aspx.cs" Inherits="admin_Default" %>

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
            <div class="panel panel-danger">
              <div class="panel-heading">
                <asp:Label ID="lbltitle" runat="server" Text="Label"></asp:Label>
              </div>
              <div class="panel-body">
                Do you really want to delete this? <br /><br />  
                  <form id="Form1" runat="server">
                      <asp:HiddenField ID="hfTable" runat="server" />
                      <asp:HiddenField ID="hfField" runat="server" />
                      <asp:HiddenField ID="hfReturn" runat="server" />
                      <asp:HiddenField ID="hfReturn1" runat="server" />
                      <asp:Button ID="btnYes" runat="server" Text="YES" OnClick="btnYes_Click" />     
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     
                    <asp:Button ID="btnNo" runat="server" Text="NO" OnClick="btnNo_Click" />
                  </form>
              </div>
            </div>


          </div>
          </div>

        <div class="col-xs-6 col-sm-3 sidebar-offcanvas" id="sidebar" role="navigation">
          <div class="list-group">
            
          </div>
        </div><!--/span-->
      </div><!--/row-->

      <hr>

      <footer>
        
      </footer>

    </div><!--/.container-->

</asp:Content>


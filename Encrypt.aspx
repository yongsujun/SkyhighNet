<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Encrypt.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Password to ecrypt"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Encrypt" />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
        <asp:Label ID="Label2" runat="server" Text="decrypt"></asp:Label>
    <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" Text="Decrypt" />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <h1>Navbar example</h1>
    <br />
    <br />
    <br />
    <br />
    <br />

    </form>

</asp:Content>


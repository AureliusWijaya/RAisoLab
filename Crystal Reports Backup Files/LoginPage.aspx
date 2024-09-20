<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Guest/Navbar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="RAisoLab.Views.Guest.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="UsernameBox" runat="server"></asp:TextBox>

    <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="PasswordBox" runat="server"></asp:TextBox> 

    
    <asp:Label ID="Remember" runat="server" Text="Remember Me"></asp:Label>
    <asp:CheckBox ID="RememberCheck" runat="server" />

    <asp:Button ID="LoginButton" runat="server" Text="LOGIN" OnClick="LoginButton_Click"/>

    <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

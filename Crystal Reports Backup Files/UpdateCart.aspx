<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="RAisoLab.Views.Customer.UpdateCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Quantity"></asp:Label>
    <asp:TextBox ID="QuantityBox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="UpdateButton" runat="server" Text="Button" Onclick="UpdateButton_Click"/>
    <br />
     <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

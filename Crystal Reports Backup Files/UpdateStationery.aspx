<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateStationery.aspx.cs" Inherits="RAisoLab.Views.Admin.UpdateStationery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="StationeryLabel" runat="server" Text="Stationery Name"></asp:Label>
    <asp:TextBox ID="NameBox" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label2" runat="server" Text="Stationery Price"></asp:Label>
    <asp:TextBox ID="PriceBox" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="UpdateButton" runat="server" Text="UPDATE" Onclick ="UpdateButton_Click"/>

    <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
</div>
</asp:Content>

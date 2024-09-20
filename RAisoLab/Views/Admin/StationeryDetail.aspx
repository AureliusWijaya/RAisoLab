<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Navbar.Master" AutoEventWireup="true" CodeBehind="StationeryDetail.aspx.cs" Inherits="RAisoLab.Views.Admin.StationeryDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" Text="Stationery Name: "></asp:Label>
    <asp:Label ID="NameLabel" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="Label2" runat="server" Text="Stationery Price: "></asp:Label>
    <asp:Label ID="PriceLabel" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RAisoLab.Views.Admin.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:GridView ID="StationeryGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="StationeryId" OnRowEditing="StationeryGrid_RowEditing" OnRowDeleting="StationeryGrid_RowDeleting" OnSelectedIndexChanged="StationeryGrid_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="StationeryName" HeaderText="Stationery Name" SortExpression="StationeryName"/>
        <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Details" ShowHeader="True" Text="GO"/>
        <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Remove Stationery" ShowHeader="True" Text="Remove" />
        <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Update Stationery" ShowHeader="True" Text="UPDATE" />
    </Columns>
    </asp:GridView>
    <asp:Button ID="InsertButton" runat="server" Text="Insert Stationery" onclick="InsertButton_Click"/>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Navbar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="RAisoLab.Views.Customer.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:GridView ID="CartGrid" runat="server" OnSelectedIndexChanged ="CartGrid_SelectedIndexChanged" OnRowDeleting ="CartGrid_RowDeleting" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Stationery Name" SortExpression="StationeryName" />
            <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Stationery Price" SortExpression="StationeryPrice" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Edit Cart" ShowHeader="True" Text="EDIT" />
            <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Remove Cart" ShowHeader="True" Text="REMOVE" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="OrderButton" runat="server" Text="ORDER" OnClick="OrderButton_Click"/>
    <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>

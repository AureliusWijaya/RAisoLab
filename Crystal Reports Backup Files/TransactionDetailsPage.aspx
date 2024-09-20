<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailsPage.aspx.cs" Inherits="RAisoLab.Views.Customer.TransactionDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:GridView ID="DetailGrid" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Stationery Name" SortExpression="MsStationery.StationeryName" />
            <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Stationery Price" SortExpression="MsStationery.StationeryPrice" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        </Columns>

    </asp:GridView>
        </div>
</asp:Content>

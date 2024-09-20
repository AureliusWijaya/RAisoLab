<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="RAisoLab.Views.Customer.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:GridView ID="TransactionGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged ="TransactionGrid_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
        <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
        <asp:BoundField DataField="MsUser.UserName" HeaderText="Customer Name" SortExpression="MsUser.UserName" />
        <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Transaction Detail" ShowHeader="True" Text="Check Details" />
    </Columns>
</asp:GridView>
        </div>
</asp:Content>

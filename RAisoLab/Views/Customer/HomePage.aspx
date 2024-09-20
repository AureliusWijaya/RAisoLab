<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RAisoLab.Views.Customer.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
     <asp:GridView ID="StationeryGrid" runat="server" OnSelectedIndexChanged ="StationeryGrid_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="StationeryId">
     <Columns>
     <asp:BoundField DataField="StationeryName" HeaderText="Stationery Name" SortExpression="StationeryName"/>
     <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Details" ShowHeader="True" Text="GO"/>
     </Columns>
 </asp:GridView>
     </div>
</asp:Content>

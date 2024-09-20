<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Guest/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RAisoLab.Views.Guest.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="StationeryGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="StationeryId" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="StationeryName" HeaderText="Stationery Name" SortExpression="StationeryName" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Details" ShowHeader="True" Text="GO"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

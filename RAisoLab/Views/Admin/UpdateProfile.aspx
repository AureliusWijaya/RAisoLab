<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="RAisoLab.Views.Admin.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="UsernameBox" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="DOBLabel" runat="server" Text="Date of Birth"></asp:Label>
    <asp:Calendar ID="DOBCalendar" runat="server"></asp:Calendar>
    <br />

    <asp:RadioButton ID="MaleButton" runat="server" Text ="Male" GroupName ="Gender"/>
    <asp:RadioButton ID="FemaleButton" runat="server" Text ="Female" GroupName="Gender"/>
    <br />

    <asp:Label ID="PhoneLabel" runat="server" Text="Phone Number"></asp:Label>
    <asp:TextBox ID="PhoneBox" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="AddressLabel" runat="server" Text="Address"></asp:Label>
    <asp:TextBox ID="AddressBox" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="PasswordBox" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="UpdateButton" runat="server" Text="UPDATE PROFILE" OnClick ="UpdateButton_Click"/>

     <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
     </div>
</asp:Content>

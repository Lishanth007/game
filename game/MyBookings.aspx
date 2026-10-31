<%@ Page Title="My Bookings" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyBookings.aspx.cs" Inherits="game.MyBookings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>My Bookings</h3>
    <asp:GridView ID="gvBookings" runat="server"></asp:GridView>
</asp:Content>
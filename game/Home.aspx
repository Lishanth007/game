<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="game.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Welcome to Game Center</h3>
    <p>Select an option below to begin:</p>
    <ul>
        <li><a href="Arenas.aspx">View Available Arenas & Consoles</a></li>
        <li><a href="BookSlot.aspx">Book a Time Slot</a></li>
    </ul>
</asp:Content>
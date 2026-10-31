<%@ Page Title="Book Slot" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookSlot.aspx.cs" Inherits="game.BookSlot" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Book a Slot</h3>
    
    <p>
        Select Arena: 
        <asp:DropDownList ID="ddlArenas" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlArenas_SelectedIndexChanged"></asp:DropDownList>
    </p>

    <p>
        Date: 
        <asp:TextBox ID="txtDate" runat="server" TextMode="Date"></asp:TextBox>
    </p>

    <p>
        Time Slot: 
        <asp:DropDownList ID="ddlSlots" runat="server">
            <asp:ListItem Text="10:00 AM - 11:00 AM" Value="10:00 AM - 11:00 AM" />
            <asp:ListItem Text="11:00 AM - 12:00 PM" Value="11:00 AM - 12:00 PM" />
            <asp:ListItem Text="02:00 PM - 03:00 PM" Value="02:00 PM - 03:00 PM" />
            <asp:ListItem Text="04:00 PM - 05:00 PM" Value="04:00 PM - 05:00 PM" />
            <asp:ListItem Text="06:00 PM - 07:00 PM" Value="06:00 PM - 07:00 PM" />
        </asp:DropDownList>
    </p>

    <p>
        Price per Hour: Rs. <asp:Label ID="lblRate" runat="server" Text="0"></asp:Label>
    </p>

    <asp:Button ID="btnGoToCart" runat="server" Text="Add to Cart" OnClick="btnGoToCart_Click" />
</asp:Content>
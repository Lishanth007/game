<%@ Page Title="Cart" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="game.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Cart & Summary</h3>
    
    <p><b>Station:</b> <asp:Label ID="lblArena" runat="server"></asp:Label></p>
    <p><b>Date:</b> <asp:Label ID="lblDate" runat="server"></asp:Label></p>
    <p><b>Slot:</b> <asp:Label ID="lblSlot" runat="server"></asp:Label></p>
    <p><b>Total Amount:</b> Rs. <asp:Label ID="lblTotal" runat="server"></asp:Label></p>

    <p>
        Payment Mode:
        <asp:DropDownList ID="ddlPay" runat="server">
            <asp:ListItem Text="UPI" Value="UPI" />
            <asp:ListItem Text="Cash at Center" Value="Cash" />
        </asp:DropDownList>
    </p>

    <asp:Button ID="btnPay" runat="server" Text="Confirm Booking & Pay" OnClick="btnPay_Click" />
</asp:Content>
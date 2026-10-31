<%@ Page Title="Arenas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Arenas.aspx.cs" Inherits="game.Arenas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Available Arenas</h3>
    <asp:GridView ID="gvArenas" runat="server" AutoGenerateColumns="False" OnRowCommand="gvArenas_RowCommand">
        <Columns>
            <asp:BoundField DataField="ArenaName" HeaderText="Name" />
            <asp:BoundField DataField="Category" HeaderText="Type" />
            <asp:BoundField DataField="HourlyRate" HeaderText="Price/hr (Rs)" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnBook" runat="server" Text="Select" 
                        CommandName="SelectArena" 
                        CommandArgument='<%# Eval("ArenaID") + ";" + Eval("ArenaName") + ";" + Eval("HourlyRate") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
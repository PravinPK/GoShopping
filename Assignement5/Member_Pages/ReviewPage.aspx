<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewPage.aspx.cs" MasterPageFile="~/BestBuy.Master"  Inherits="Assignement5.Member_Pages.ReviewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Panel HorizontalAlign="Right" runat="server"> <asp:Button ID="Button2" runat="server" style="align-self:auto;" Text="Sign Out" OnClick="SignOutClick_Click" /></asp:Panel>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Table ID="Table1" runat="server" GridLines="Both" BorderStyle="Solid">
        </asp:Table>
        <br />
        <br />
        <asp:Button ID="Backbtn" runat="server" Text="Back" Font-Bold="True" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="BtnBuy" runat="server" Text="Buy" OnClick="BtnBuy_Click" />
</asp:Content>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffPage.aspx.cs" MasterPageFile="~/BestBuy.Master" Inherits="Assignement5.Member_Pages.StaffPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Panel HorizontalAlign="Right" runat="server"> <asp:Button ID="Button2" runat="server" style="align-self:auto;" Text="Sign Out" OnClick="SignOutClick_Click" /></asp:Panel>
    <h3 style="align-self:center">Staff Page</h3>
    <h4>All User Details</h4>
    <asp:Label ID="lblall" runat="server" Text="Label"></asp:Label>
    <br />
</asp:Content>

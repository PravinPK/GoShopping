<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinalPage.aspx.cs" MasterPageFile="~/BestBuy.Master" Inherits="Assignement5.Member_Pages.FinalPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel HorizontalAlign="Right" runat="server"> <asp:Button ID="Button2" runat="server" style="align-self:auto;" Text="Sign Out" OnClick="SignOutClick_Click" /></asp:Panel>
    <h2><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h2>
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductSelection.aspx.cs" MasterPageFile="~/BestBuy.Master" Inherits="Assignement5.Member_Pages.ProductSelection" %>

<%@ Register src="~/User Control/RecommendedProd.ascx" tagname="RecommendedProd" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
     <asp:Panel HorizontalAlign="Right" runat="server"> <asp:Button ID="SignOutClick" runat="server" style="align-self:auto; margin-left: 863px;" Text="Sign Out" OnClick="SignOutClick_Click" /></asp:Panel>
  
    <asp:Label style="align-self:auto" ID="Greeting" runat="server" Text="Welcome User" ></asp:Label>
    &nbsp;
   
    <asp:Button ID="btnShowDetails" runat="server" Text="Show User Details" OnClick="btnShowDetails_Click" />
    <asp:Panel ID="panelshowUserDetails" runat="server" Visible="False">
        <asp:Label ID="lblUserDetail" runat="server" Text="Label"></asp:Label>
    </asp:Panel>
    <div id="Staffdiscount" runat="server"><h3>Being a Staff u get a Discount of 15% on all Products</h3></div>
  
    <h2>Search Products</h2>
    <asp:TextBox ID="TextBox1" runat="server" Width="846px"></asp:TextBox>
    <asp:Button ID="btnProductSearch" runat="server" style="margin-left: 87px" Text="Search" Width="114px" OnClick="btnProductSearch_Click" />
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:Table ID="Table1" runat="server">
    </asp:Table>
      <h2>Here are a few Recommended Products for You</h2>
    <asp:Button ID="GotoStoreLocation" runat="server" Text="GotoStoreLocation Sample" OnClick="GotoStoreLocation_Click" Width="232px" />
    <asp:Button ID="SeeReview" runat="server" Text="See Review Sample" OnClick="SeeReview_Click" style="margin-left: 110px" />
  
    <uc1:RecommendedProd ID="RecommendedProd1" runat="server" />
  
    </asp:Content>
        
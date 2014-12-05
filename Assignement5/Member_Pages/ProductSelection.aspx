<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductSelection.aspx.cs" MasterPageFile="~/BestBuy.Master" Inherits="Assignement5.Member_Pages.ProductSelection" %>

<%@ Register src="~/User Control/RecommendedProd.ascx" tagname="RecommendedProd" tagprefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        var products = new Array();
        function AddToCartClient(productName,productPrice) {
            products.push(escape('{"name":"' + productName + '","price":' + productPrice + '}'));
            document.getElementById("ContentPlaceHolder1_products").value = products;
            alert('Item added to cart');
            return false;
        }
    </script>
     <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
    <asp:Label style="align-self:auto" ID="Greeting" runat="server" Text="Welcome User" ></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:Panel HorizontalAlign="Right" runat="server"> <asp:Button ID="Button2" runat="server" style="align-self:auto;" Text="Sign Out" OnClick="SignOutClick_Click" /></asp:Panel>
    <br />
    <asp:Button ID="btnShowDetails" runat="server" Text="Show User Details" OnClick="btnShowDetails_Click" />
    <asp:Panel ID="panelshowUserDetails" runat="server" Visible="False">
        <asp:Label ID="lblUserDetail" runat="server" Text="Label"></asp:Label>
    </asp:Panel>
    <br />
  
    <br />
    <h2>Search Products</h2>
    <asp:TextBox ID="TextBox1" runat="server" Width="846px"></asp:TextBox>
    <asp:Button ID="btnProductSearch" runat="server" style="margin-left: 87px" Text="Search" Width="114px" OnClick="btnProductSearch_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Checkout when you are done" />
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:Table ID="Table1" runat="server">
    </asp:Table>
    <asp:HiddenField ID="products" runat="server" />
    <br />
    <asp:Button ID="GotoStoreLocation" runat="server" Text="GotoStoreLocation Sample" OnClick="GotoStoreLocation_Click" Width="232px" />
    <asp:Button ID="SeeReview" runat="server" Text="See Review Sample" OnClick="SeeReview_Click" style="margin-left: 110px" />
    <h2>Here are a few Recommended Products for You</h2>
    <uc1:RecommendedProd ID="RecommendedProd1" runat="server" />
  
    </asp:Content>
        
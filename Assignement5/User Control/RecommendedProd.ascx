<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RecommendedProd.ascx.cs" Inherits="Assignement5.User_Control.RecommendedProd" %>
   <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="Reco">
        <ContentTemplate>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Get Recommended Products"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="NoProductsLabel" runat="server"></asp:Label>
<br />
<br />
<asp:Table ID="Table1" runat="server" BorderStyle="Solid" GridLines ="Both">
</asp:Table>
<br />
    </ContentTemplate>
    </asp:UpdatePanel>

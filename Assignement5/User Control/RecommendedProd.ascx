<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RecommendedProd.ascx.cs" Inherits="Assignement5.User_Control.RecommendedProd" %>
   <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="Reco">
        <ContentTemplate>
<asp:Label ID="NoProductsLabel" runat="server"></asp:Label>
<br />
<br />
<asp:Table ID="Table1" runat="server" BorderStyle="Solid" GridLines ="Both">
</asp:Table>
<br />
    </ContentTemplate>
    </asp:UpdatePanel>

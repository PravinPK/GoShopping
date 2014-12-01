<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RecommendedProd.ascx.cs" Inherits="Assignement5.User_Control.RecommendedProd" %>
   <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="Reco">
        <ContentTemplate>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Get Recommended Products"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" Font-Bold="True" Text="Get Products" OnClick="Button1_Click" />
<br />
<br />
<asp:Label ID="NoProductsLabel" runat="server"></asp:Label>
<br />
<br />
<asp:Table ID="Table1" runat="server" BorderStyle="Solid" GridLines ="Both">
</asp:Table>
<br />
    </ContentTemplate>
    </asp:UpdatePanel>

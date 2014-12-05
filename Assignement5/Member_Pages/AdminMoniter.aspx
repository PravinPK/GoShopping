<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMoniter.aspx.cs" MasterPageFile="~/BestBuy.Master" Inherits="Assignement5.Member_Pages.AdminMoniter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel HorizontalAlign="Right" runat="server"> <asp:Button ID="Button2" runat="server" style="align-self:auto;" Text="Sign Out" OnClick="SignOutClick_Click" /></asp:Panel>
    <h3 style="align-self:center">Admin Page</h3>
    <br />
   <b> REMOVE USER</b><br />
    <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
    <asp:TextBox ID="RemoveUserTxt" runat="server" style="margin-left: 38px; margin-top: 0px"></asp:TextBox>
    <br />
    <asp:Button ID="RemoveUser" runat="server" style="margin-left: 91px" Text="Remove" OnClick="RemoveUser_Click" />
    <br />
    <asp:Label ID="RM_Result" runat="server" Font-Size="X-Large"></asp:Label>
    <br />
    <br />
    <b> ADD STAFF</b><br />
<table style="width: 23%; height: 85px;">
            <tr>   
                <td class="auto-style1">Username</td>
                <td><asp:TextBox ID="SU_username" runat="server" style="margin-left: 92px" Height="20px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td><asp:TextBox ID="SU_pass" runat="server" style="margin-left: 92px" Height="20px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Retype Password</td>
                <td><asp:TextBox ID="SU_repass" runat="server" Height="20px" style="margin-left: 92px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class="auto-style1">First Name</td>
                <td><asp:TextBox ID="SU_firstname" runat="server" Height="20px" style="margin-left: 92px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td class="auto-style2">Address</td>
                <td class="auto-style3"><asp:TextBox ID="SU_Address" runat="server" Height="20px" style="margin-left: 92px" Text="Arizona State University"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td class="auto-style1">City<br />
                </td>
                <td><asp:TextBox ID="SU_City" runat="server" Height="20px" style="margin-left: 92px" Text="Tempe"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Phone Number</td>
                <td><asp:TextBox ID="SU_phone" runat="server" Height="20px" style="margin-left: 92px" Text="357-3452-4344"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email ID<br />
                </td>
                <td><asp:TextBox ID="SU_EmailID" runat="server" Height="20px" style="margin-left: 92px" Text="sample@asu"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Register" runat="server" OnClick="AddUser_Click" style="margin-left: 283px" Text="Add Staff" />
        <br />
    <asp:Label ID="SU_result" runat="server" Font-Size="X-Large"></asp:Label>
        <br />
    <h4>All User Details</h4>
    <asp:Label ID="lblall" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
</asp:Content>
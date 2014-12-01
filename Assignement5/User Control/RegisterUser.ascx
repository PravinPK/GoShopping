<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegisterUser.ascx.cs" Inherits="Assignement5.User_Control.RegisterUser" %>
<asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <ContentTemplate>
<div style="background-color:darkgrey">
        <asp:Label ID="Label1" runat="server" Text="Register" Font-Size="X-Large"></asp:Label>
    
        <br />
        <table style="width: 23%; height: 85px;">
            <tr>   
                <td class="auto-style1">Username</td>
                <td><asp:TextBox ID="SU_username" runat="server" style="margin-left: 92px" Height="20px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td><asp:TextBox ID="SU_pass" runat="server" style="margin-left: 92px" Height="20px" OnTextChanged="SU_pass_TextChanged" TextMode="Password"></asp:TextBox>
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
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 283px" Text="Register" />
        <br />
        <asp:Label ID="SU_result" runat="server" Font-Size="X-Large"></asp:Label>
        <br />
        <br />
    </div>
    </ContentTemplate>
    </asp:UpdatePanel>
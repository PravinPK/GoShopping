<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SignIn.ascx.cs" Inherits="Assignement5.User_Control.SignIn" %>
   <asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <ContentTemplate>
<div style="background-color:lightgray">
        <asp:Label ID="Label2" runat="server" Text="Login" Font-Size="X-Large"></asp:Label>
            <br />
            <table style="width: 23%; height: 42px;">
                <tr>
                    <td class="auto-style4">Username</td>
                    <td><asp:TextBox ID="LG_username" runat="server" style="margin-left: 83px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Password</td>
                    <td><asp:TextBox ID="LG_pass" runat="server" style="margin-left: 82px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btn_Login" runat="server" OnClick="btn_Login_Click" style="margin-left: 296px" Text="Login" />
            <br />
            <asp:Label ID="LG_result" runat="server" Font-Size="X-Large" ></asp:Label>
        &nbsp;&nbsp;&nbsp;
        </div>
        </ContentTemplate>
    </asp:UpdatePanel>
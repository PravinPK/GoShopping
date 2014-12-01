﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" MasterPageFile="~/BestBuy.Master" Inherits="Assignement5.Member_Pages.Login" %>

<%@ Register TagPrefix="signIn" TagName="Login" Src="~/User Control/SignIn.ascx" %>
<%@ Register TagPrefix="Register" TagName="Login1" Src="~/User Control/RegisterUser.ascx" %>
<%@ Register TagPrefix="Admin" TagName="Login2" Src="~/User Control/Admin.ascx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <table border="0">
                <tbody>
                    <tr style="align-self: center; width: 600px">
                        <td>
                            <p style="align-self: center">
                                <asp:Button ID="btn_SignIn" runat="server" Text="Sign In" Width="180px" OnClick="btn_SignIn_Click" />

                            </p>
                        </td>
                        <td>
                            <p style="align-self: center">
                                New User? &nbsp;
                                <asp:Button ID="btn_Register" runat="server" Text="Register" Width="180px" OnClick="btn_Register_Click" />
                            </p>
                        </td>
                        <td>
                            <p style="align-self: center">
                                <asp:Button ID="btn_Admin" runat="server" Text="Admin" Width="180px" OnClick="btn_Admin_Click" />
                            </p>
                        </td>
                    </tr>
                </tbody>
            </table>
            <asp:Panel runat="server" ID="SignIndiv">
                <signIn:Login runat="server" />
            </asp:Panel>
            <asp:Panel runat="server" ID="registexrDiv" Visible="false">
                <Register:Login1 runat="server" />
            </asp:Panel>
            <asp:Panel runat="server" ID="AdminDiv" Visible="false">
                <Admin:Login2 runat="server" />
            </asp:Panel>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

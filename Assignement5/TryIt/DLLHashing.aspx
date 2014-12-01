<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DLLHashing.aspx.cs" Inherits="Assignement5.TryIt.DLLHashing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Type Your String<asp:TextBox ID="encryptinput" runat="server" style="margin-left: 64px" Width="239px"></asp:TextBox>
        </p>
        <p>
            <br />
            <asp:Button ID="btnHash" runat="server" Text="Hash and Encrypt" OnClick="btnHash_Click" />
        </p>
        <p>
            Encrypted Output:
            <asp:Label ID="lblEncryped" runat="server" Text=""></asp:Label>

        </p>
        <p>
            Hashed Output:
            <asp:Label ID="lblHash" runat="server" Text=""></asp:Label>

        </p>
        <p>
            Decryption String&nbsp;

            <asp:TextBox ID="txtdecryptinput" runat="server" style="margin-left: 159px" Width="317px"></asp:TextBox>

        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Decrypt" Width="214px" OnClick="Button1_Click" />

        </p>
        <p>
            Decrypted Output :
            <asp:Label ID="lbldecrytedoutput" runat="server" Text=""></asp:Label>

        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

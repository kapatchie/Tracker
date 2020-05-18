<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Tracker.Presentation.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="usernameLabel" runat="server" Font-Bold="True" Text="Username: "></asp:Label>
&nbsp;<asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
&nbsp;
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Password: "></asp:Label>
&nbsp;<asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" />
        </p>
        <div>
        </div>
    </form>
</body>
</html>

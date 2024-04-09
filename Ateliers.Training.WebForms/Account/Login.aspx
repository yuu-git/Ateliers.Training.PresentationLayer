<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for="UserName">User Name:</label>
        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
        <br />
        User Color:
        <asp:TextBox ID="UserColor" runat="server"></asp:TextBox>
        <br />
        <label for="Password">Password:</label>
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
    </div>
    </form>
</body>
</html>

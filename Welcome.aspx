<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="LoginForm.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Benvenuto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Benvenuto</h2>
            <asp:Label ID="lblWelcomeMessage" runat="server"></asp:Label><br />
            <asp:Button ID="BtnLogout" runat="server" Text="Logout" OnClick="BtnLogout_Click" />
        </div>
    </form>
</body>
</html>

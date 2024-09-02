<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ECommerce.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Connexion</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />
            <asp:Label ID="lblLogin" runat="server" Text="Login:"></asp:Label>
            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPassword" runat="server" Text="Mot de passe:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Connexion" OnClick="btnLogin_Click" /><br />
            <asp:HyperLink ID="lnkRegister" runat="server" NavigateUrl="Register.aspx">S'enregistrer</asp:HyperLink>
        </div>
    </form>
</body>
</html>
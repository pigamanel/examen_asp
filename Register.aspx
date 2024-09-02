<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ECommerce.Register" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Inscription</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Inscription</h2>
            <asp:TextBox ID="txtNom" runat="server" Placeholder="Nom"></asp:TextBox><br />
            <asp:TextBox ID="txtPrenoms" runat="server" Placeholder="Prénoms"></asp:TextBox><br />
            <asp:TextBox ID="txtDateNaissance" runat="server" Placeholder="Date de naissance"></asp:TextBox><br />
            <asp:TextBox ID="txtLogin" runat="server" Placeholder="Login"></asp:TextBox><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Mot de passe"></asp:TextBox><br />
            <asp:Button ID="btnRegister" runat="server" Text="Valider" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>

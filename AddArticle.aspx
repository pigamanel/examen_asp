<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="ECommerce.AddArticle" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Ajouter un article</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Ajouter un article</h2>
            <asp:TextBox ID="txtNom" runat="server" Placeholder="Nom de l'article"></asp:TextBox><br />
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="4" Placeholder="Description"></asp:TextBox><br />
            <asp:DropDownList ID="ddlCategorie" runat="server"></asp:DropDownList><br />
            <asp:DropDownList ID="ddlGenre" runat="server">
                <asp:ListItem>Masculin</asp:ListItem>
                <asp:ListItem>Féminin</asp:ListItem>
            </asp:DropDownList><br />
            <asp:TextBox ID="txtCouleur" runat="server" Placeholder="Couleur"></asp:TextBox><br />
            <asp:TextBox ID="txtTaille" runat="server" Placeholder="Taille"></asp:TextBox><br />
            <asp:TextBox ID="txtPrix" runat="server" Placeholder="Prix"></asp:TextBox><br />
            <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" OnClick="btnAjouter_Click" />
        </div>
    </form>
</body>
</html>

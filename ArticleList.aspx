<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArticleList.aspx.cs" Inherits="ECommerce.ArticleList" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Liste des articles</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Liste des articles</h2>
            <asp:GridView ID="gvArticles" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Nom" HeaderText="Nom" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="CategorieNom" HeaderText="Catégorie" />
                    <asp:BoundField DataField="Genre" HeaderText="Genre" />
                    <asp:BoundField DataField="Couleur" HeaderText="Couleur" />
                    <asp:BoundField DataField="Taille" HeaderText="Taille" />
                    <asp:BoundField DataField="Prix" HeaderText="Prix" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HyperLink ID="hlEdit" runat="server" Text="Modifier" NavigateUrl='<%# "EditArticle.aspx?id=" + Eval("Id") %>'></asp:HyperLink>
                            <asp:Button ID="btnDelete" runat="server" Text="Supprimer" CommandArgument='<%# Eval("Id") %>' OnClick="btnDelete_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

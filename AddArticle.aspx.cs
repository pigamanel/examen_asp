using System;
using System.Data.SqlClient;

namespace ECommerce
{
    public partial class AddArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Charger les catégories dans le DropDownList
                using (SqlConnection conn = new SqlConnection("your_connection_string"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Id, Nom FROM Categories", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    ddlCategorie.DataSource = reader;
                    ddlCategorie.DataTextField = "Nom";
                    ddlCategorie.DataValueField = "Id";
                    ddlCategorie.DataBind();
                }
            }
        }

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string description = txtDescription.Text.Trim();
            int categorieId = int.Parse(ddlCategorie.SelectedValue);
            string genre = ddlGenre.SelectedValue;
            string couleur = txtCouleur.Text.Trim();
            string taille = txtTaille.Text.Trim();
            decimal prix = decimal.Parse(txtPrix.Text.Trim());

            using (SqlConnection conn = new SqlConnection("ECommerceDB"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Articles (Nom, Description, CategorieId, Genre, Couleur, Taille, Prix) VALUES (@Nom, @Description, @CategorieId, @Genre, @Couleur, @Taille, @Prix)", conn);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@CategorieId", categorieId);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Couleur", couleur);
                cmd.Parameters.AddWithValue("@Taille", taille);
                cmd.Parameters.AddWithValue("@Prix", prix);

                cmd.ExecuteNonQuery();
                Response.Redirect("ArticleList.aspx");
            }
        }
    }
}

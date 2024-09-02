using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class ArticleList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadArticles();
            }
        }

        private void LoadArticles()
        {
            using (SqlConnection conn = new SqlConnection("ECommerceDB"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Articles.Id, Articles.Nom, Articles.Description, Categories.Nom AS CategorieNom, Articles.Genre, Articles.Couleur, Articles.Taille, Articles.Prix FROM Articles JOIN Categories ON Articles.CategorieId = Categories.Id", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvArticles.DataSource = dt;
                gvArticles.DataBind();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int articleId = int.Parse((sender as Button).CommandArgument);

            using (SqlConnection conn = new SqlConnection("your_connection_string"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Articles WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", articleId);
                cmd.ExecuteNonQuery();
                LoadArticles();
            }
        }
    }
}

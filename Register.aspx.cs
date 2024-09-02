using System;
using System.Data.SqlClient;

namespace ECommerce
{
    public partial class Register : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string prenoms = txtPrenoms.Text.Trim();
            string dateNaissance = txtDateNaissance.Text.Trim();
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection("ECommerceDB"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Utilisateurs (Nom, Prenoms, DateDeNaissance, Login, MotDePasse) VALUES (@Nom, @Prenoms, @DateNaissance, @Login, @MotDePasse)", conn);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Prenoms", prenoms);
                cmd.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@MotDePasse", password);

                cmd.ExecuteNonQuery();
                Response.Redirect("Login.aspx");
            }
        }
    }
}

using System.Data.SqlClient;
using System.Web.Security;
using System;

namespace ECommerce
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection("ECommerceDB"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Utilisateurs WHERE Login=@Login AND MotDePasse=@MotDePasse", conn);
                cmd.Parameters.AddWithValue("@Login", login);
                cmd.Parameters.AddWithValue("@MotDePasse", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    FormsAuthentication.RedirectFromLoginPage(login, false);
                }
                else
                {
                    lblMessage.Text = "Login ou mot de passe incorrect";
                }
            }
        }
    }
}

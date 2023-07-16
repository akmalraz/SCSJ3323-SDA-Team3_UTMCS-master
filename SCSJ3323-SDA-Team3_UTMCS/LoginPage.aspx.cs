using BLL;
using System;

namespace SCSJ3323_SDA_Team3_UTMCS
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string matrixId = username.Text;
            string Password = password.Text;

            User.UserBuilder builder = new User.UserBuilder();
            User user = builder.WithMatrixId(matrixId)
                                .WithPassword(Password)
                                .Build();

            if (user.ValidateUser(out string role))
            {
                // Store user information in session variables
                Session["LoggedInUser"] = matrixId;
                Session["Role"] = role;

                // Redirect to the appropriate page based on the user's role
                switch (role)
                {
                    case "Admin":
                        Response.Redirect("ManageuserPage.aspx");
                        break;
                    case "User":
                        Response.Redirect("ProfilePage.aspx");
                        break;
                    case "Psychologist":
                        Response.Redirect("PsychologistPage.aspx");
                        break;
                    default:
                        // Redirect to a default page for unrecognized roles
                        Response.Redirect("Default.aspx");
                        break;
                }
            }
            else
            {
                // Display error message for invalid login
                errMsg.Text = "Invalid Username or Password";
            }
        }
    }
}

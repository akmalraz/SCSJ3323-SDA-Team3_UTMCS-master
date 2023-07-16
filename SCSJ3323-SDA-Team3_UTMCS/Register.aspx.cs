using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCSJ3323_SDA_Team3_UTMCS
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnUserBuilder_Click(object sender, EventArgs e)
        {
            string matrixId = txtMatrixId.Value;
            string password = txtPassword.Value;
            string email = txtEmail.Value;
            string name = txtName.Value;
            int phoneNumber = int.Parse(txtPhoneNumber.Value);
            string memberStatus = txtMemberStatus.Value;
            string role = "User"; // Set the role for the user
            string profilePic = fileProfilePic.PostedFile.FileName; // Assuming the file is uploaded correctly

            User user = new User.UserBuilder()
                .WithMatrixId(matrixId)
                .WithPassword(password)
                .WithEmail(email)
                .WithName(name)
                .WithPhoneNumber(phoneNumber)
                .WithMemberStatus(memberStatus)
                .WithRole(role)
                .WithProfilePic(profilePic)
                .Build();

            user.CreateUser();

            Response.Redirect("LoginPage.aspx");
        }

        protected void btnAdminBuilder_Click(object sender, EventArgs e)
        {
            string matrixId = txtMatrixId.Value;
            string password = txtPassword.Value;
            string email = txtEmail.Value;
            string name = txtName.Value;
            int phoneNumber = int.Parse(txtPhoneNumber.Value);
            string memberStatus = txtMemberStatus.Value;
            string role = "Admin"; // Set the role for the user
            string profilePic = fileProfilePic.PostedFile.FileName; // Assuming the file is uploaded correctly

            User user = new User.UserBuilder()
                .WithMatrixId(matrixId)
                .WithPassword(password)
                .WithEmail(email)
                .WithName(name)
                .WithPhoneNumber(phoneNumber)
                .WithMemberStatus(memberStatus)
                .WithRole(role)
                .WithProfilePic(profilePic)
                .Build();

            user.CreateUser();

            Response.Redirect("LoginPage.aspx");
        }

        protected void btnPsychologistBuilder_Click(object sender, EventArgs e)
        {
            string matrixId = txtMatrixId.Value;
            string password = txtPassword.Value;
            string email = txtEmail.Value;
            string name = txtName.Value;
            int phoneNumber = int.Parse(txtPhoneNumber.Value);
            string memberStatus = txtMemberStatus.Value;
            string role = "Psychologist"; // Set the role for the user
            string profilePic = fileProfilePic.PostedFile.FileName; // Assuming the file is uploaded correctly

            User user = new User.UserBuilder()
                .WithMatrixId(matrixId)
                .WithPassword(password)
                .WithEmail(email)
                .WithName(name)
                .WithPhoneNumber(phoneNumber)
                .WithMemberStatus(memberStatus)
                .WithRole(role)
                .WithProfilePic(profilePic)
                .Build();

            user.CreateUser();

            Response.Redirect("LoginPage.aspx");
        }
    }
}
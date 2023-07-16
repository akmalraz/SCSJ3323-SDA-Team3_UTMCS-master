using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCSJ3323_SDA_Team3_UTMCS
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User user = new User(); 
                // Get the logged-in user's matrix ID from the session
                string matrixId = Session["LoggedInUser"] as string;

                // Retrieve the user details from the DAL
                DataTable dtUser = user.GetUserByMatrixId(matrixId);

                if (dtUser.Rows.Count > 0)
                {
                    DataRow row = dtUser.Rows[0];

                    // Display the user details on the page
                    lblMatrixId.Text = row["matrix_id"].ToString();
                    txtPassword.Text = row["password"].ToString();
                    txtEmail.Text = row["email"].ToString();
                    txtName.Text = row["name"].ToString();
                    txtPhoneNumber.Text = row["phoneNumber"].ToString();
                    imgProfilePic.ImageUrl = row["profilePic"].ToString();
                    hdnProfilePicPath.Value = row["profilePic"].ToString();
                }
            }

        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Enable editing of user details
            txtPassword.Enabled = true;
            txtEmail.Enabled = true;
            txtName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            fileProfilePic.Enabled = true;

            // Show the Save button and hide the Edit button
            btnEdit.Visible = false;
            btnSave.Visible = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            // Get the updated user details from the controls
            string matrixId = lblMatrixId.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string name = txtName.Text;
            int phoneNumber = int.Parse(txtPhoneNumber.Text);

            // Upload and save the profile picture if a new one is selected
            string profilePicPath = hdnProfilePicPath.Value;
            if (fileProfilePic.HasFile)
            {
                string fileName = Path.GetFileName(fileProfilePic.FileName);
                string imagePath = Server.MapPath("Picture/") + fileName;
                fileProfilePic.SaveAs(imagePath);
                profilePicPath = "Picture/" + fileName;
            }

            // Update the user details in the BLL
            user.UpdateUserDetails(matrixId, password, email, name, phoneNumber, profilePicPath);

            // Disable editing of user details
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            fileProfilePic.Enabled = false;

            // Show the Edit button and hide the Save button
            btnSave.Visible = false;
            btnEdit.Visible = true;

            // Display the updated profile picture
            imgProfilePic.ImageUrl = profilePicPath;
        }
    }
}
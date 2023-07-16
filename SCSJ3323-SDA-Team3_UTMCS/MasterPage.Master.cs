using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace SCSJ3323_SDA_Team3_UTMCS
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (Session["LoggedInUser"] != null)
            {
                // Set the profile picture image URL
                User user = new User();
                // Get the logged-in user's matrix ID from the session
                string matrixId = Session["LoggedInUser"] as string;

                // Retrieve the user details from the DAL
                DataTable dtUser = user.GetUserByMatrixId(matrixId);

                if (dtUser.Rows.Count > 0)
                {
                    DataRow row = dtUser.Rows[0];

                    // Display the user details on the page
                    imgProfilePic.ImageUrl = row["profilePic"].ToString();
                    hdnProfilePicPath.Value = row["profilePic"].ToString();
                }
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        // Method to retrieve the profile picture path from the session and return the image URL
        protected string GetProfilePicture()
        {
            if (Session["profilePic"] != null)
            {
                string profilePicturePath = Session["profilePic"].ToString();
                return profilePicturePath;
            }
            else
            {
                // Return a default image URL if the profile picture path is not available
                return "Picture/image.jpg";
            }
        }
    }
}
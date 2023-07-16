using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCSJ3323_SDA_Team3_UTMCS
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearErrorLabels();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            ClearErrorLabels();

            // Validate input and display error messages
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(matrixNumber.Text))
            {
                lblMatrixNumberError.Text = "Matrix Number is required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(password.Text))
            {
                lblPasswordError.Text = "Password is required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(email.Text))
            {
                lblEmailError.Text = "Email is required.";
                isValid = false;
            }
            else if (!IsValidEmail(email.Text))
            {
                lblEmailError.Text = "Invalid email format.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(name.Text))
            {
                lblNameError.Text = "Name is required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(phoneNumber.Text))
            {
                lblPhoneNumberError.Text = "Phone Number is required.";
                isValid = false;
            }
            else if (!IsValidPhoneNumber(phoneNumber.Text))
            {
                lblPhoneNumberError.Text = "Invalid phone number format.";
                isValid = false;
            }

            if (isValid)
            {
                User user = new User();
                user.AddUser(matrixNumber.Text, password.Text, email.Text, name.Text, int.Parse(phoneNumber.Text));
            }
        }

        private void ClearErrorLabels()
        {
            lblMatrixNumberError.Text = string.Empty;
            lblPasswordError.Text = string.Empty;
            lblEmailError.Text = string.Empty;
            lblNameError.Text = string.Empty;
            lblPhoneNumberError.Text = string.Empty;
        }

        private bool IsValidEmail(string email)
        {
            // You can implement your own email validation logic here
            // For simplicity, this example uses a basic regular expression pattern
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // You can implement your own phone number validation logic here
            // For simplicity, this example checks if the phone number contains only digits and has a minimum length of 7
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length >= 7;
        }
    }
}
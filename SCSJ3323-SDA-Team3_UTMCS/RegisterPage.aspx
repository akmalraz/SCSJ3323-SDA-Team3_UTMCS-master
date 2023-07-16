<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="SCSJ3323_SDA_Team3_UTMCS.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <!--bootstrap css-->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <!--datatables css-->
    <link href="datatables/css/jquery.dataTables.min.css" rel="stylesheet" />
    <!--fontawesome css-->
    <link href="fontawesome/css/all.css" rel="stylesheet" />

    <!--popper/bootstrap js-->
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <style>
        h1, h2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>UTM Counselling System</h1>
            <h2>Register</h2>
            <div class="form-group">
                <label for="matrixNumber" class="label">Matrix Number:</label>
                <asp:TextBox ID="matrixNumber" runat="server" CssClass="form-control" required="True"></asp:TextBox>
                <asp:Label ID="lblMatrixNumberError" runat="server" CssClass="error-label"></asp:Label>
            </div>
            <div class="form-group">
                <label for="password" class="label">Password:</label>
                <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control" required="True"></asp:TextBox>
                <asp:Label ID="lblPasswordError" runat="server" CssClass="error-label"></asp:Label>
            </div>
            <div class="form-group">
                <label for="email" class="label">Email:</label>
                <asp:TextBox ID="email" type="text" runat="server" CssClass="form-control" required="True"></asp:TextBox>
                <asp:Label ID="lblEmailError" runat="server" CssClass="error-label"></asp:Label>
            </div>
            <div class="form-group">
                <label for="name" class="label">Name:</label>
                <asp:TextBox ID="name" runat="server" CssClass="form-control" required="True"></asp:TextBox>
                <asp:Label ID="lblNameError" runat="server" CssClass="error-label"></asp:Label>
            </div>
            <div class="form-group">
                <label for="phoneNumber" class="label">Phone Number:</label>
                <asp:TextBox ID="phoneNumber" runat="server" CssClass="form-control" required="True"></asp:TextBox>
                <asp:Label ID="lblPhoneNumberError" runat="server" CssClass="error-label"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="btnRegister_Click" />
            </div>
            <div class="login-link">
                Already have an account? <a href="LoginPage.aspx">Login</a>
            </div>
        </div>
    </form>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>

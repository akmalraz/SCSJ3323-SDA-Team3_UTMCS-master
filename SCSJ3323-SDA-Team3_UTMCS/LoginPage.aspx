<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SCSJ3323_SDA_Team3_UTMCS.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
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
        .container {
            margin-top: 50px;
            max-width: 400px;
        }

        .label {
            font-weight: bold;
        }

        .register-link {
            margin-top: 20px;
            text-align: center;
        }
        h2{
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>UTM Counselling System</h1>
            <h2>Login</h2>
            <div class="form-group">
                <label for="username" class="label">Username ID:</label>
                <asp:TextBox ID="username" runat="server" CssClass="form-control" required="True"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="password" class="label">Password:</label>
                <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control" required="True"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
            </div>
            <div class="register-link">
                Don't have an account? <a href="Register.aspx">Register</a>
            </div>
            <asp:Label ID="errMsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
   
</body>
</html>
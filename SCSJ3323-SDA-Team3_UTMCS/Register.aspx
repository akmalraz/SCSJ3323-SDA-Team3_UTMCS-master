<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SCSJ3323_SDA_Team3_UTMCS.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Register User</h2>
            <div class="mb-3">
                <label for="txtMatrixId" class="form-label">Matrix ID:</label>
                <input type="text" id="txtMatrixId" runat="server" class="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtPassword" class="form-label">Password:</label>
                <input type="password" id="txtPassword" runat="server" class="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email:</label>
                <input type="email" id="txtEmail" runat="server" class="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtName" class="form-label">Name:</label>
                <input type="text" id="txtName" runat="server" class="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtPhoneNumber" class="form-label">Phone Number:</label>
                <input type="text" id="txtPhoneNumber" runat="server" class="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtMemberStatus" class="form-label">Member Status:</label>
                <input type="text" id="txtMemberStatus" runat="server" class="form-control" />
            </div>

            <div class="mb-3">
                <label for="fileProfilePic" class="form-label">Profile Picture:</label>
                <input type="file" id="fileProfilePic" runat="server" class="form-control" />
            </div>

            <asp:Button ID="btnUserBuilder" runat="server" Text="User Builder" OnClick="btnUserBuilder_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnAdminBuilder" runat="server" Text="Admin Builder" OnClick="btnAdminBuilder_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnPsychologistBuilder" runat="server" Text="Psychologist Builder" OnClick="btnPsychologistBuilder_Click" CssClass="btn btn-primary" />
        </div>
    </form>
</body>
</html>

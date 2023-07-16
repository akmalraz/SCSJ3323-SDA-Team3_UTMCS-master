<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="SCSJ3323_SDA_Team3_UTMCS.ProfilePage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="header">
            <h1>User Profile</h1>
        </div>
        <div class="">
            <div class="form-group">
                <label class="form-label">Matrix ID:</label>
                <asp:Label ID="lblMatrixId" runat="server" CssClass="form-control-static"></asp:Label>
            </div>
            <div class="form-group">
                <label class="form-label">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="form-label">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="form-label">Name:</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="form-label">Phone Number:</label>
                <asp:TextBox ID="txtPhoneNumber" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="form-label">Profile Picture:</label>
                <asp:FileUpload ID="fileProfilePic" runat="server" CssClass="form-control-file" />
                <asp:Image ID="imgProfilePic" runat="server" Width="150px" Height="150px" CssClass="form-control" />
                <asp:HiddenField ID="hdnProfilePicPath" runat="server" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-primary" OnClick="btnEdit_Click" />
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" Visible="False" OnClick="btnSave_Click" />
            </div>
        </div>
    </div>
</asp:Content>

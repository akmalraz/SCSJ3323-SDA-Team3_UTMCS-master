<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AppointmentPage.aspx.cs" Inherits="SCSJ3323_SDA_Team3_UTMCS.AppointmentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(document).ready(function () {
            $('#TEP').DataTable();
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Appointment Page</h2>
        <div>
            <table id="TEP" class="table table-striped" style="width:100%">
                <thead>
                    <tr>
                        <th>Matrix ID</th>
                        <th>Email</th>
                        <th>Name</th>
                        <th>Phone No</th>
                        <th>Member Status</th>
                        <th>Role</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>1</td>
                        <td>1</td>
                        <td>1</td>
                        <td>1</td>
                        <td>1</td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>2</td>
                        <td>2</td>
                        <td>2</td>
                        <td>2</td>
                        <td>2</td>
                    </tr>
                </tbody>
            </table>
        </div>
</asp:Content>

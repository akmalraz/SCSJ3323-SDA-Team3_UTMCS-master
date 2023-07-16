<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageuserPage.aspx.cs" Inherits="SCSJ3323_SDA_Team3_UTMCS.ManageuserPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Manage User</h2>
    <div class="table-responsive">
        <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="false" OnRowEditing="gvUsers_RowEditing"
            OnRowUpdating="gvUsers_RowUpdating" OnRowCancelingEdit="gvUsers_RowCancelingEdit" OnRowDeleting="gvUsers_RowDeleting"
            DataKeyNames="matrix_id" CssClass="table table-striped">
            <Columns>
                <asp:BoundField DataField="matrix_id" HeaderText="Matrix ID" />
                <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label ID="lblEmail" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEmail" runat="server" Text='<%# Eval("email") %>' CssClass="form-control"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("name") %>' CssClass="form-control"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Role">
                    <ItemTemplate>
                        <asp:Label ID="lblRole" runat="server" Text='<%# Eval("role") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlRole" runat="server" CssClass="form-control">
                            <asp:ListItem Text="User" Value="User"></asp:ListItem>
                            <asp:ListItem Text="Admin" Value="Admin"></asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" ControlStyle-CssClass="btn btn-primary" ButtonType="Button" />
                <asp:CommandField ShowDeleteButton="True" ControlStyle-CssClass="btn btn-danger" ButtonType="Button" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

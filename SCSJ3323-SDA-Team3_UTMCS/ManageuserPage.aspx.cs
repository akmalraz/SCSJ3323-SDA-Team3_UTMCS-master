using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCSJ3323_SDA_Team3_UTMCS
{
    public partial class ManageuserPage : System.Web.UI.Page
    {
        private User user;

        protected void Page_Load(object sender, EventArgs e)
        {
            user = new User();

            if (!IsPostBack)
            {
                BindUsersGrid();
            }
        }

        private void BindUsersGrid()
        {
            DataTable userTable = user.GetAllUsers();
            List<User> userList = new List<User>();

            foreach (DataRow row in userTable.Rows)
            {
                User userObj = new User()
                {
                    MatrixId = row["matrix_id"].ToString(),
                    
                };

                userList.Add(userObj);
            }

            gvUsers.DataSource = userList;
            gvUsers.DataBind();
        }

        protected void gvUsers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvUsers.EditIndex = e.NewEditIndex;
            BindUsersGrid();
        }

        protected void gvUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvUsers.Rows[e.RowIndex];
            string matrixId = gvUsers.DataKeys[e.RowIndex].Value.ToString();
            string email = ((TextBox)row.FindControl("txtEmail")).Text;
            string name = ((TextBox)row.FindControl("txtName")).Text;
            string role = ((DropDownList)row.FindControl("ddlRole")).SelectedValue;

            user.UpdateUser(matrixId, email, name, role);

            gvUsers.EditIndex = -1;
            BindUsersGrid();
        }

        protected void gvUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvUsers.EditIndex = -1;
            BindUsersGrid();
        }

        protected void gvUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string matrixId = gvUsers.DataKeys[e.RowIndex].Value.ToString();
            user.DeleteUser(matrixId);

            BindUsersGrid();
        }
    }
}

using DAL.DataSet1TableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class User : IEnumerable<User>
    {
        private UserDBTableAdapter userDBTableAdapter;

        public string MatrixId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string MemberStatus { get; set; }
        public string Role { get; set; }
        public string ProfilePic { get; set; }

        public User()
        {
            userDBTableAdapter = new UserDBTableAdapter();
        }

        private User(UserBuilder builder)
        {
            MatrixId = builder.MatrixId;
            Password = builder.Password;
            Email = builder.Email;
            Name = builder.Name;
            PhoneNumber = builder.PhoneNumber;
            MemberStatus = builder.MemberStatus;
            Role = builder.Role;
            ProfilePic = builder.ProfilePic;
        }

        public static UserBuilder Builder()
        {
            return new UserBuilder();
        }

        public class UserBuilder
        {
            public string MatrixId { get; private set; }
            public string Password { get; private set; }
            public string Email { get; private set; }
            public string Name { get; private set; }
            public int PhoneNumber { get; private set; }
            public string MemberStatus { get; private set; }
            public string Role { get; private set; }
            public string ProfilePic { get; private set; }

            public UserBuilder WithMatrixId(string matrixId)
            {
                MatrixId = matrixId;
                return this;
            }

            public UserBuilder WithPassword(string password)
            {
                Password = password;
                return this;
            }

            public UserBuilder WithEmail(string email)
            {
                Email = email;
                return this;
            }

            public UserBuilder WithName(string name)
            {
                Name = name;
                return this;
            }

            public UserBuilder WithPhoneNumber(int phoneNumber)
            {
                PhoneNumber = phoneNumber;
                return this;
            }

            public UserBuilder WithMemberStatus(string memberStatus)
            {
                MemberStatus = memberStatus;
                return this;
            }

            public UserBuilder WithRole(string role)
            {
                Role = role;
                return this;
            }

            public UserBuilder WithProfilePic(string profilePic)
            {
                ProfilePic = profilePic;
                return this;
            }

            public User Build()
            {
                return new User(this);
            }
        }

        public void AddUser(string matrixId, string password, string email, string name, int phoneNumber)
        {
            userDBTableAdapter.addUser(matrixId, password, email, name, phoneNumber);
        }

        public bool ValidateUser(out string role)
        {
            try
            {
                userDBTableAdapter = new UserDBTableAdapter();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while initializing UserDBTableAdapter: " + ex.Message);
                throw;
            }
            DataTable userTable = userDBTableAdapter.GetDataByMatrixIdAndPassword(MatrixId, Password);

            if (userTable.Rows.Count > 0)
            {
                role = userTable.Rows[0]["Role"].ToString();
                return true;
            }

            role = string.Empty;
            return false;
        }

        public DataTable GetAllUsers()
        {
            return userDBTableAdapter.GetData();
        }

        public void UpdateUser(string matrixId, string email, string name, string role)
        {
            userDBTableAdapter.updateUser(matrixId, email, name, role);
        }

        public void DeleteUser(string matrixId)
        {
            userDBTableAdapter.deleteUser(matrixId);
        }

        public DataTable GetUserByMatrixId(string matrixId)
        {
            return userDBTableAdapter.GetDataByMatrix(matrixId);
        }

        public void UpdateUserDetails(string matrixId, string password, string email, string name, int phoneNumber, string profilePicPath)
        {
            userDBTableAdapter.updateUserDetail(password, email, name, phoneNumber, profilePicPath, matrixId);
        }

        public void CreateUser()
        {
            UserDBTableAdapter uta = new UserDBTableAdapter();
            uta.createUser(MatrixId, Password, Email, Name, PhoneNumber, MemberStatus, Role, ProfilePic);
        }

        public IEnumerator<User> GetEnumerator()
        {
            DataTable userTable = GetAllUsers();
            List<User> users = new List<User>();

            foreach (DataRow row in userTable.Rows)
            {
                string matrixId = row["matrix_id"].ToString();
                string password = row["password"].ToString();

                User user = User.Builder()
                    .WithMatrixId(matrixId)
                    .WithPassword(password)
                    .Build();

                users.Add(user);
            }

            return users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

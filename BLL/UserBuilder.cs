using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBuilder
    {
        private User user;

        public UserBuilder()
        {
            user = new User();
        }

        public UserBuilder SetMatrixId(string matrixId)
        {
            user.MatrixId = matrixId;
            return this;
        }

        public UserBuilder SetPassword(string password)
        {
            user.Password = password;
            return this;
        }

        public UserBuilder SetEmail(string email)
        {
            user.Email = email;
            return this;
        }

        public UserBuilder SetName(string name)
        {
            user.Name = name;
            return this;
        }

        public UserBuilder SetPhoneNumber(int phoneNumber)
        {
            user.PhoneNumber = phoneNumber;
            return this;
        }

        public UserBuilder SetMemberStatus(string memberStatus)
        {
            user.MemberStatus = memberStatus;
            return this;
        }

        public UserBuilder SetRole(string role)
        {
            user.Role = role;
            return this;
        }

        public UserBuilder SetProfilePic(string profilePic)
        {
            user.ProfilePic = profilePic;
            return this;
        }

        public User Build()
        {
            return user;
        }
    }

}

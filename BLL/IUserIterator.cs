using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class IUserIterator
    {
        public class UserIterator : IUserIterator
        {
            private List<User> users;
            private int position;

            public UserIterator(List<User> users)
            {
                this.users = users;
                position = 0;
            }

            public bool HasNext()
            {
                return position < users.Count;
            }

            public User Next()
            {
                User user = users[position];
                position++;
                return user;
            }
        }
    }
}

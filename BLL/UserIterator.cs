using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class UserIterator
    {
        public interface IUserIterator
        {
            bool HasNext();
            User Next();
        }
    }
}

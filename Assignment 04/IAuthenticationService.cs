using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    public interface IAuthenticationService
    {
        void AuthenticateUser(string userName, int password);
        void AuthorizeUser(string au_user);

    }
}

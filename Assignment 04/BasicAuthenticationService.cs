using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        public string UserName = "Gamal";

        public string Au_User = "Ali";
        public int Password = 12345;
       
        public void AuthenticateUser(string userName,int password )
        {
            UserName = userName;
            Password = password;
            if (UserName == "Gamal" && Password == 12345)
                Console.WriteLine("True");
            else 
                Console.WriteLine("False");

        }

        public void AuthorizeUser(string au_user)

        {
            Au_User = au_user;
                
            if (Au_User == "Ali") 
                Console.WriteLine("True");
        else 
                Console.WriteLine("False");

           
        }
    }
}

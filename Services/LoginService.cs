using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContext.DB;
using DBContext.DB.Models;

namespace DomainModel
{
    public class LoginService : ILoginService
    {
        ShoppingContext sc;
        public LoginService(ShoppingContext sc)
        {
            this.sc = sc;
        }
        public bool Login(User user)
        {
            var result = (from u in sc.Users
                          where user.Login == u.Login &&
                          user.Pass == u.Pass
                          select u).FirstOrDefault();
            return result is not null;
        }
    }
}

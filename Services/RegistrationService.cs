using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContext.DB;
using DBContext.DB.Models;

namespace DomainModel
{
    public class RegistrationService : IRegistrationService
    {
        ShoppingContext sc;
        public RegistrationService(ShoppingContext sc)
        {
            this.sc = sc;
        }
        public void Register(User user)
        {
            //Добавить проверку пользователя по логину
            var finded = (from u in sc.Users
                          where user.Login == u.Login
                          select u).FirstOrDefault();
            if (finded is null)
            {
                sc.Users.Add(user);
                sc.SaveChanges();
            }
            else
                throw new Exception("Логин уже используется");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContext.DB.Models;

namespace DomainModel
{
    public interface IRegistrationService
    {
        void Register(User user);
    }
}

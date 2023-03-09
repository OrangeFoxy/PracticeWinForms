using DBContext.DB.Models;

namespace DomainModel
{
    public interface ILoginService
    {
        // true - успешная авторизация, иначе false
        bool Login(User user);
    }
}

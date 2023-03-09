using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContext.DB.Models;

namespace DomainModel
{
    public interface IMainService
    {
        User GetUser(string login);
        Game CreateGame(User user);
        void UpdateGame(Game game);
        List<string> GetTopScore();
    }
}

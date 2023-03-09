using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContext.DB;
using DBContext.DB.Models;

namespace DomainModel
{
    public class MainService : IMainService
    {
        ShoppingContext sc;
        public MainService(ShoppingContext sc)
        {
            this.sc = sc;

        }
        public User GetUser(string login)
        {
            return (from u in sc.Users
                    where u.Login == login
                    select u).First();
        }
        public Game CreateGame(User user)
        {
            Game g = new();
            g.User = user;
            sc.Games.Add(g);
            sc.SaveChangesAsync();
            return g;
        }
        public void UpdateGame(Game game)
        {
            sc.Games.Update(game);
            sc.SaveChangesAsync();
        }
        public List<string> GetTopScore()
        {
            return sc.Games.OrderByDescending(s => s.Score).Take(10).Select(
                   s => $"[{s.Score}]{s.User.Name}").ToList();
        }
    }
}

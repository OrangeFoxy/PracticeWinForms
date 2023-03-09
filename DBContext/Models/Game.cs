using System.Collections.Generic;

namespace DBContext.DB.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public User User { get; set; }
    }
}

using System.Collections.Generic;

namespace DBContext.DB.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public bool Admin { get; set; }
        public List<Game> Games { get; set; } = new();
        //public List<Product> Products { get; set; } = new();
        //public List<ShoppingCart> ShoppingCarts { get; set; } = new();
    }
}

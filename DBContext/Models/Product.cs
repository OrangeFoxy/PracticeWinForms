using System.Collections.Generic;

namespace DBContext.DB.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<User> Users{ get; set; } = new();
        public List<ShoppingCart> ShoppingCarts { get; set; } = new();
    }
}

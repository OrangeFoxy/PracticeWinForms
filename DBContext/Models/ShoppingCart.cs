namespace DBContext.DB.Models
{
    public class ShoppingCart
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Number { get; set; }
    }
}

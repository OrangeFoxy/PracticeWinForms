using Microsoft.EntityFrameworkCore;
using DBContext.DB.Models;

namespace DBContext.DB
{
    public class ShoppingContext : DbContext
    {
        public string nameDB { get; private set; } = "pr.db";
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public ShoppingContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={nameDB}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().HasAlternateKey(u => u.Login);
            modelBuilder.Entity<User>().Property(u => u.Login).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Pass).HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Pass).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Name).HasMaxLength(100);

            modelBuilder.Entity<Game>().Property(g => g.Score).HasDefaultValue(0);

            //modelBuilder.Entity<Product>().HasKey(u => u.Id);
            //modelBuilder.Entity<Product>().Property(u => u.Name).HasMaxLength(100);

            //modelBuilder.Entity<Product>()
            //    .HasMany(p => p.Users)
            //    .WithMany(u => u.Products)
            //    .UsingEntity<ShoppingCart>(
            //        j => j
            //            .HasOne(pt => pt.User)
            //            .WithMany(p => p.ShoppingCarts)
            //            .HasForeignKey(pt => pt.UserId),
            //        j => j
            //            .HasOne(pt => pt.Product)
            //            .WithMany(p => p.ShoppingCarts)
            //            .HasForeignKey(pt => pt.ProductId),
            //        j =>
            //        {
            //            j.Property(pt => pt.Number).HasDefaultValue(1);
            //            j.HasKey(t => new { t.ProductId, t.UserId });
            //        }
            //    );
        }
    }
}

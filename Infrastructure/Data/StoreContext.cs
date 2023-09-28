using Core.Entities;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class StoreContext :DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderItems { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<OrderStatusType> OrderStatuseTypes { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
      
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

       
            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

      
            modelBuilder.Entity<OrderProduct>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);


            //modelBuilder.Entity<Balance>()
            //    .HasOne(b => b.CreatedByUser)
            //    .WithMany()
            //    .HasForeignKey(b => b.UserId)
            //    .OnDelete(DeleteBehavior.Restrict); // Adjust the delete behavior as needed



        }

    }
}

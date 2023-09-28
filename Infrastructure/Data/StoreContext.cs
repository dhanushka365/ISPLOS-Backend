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

        
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
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

            //modelBuilder.Entity<Order>()
            //    .HasMany(o => o.OrderProducts)
            //    .WithOne(oi => oi.Order)
            //    .HasForeignKey(oi => oi.OrderId);

      
            //modelBuilder.Entity<OrderProduct>()
            //    .HasOne(oi => oi.Order)
            //    .WithMany(o => o.OrderProducts)
            //    .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderProduct>().HasKey(p =>new {p.OrderId,p.ProductId});


            //modelBuilder.Entity<Balance>()
            //    .HasOne(b => b.CreatedByUser)
            //    .WithMany()
            //    .HasForeignKey(b => b.UserId)
            //    .OnDelete(DeleteBehavior.Restrict); // Adjust the delete behavior as needed

            var orderStatusTypes = new List<OrderStatusType>()
            {
                new OrderStatusType()
                {
                    Id = Guid.NewGuid(),
                    Name = "Order Progression",
                    Description = "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.",
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatusType()
                {
                    Id = Guid.NewGuid(),
                    Name = "Financial Transaction",
                    Description = "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.",
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatusType()
                {
                    Id = Guid.NewGuid(),
                    Name = "Authorization and Pay Mod",
                    Description = "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch",
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatusType()
                {
                    Id = Guid.NewGuid(),
                    Name = "Payment Status",
                    Description = "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.",
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatusType()
                {
                    Id = Guid.NewGuid(),
                    Name = "Review and Dispute",
                    Description = "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.",
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                }


                
            };

            modelBuilder.Entity<OrderStatusType>().HasData(orderStatusTypes);









            var orderStatus = new List<OrderStatus>()
            {
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Order Progression-1",
                    Status = "Pending",
                    StatusCode = "101",
                    StatusMessage = "Order is pending",
                    OrderStatusTypeId = orderStatusTypes[0].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Order Progression-2",
                    Status = "Processing",
                    StatusCode = "102",
                    StatusMessage = "Order is processing",
                    OrderStatusTypeId = orderStatusTypes[0].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Order Progression-3",
                    Status = "Shipped",
                    StatusCode = "103",
                    StatusMessage = "Order is shipped",
                    OrderStatusTypeId = orderStatusTypes[0].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Order Progression-4",
                    Status = "Delivered",
                    StatusCode = "104",
                    StatusMessage = "Order is delivered",
                    OrderStatusTypeId = orderStatusTypes[0].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Order Progression-5",
                    Status = "Cancelled",
                    StatusCode = "105",
                    StatusMessage = "Order is cancelled",
                    OrderStatusTypeId = orderStatusTypes[0].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Financial Transaction-1",
                    Status = "Pending",
                    StatusCode = "201",
                    StatusMessage = "Financial transaction is pending",
                    OrderStatusTypeId = orderStatusTypes[1].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Financial Transaction-2",
                    Status = "Processing",
                    StatusCode = "202",
                    StatusMessage = "Financial transaction is processing",
                    OrderStatusTypeId = orderStatusTypes[1].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Financial Transaction-3",
                    Status = "Completed",
                    StatusCode = "203",
                    StatusMessage = "Financial transaction is completed",
                    OrderStatusTypeId = orderStatusTypes[1].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Financial Transaction-4",
                    Status = "Cancelled",
                    StatusCode = "204",
                    StatusMessage = "Financial transaction is cancelled",
                    OrderStatusTypeId = orderStatusTypes[1].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Authorization and Pay Mod-1",
                    Status = "Verified",
                    StatusCode = "301",
                    StatusMessage = "Payment method verified",
                    OrderStatusTypeId = orderStatusTypes[2].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Payment Status-1",
                    Status = "Paid",
                    StatusCode = "401",
                    StatusMessage = "Order Paid",
                    OrderStatusTypeId = orderStatusTypes[1].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                 new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Payment Status-2",
                    Status = "partially Paid",
                    StatusCode = "402",
                    StatusMessage = "Order Partially Paid",
                    OrderStatusTypeId = orderStatusTypes[1].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                },
                   new OrderStatus()
                {
                    Id = Guid.NewGuid(),
                    Name = "Payment Status-3",
                    Status = "unPaid",
                    StatusCode = "403",
                    StatusMessage = "Order is UnPaid",
                    OrderStatusTypeId = orderStatusTypes[1].Id,
                    CreatedAt = System.DateTime.Now,
                    UpdatedAt = System.DateTime.Now
                }



            };

            modelBuilder.Entity<OrderStatus>().HasData(orderStatus);

        }

    }
}

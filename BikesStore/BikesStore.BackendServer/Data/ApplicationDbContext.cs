using BikesStore.BackendServer.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BikesStore.BackendServer
{
    public class ApplicationDbContext : /*IdentityDbContext*/DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        #region Database first  
        // Ignore when migration identity table  
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Order_Item> Order_Items { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Staff> Staffs { get; set; } = null!;
        public DbSet<Stock> Stocks { get; set; } = null!;
        public DbSet<Store> Stores { get; set; } = null!;

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add Microsoft.EntityFrameworkCore.SqlServer to use
            modelBuilder.Entity<Category>().ToTable("categories", "production"); // schema: production, tablename: categories
            modelBuilder.Entity<Brand>().ToTable("brands", "production");
            modelBuilder.Entity<Customer>().ToTable("customers", "sales");
            modelBuilder.Entity<Order>().ToTable("orders", "sales");
            modelBuilder.Entity<Order_Item>().ToTable("order_items", "sales");
            modelBuilder.Entity<Product>().ToTable("products", "production");
            modelBuilder.Entity<Staff>().ToTable("staffs", "sales");
            modelBuilder.Entity<Stock>().ToTable("stocks", "production");
            modelBuilder.Entity<Store>().ToTable("stores", "sales");
            base.OnModelCreating(modelBuilder);
        }
    }
}

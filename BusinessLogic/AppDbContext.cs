using BusinessLogic.Configurations;
using BusinessLogic.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Distance> Distances => Set<Distance>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Resource> Resources => Set<Resource>();
        public DbSet<ProductResource> ProductResources => Set<ProductResource>();
        public DbSet<ProductWarehouse> ProductWarehouses => Set<ProductWarehouse>();
        public DbSet<Shop> Shops => Set<Shop>();
        public DbSet<Warehouse> Warehouses => Set<Warehouse>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            var parentDirectory = projectDirectory;

            for (int i = 0; i < 4; i++)
            {
                parentDirectory = Directory.GetParent(parentDirectory)?.FullName;
                if (parentDirectory == null) throw new InvalidOperationException("Путь не существует");
            }
            var dbPath = Path.Combine(parentDirectory, "dbBussinesLogic.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new DistanceConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new ProductResourceConfiguration());
            modelBuilder.ApplyConfiguration(new ProductWarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new ShopConfiguration());
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
        }

    }
}

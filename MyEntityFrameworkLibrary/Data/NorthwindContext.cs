using System;
using System.Runtime.CompilerServices;
using ConfigurationLibrary.Classes;
using Microsoft.EntityFrameworkCore;
using MyEntityFrameworkLibrary.Models;

#nullable disable

#nullable disable

namespace MyEntityFrameworkLibrary.Data
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
        }

        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusinessEntityPhone> BusinessEntityPhone { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<ContactDevices> ContactDevices { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<EmployeeTerritories> EmployeeTerritories { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Territories> Territories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind2020;Integrated Security=True");
                optionsBuilder.UseSqlServer(ConfigurationHelper.ConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new Configurations.BusinessEntityPhoneConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ContactDevicesConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ContactTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ContactsConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.CountriesConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.CustomersConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.EmployeeTerritoriesConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.EmployeesConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.OrderDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.OrdersConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PhoneTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ProductsConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.RegionConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ShippersConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SuppliersConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.TerritoriesConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - EF Core";
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SchemaMockUp.Models
{
    class EFContext : DbContext
    {
        const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Database=DemoModelDB;Trusted_Connection=True";

        //public EFContext()
        //{
        //    var builder = new ConfigurationBuilder();
        //    builder.AddJsonFile("appsettings.json", optional: false);

        //    var configuration = builder.Build();

        //    connectionString = configuration.GetConnectionString("sqlConnection");
        //}



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> User { get; set; }
    }
}

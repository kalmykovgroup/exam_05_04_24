using exam_05_04_24.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exam_05_04_24.data
{
    internal class ApplicationDbContext : DbContext
    { 

        string connectionString = $"Server=localhost;port=3306;Database=AccademyTest;Uid=root;Pwd=;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 11))); 
        }

        public DbSet<User> Users => Set<User>();
        public ApplicationDbContext() => Database.EnsureCreated();

       


    }

    
}

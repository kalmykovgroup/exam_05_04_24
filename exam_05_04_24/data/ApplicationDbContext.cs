using exam_05_04_24.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace exam_05_04_24.data
{
    internal class ApplicationDbContext : DbContext
    { 

        private static string connectionString = $"Server=localhost;port=3306;Database=academy;Uid=root;Pwd=;";
 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString); 
        }
         

        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<HomeWork> HomeWorks { get; set; }
        public DbSet<Schedule> Schedules { get; set; }  //Рассписание занятий
        public DbSet<Subject> Subjects { get; set; }  //Предметы (C#, C++, PHP ...)
 


        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

    }

    
}

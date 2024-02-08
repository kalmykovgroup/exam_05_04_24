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

        private DbConnection GetConnection()
        {
            DbConnection mySqlConnection = new MySqlConnection(connectionString);
            try
            { 
                mySqlConnection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Ошибка при попытке установить соединение с интернетом," +
                    " Приложение не может дальше продолжать работать!");
                System.Windows.Application.Current.Shutdown();
            }

            return mySqlConnection;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(GetConnection(), null); 
        }

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

    }

    
}

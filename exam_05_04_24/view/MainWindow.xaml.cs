﻿using exam_05_04_24.data;
using exam_05_04_24.model;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace exam_05_04_24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                // создаем два объекта User
                User tom = new User { Login = "Tom", Password = "123" }; 

                // добавляем их в бд
                db.Users.Add(tom); 
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
               
            }




        }
    }
}
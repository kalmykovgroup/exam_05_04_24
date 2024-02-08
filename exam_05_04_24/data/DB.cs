using Microsoft.Data.SqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace exam_05_04_24.data
{
    internal class DB
    {
        private static readonly string database = @"Data Source=(localdb)\.;Integrated Security=True";

        public static IDbConnection Connection
        {
            get
            {

                IDbConnection sqlConnection = new SqlConnection(database);
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n Приложение не может дальше продолжать работать!");
                    System.Windows.Application.Current.Shutdown();
                }

                return sqlConnection;

            }
        }

    }
}

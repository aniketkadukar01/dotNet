using ECommerceApp.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace ECommerceApp.Repositories
{
    public static class UserRepository
    {
       public static string connectionstring = "Server=localhost;" +
                "Port=3306;" +
                "Database=products;" +
                "User=root;" +
                "Password=2911;";
        static MySqlConnection connection = new MySqlConnection(connectionstring);
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                connection.Open();
                string query = "select* from products;";
                MySqlCommand command = new MySqlCommand(query, connection);
                //command.CommandText = query;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("product_id");
                    string category = reader.GetString("categories");
                    DateTime date = reader.GetDateTime("date_of_manufacturing");
                    string code = reader.GetString("product_code");
                    string productName = reader.GetString("product_name");
                    User user = new User();
                    user.FirstName = category;
                    user.LastName = productName;
                    user.Email = code;
                    users.Add(user);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return users;
        }

        public static void delete(int id)
        {
            try
            {
                string query = "delete from products where id = " + id;
                MySqlCommand command = new MySqlCommand(query,connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally{ }
        }

        public static bool Insert(User user)
        { 
            return false;
        }

    }
}

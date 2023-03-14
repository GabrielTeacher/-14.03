using ConsoleApp23.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Data
{
    internal class ProductData
    {
        public void Add(Product product)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO product(Name, Price, Stock) VALUES(@name, @price, @stock)", connection);
                command.Parameters.AddWithValue("name", product.Name);
                command.Parameters.AddWithValue("price", product.Price);
                command.Parameters.AddWithValue("stock", product.Stock);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        public List<Product> GetAll()
        {
            var productList = new List<Product>();

            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM product", connection);
                connection.Open();
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDecimal(2),
                            reader.GetInt32(3)
                            );
                        productList.Add(product);
                    }
                }
                connection.Close();
            }
            return productList;
        }
    }
}

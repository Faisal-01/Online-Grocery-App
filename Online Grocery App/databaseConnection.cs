using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Online_Grocery_App
{
    public class databaseConnection
    {
        public string dbconnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-1IMRK9O\\SQLEXPRESS";
            builder.InitialCatalog = "online_grocery_app";
            builder.UserID = "sa";
            builder.Password = "1234";
            return builder.ConnectionString;
        }

        public List<Product> getData(string query)
        {
            SqlConnection connection = new SqlConnection(dbconnection());
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> list = new List<Product>();
            while (reader.Read())
            {
                list.Add(new Product(Int32.Parse(reader[0].ToString()), reader[1].ToString(), Double.Parse(reader[2].ToString()), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
            }
            connection.Close();
            return list;
        }

        public Product getProduct(int id)
        {
            SqlConnection connection = new SqlConnection(dbconnection());
            connection.Open();
            string query = @"select products.id, product_name,product_price, product_description, product_brand, category_name, nameOfType, product_picture from products
                                inner join category
                                on products.category = category.id
                                left join product_type
                                on products.p_type = product_type.id
                                where products.id = " + id.ToString();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            Product product = null;
            while (reader.Read())
            {
                product = new Product(Int32.Parse(reader[0].ToString()), reader[1].ToString(), Double.Parse(reader[2].ToString()), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString());
            }
            connection.Close();
            return product;
        }
    }
}
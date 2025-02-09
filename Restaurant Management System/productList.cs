using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Restaurant_Management_System
{

    internal class productList
    {
        string connectionString = "server=localhost;database=RestaurantMSdb;user=root;password=Hong@@11;";

        public int ID { get; set; }
        public string productid { get; set; }
        public string productname { get; set; }
        public string category { get; set; }
        public int stock { get; set; }
        public string price { get; set; }
        public string status { get; set; }
        public string image { get; set; }
        public string dateInsert { get; set; }
        public string dateUpdate { get; set; }

        public List<productList> productListData()
        {
            List<productList> listData = new List<productList>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM products";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        productList pData = new productList();
                        pData.ID = (int)reader["id"];
                        pData.productid = reader["productid"].ToString();
                        pData.productname = reader["productname"].ToString();
                        pData.category = reader["category"].ToString();
                        pData.stock = (int)reader["stock"];
                        pData.price = reader["price"].ToString();
                        pData.status = reader["status"].ToString();
                        pData.image = reader["image"].ToString();
                        pData.dateInsert = ((DateTime)reader["date_create"]).ToString("dd-MM-yyyy");
                        pData.dateUpdate=reader["date_update"]== DBNull.Value ? "" : ((DateTime)reader["date_update"]).ToString("dd-MM-yyyy");
                        //pData.dateUpdate = ((DateTime)reader["date_update"]).ToString("dd-MM-yyyy");
                        listData.Add(pData);
                    }
                }
            }
            return listData;
        }
    }
}

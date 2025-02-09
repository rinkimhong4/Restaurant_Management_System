using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace Restaurant_Management_System

{
    internal class categoryListFrm
    {
        string connectionString = "server=localhost;database=RestaurantMSdb;user=root;password=Hong@@11;";
        public int ID { get; set; }
        public string category { get; set; }
        public string status { get; set; }
        public string date_insert { get; set; }

        public List<categoryListFrm> CategoryListData()
        {
            List<categoryListFrm> listData = new List<categoryListFrm>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM categories";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        categoryListFrm cData = new categoryListFrm();
                        cData.ID = (int)reader["id"];
                        cData.category = reader["category"].ToString();
                        cData.status = reader["status"].ToString();
                        cData.date_insert = ((DateTime)reader["date_insert"]).ToString("dd-MM-yyyy");

                        listData.Add(cData);
                    }
                }
            }

            return listData;

        }
    }
}

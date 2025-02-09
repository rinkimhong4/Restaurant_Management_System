using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    internal class customerList
    {
        string connectionString = "server=localhost;database=RestaurantMSdb;user=root;password=Hong@@11;";

        public int id { get; set; }
        public string customerId { get; set; }
        public string productIds { get; set; }
        public string quantities { get; set; }
        public string prices { get; set; }
        public string totalPrice { get; set; }
        public string dateOrdered { get; set; }  // Corrected property name

        // Making customerListData public
        public List<customerList> customerListData()
        {
            List<customerList> listData = new List<customerList>();

            try
            {
                using (MySqlConnection Con = new MySqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "SELECT * FROM orders";
                    using (MySqlCommand cmd = new MySqlCommand(query, Con))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            customerList cData = new customerList();
                            cData.id = (int)reader["id"];
                            cData.customerId = reader["customerId"].ToString();
                            cData.productIds = reader["productIds"].ToString();
                            cData.quantities = reader["quantities"].ToString();
                            cData.prices = reader["prices"].ToString();
                            cData.totalPrice = reader["total"].ToString();
                            cData.dateOrdered = ((DateTime)reader["date_order"]).ToString("dd/MM/yyyy");

                            listData.Add(cData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database connection or query
                MessageBox.Show("Error: " + ex.Message);
            }

            return listData;
        }




        public List<customerList> totalSaleCustomerlistData()
        {
            List<customerList> listData = new List<customerList>();

            try
            {
                using (MySqlConnection Con = new MySqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "SELECT * FROM orders WHERE date_order =@date";
                    using (MySqlCommand cmd = new MySqlCommand(query, Con))
                    {

                        DateTime today = DateTime.Now;
                        string getToday = today.ToString("yyyy-MM-dd");
                        cmd.Parameters.AddWithValue("@date", getToday);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            customerList cData = new customerList();
                            cData.id = (int)reader["id"];
                            cData.customerId = reader["customerId"].ToString();
                            cData.productIds = reader["productIds"].ToString();
                            cData.quantities = reader["quantities"].ToString();
                            cData.prices = reader["prices"].ToString();
                            cData.totalPrice = reader["total"].ToString();
                            cData.dateOrdered = ((DateTime)reader["date_order"]).ToString("dd/MM/yyyy");

                            listData.Add(cData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database connection or query
                MessageBox.Show("Error: " + ex.Message);
            }

            return listData;
        }
    }
}

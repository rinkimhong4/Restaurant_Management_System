using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Dashboard : UserControl
    {
        private readonly string connectionString = "server=localhost;database=RestaurantMSdb;user=root;password=Hong@@11;";

        public Dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            displayTotalUser();
            displayTotalProduct();
            displayTodayRevenues();
            displayTotalRevenues();
            displayTotalSale();
        }

        private void displayTotalSale()
        {
            try
            {
                customerList cData = new customerList();
                List<customerList> listData = cData.customerListData();
                dataGridView1.DataSource = listData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayTotalUser()
        {
            try
            {
                using (MySqlConnection Con = new MySqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "SELECT COUNT(*) FROM users";
                    using (MySqlCommand cmd = new MySqlCommand(query, Con))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        dashboard_TotalUser.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayTotalProduct()
        {
            try
            {
                using (MySqlConnection Con = new MySqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "SELECT COUNT(*) FROM products";
                    using (MySqlCommand cmd = new MySqlCommand(query, Con))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        dashboard_TotalProduct.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayTodayRevenues()
        {
            try
            {
                using (MySqlConnection Con = new MySqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "SELECT SUM(CAST(total AS DECIMAL(10,2))) FROM orders WHERE DATE(date_order) = CURDATE()";
                    using (MySqlCommand cmd = new MySqlCommand(query, Con))
                    {
                        object result = cmd.ExecuteScalar();
                        decimal revenues = result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0;
                        dashboard_TodayRevenue.Text = revenues.ToString("C2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading today's revenue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayTotalRevenues()
        {
            try
            {
                using (MySqlConnection Con = new MySqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "SELECT SUM(CAST(total AS DECIMAL(10,2))) FROM orders";
                    using (MySqlCommand cmd = new MySqlCommand(query, Con))
                    {
                        object result = cmd.ExecuteScalar();
                        decimal revenues = result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0;
                        dashboard_TotalRevenue.Text = revenues.ToString("C2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading total revenue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

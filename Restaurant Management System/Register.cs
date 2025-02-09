using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Restaurant_Management_System
{
    public partial class Register : Form
    {
        private readonly string connectionString = "server=localhost;database=RestaurantMSdb;user=root;password=Hong@@11;";

        public Register()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backTolog_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtRePassword.Focus();
            }
        }

        private void txtRePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnSignup.PerformClick();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();
            string rePassword = txtRePassword.Text.Trim();


            using (MySqlConnection Con1 = new MySqlConnection(connectionString))
            {
                Con1.Open();
                string query1 = "SELECT * FROM users WHERE username = @username";
                using (MySqlCommand cmd1 = new MySqlCommand(query1, Con1))
                {
                    cmd1.Parameters.AddWithValue("@username", username);
                    using (MySqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        if (reader1.HasRows)
                        {
                            MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (password.Length < 8)
                        {
                            MessageBox.Show("Password must be at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (password != rePassword)
                        {
                            MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                using (MySqlConnection Con = new MySqlConnection(connectionString))
                                {
                                    Con.Open();
                                    string query = "INSERT INTO users (username, password,status) VALUES (@username, @password,@status)";
                                    using (MySqlCommand cmd = new MySqlCommand(query, Con))
                                    {
                                        cmd.Parameters.AddWithValue("@username", username);
                                        cmd.Parameters.AddWithValue("@password", password);
                                        cmd.Parameters.AddWithValue("@status", "Active");
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("User Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtUsername.Clear();
                                        txtPassword.Clear();
                                        txtRePassword.Clear();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}

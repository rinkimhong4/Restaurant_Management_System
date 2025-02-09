using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurant_Management_System
{
    public partial class CategoryControl : UserControl
    {
        private readonly string connectionString = "server=localhost;database=RestaurantMSdb;user=root;password=Hong@@11;";
        private int selectedCategoryId = 0;

        public CategoryControl()
        {
            InitializeComponent();

        }



        public void DisplayCategories()
        {
            categoryListFrm categoryData = new categoryListFrm();
            List<categoryListFrm> listData = categoryData.CategoryListData();
            dataGridView1.DataSource = listData;
        }

        private void CategoryControl_Load(object sender, EventArgs e)
        {
            DisplayCategories();
            cmbCategory.SelectedIndex = 0;
        }

        private void ClearText()
        {
            txtCategory_Category.Text = "";
            cmbCategory.SelectedIndex = 0;
            selectedCategoryId = 0;
        }



        private void btnCategoryClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void bntCategory_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory_Category.Text) || cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string checkQuery = "SELECT COUNT(*) FROM categories WHERE category = @category";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@category", txtCategory_Category.Text.Trim());
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Category already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = "INSERT INTO categories (category, status, date_insert) VALUES (@category, @status, @date_insert)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@category", txtCategory_Category.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@status", cmbCategory.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@date_insert", DateTime.Now);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategory_Category.Clear();
                DisplayCategories();
            }
        }

        private void bntCategory_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void dataGridView_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells[0].Value != null) // Ensure the ID is not null
                {
                    selectedCategoryId = Convert.ToInt32(row.Cells[0].Value);
                    txtCategory_Category.Text = row.Cells[1].Value.ToString();
                    cmbCategory.SelectedItem = row.Cells[2].Value?.ToString(); // Handle null values
                }
            }
        }

        private void bntCategory_Update_Click(object sender, EventArgs e)
        {

            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show($"Are you sure want to Update this ID: {selectedCategoryId}", "Confirm  Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string updateQuery = "UPDATE categories SET category = @category, status = @status WHERE id = @id";
                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@id", selectedCategoryId);
                            updateCmd.Parameters.AddWithValue("@category", txtCategory_Category.Text.Trim());
                            updateCmd.Parameters.AddWithValue("@status", cmbCategory.SelectedItem.ToString());
                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Category updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearText();
                        }

                        con.Close();
                    }
                }
            }
            DisplayCategories();
        }

        private void bntCategory_Delete_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show($"Are you sure want to Delete this ID: {selectedCategoryId}", "Confirm  Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string updateQuery = "DELETE FROM categories WHERE id = @id";
                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@id", selectedCategoryId);

                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Delete successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearText();
                        }
                        con.Close();
                    }
                }
            }
            DisplayCategories();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells[0].Value != null) // Ensure the ID is not null
                {
                    selectedCategoryId = Convert.ToInt32(row.Cells[0].Value);
                    txtCategory_Category.Text = row.Cells[1].Value.ToString();
                    cmbCategory.SelectedItem = row.Cells[2].Value?.ToString(); // Handle null values
                }
            }
        }
    }
}
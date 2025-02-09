using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Restaurant_Management_System
{
    public partial class InventoryControl : UserControl
    {
        string connectionString = "server=localhost;database=RestaurantMSdb;user=root;password=Hong@@11;";

        public InventoryControl()
        {
            InitializeComponent();
            DisplayCategories();
            DisplayProducts();
        }

        public void DisplayCategories()
        {
            Inventory_cmbCateg.Items.Clear();

            using (MySqlConnection Con = new MySqlConnection(connectionString))
            {
                Con.Open();
                string query = "SELECT * FROM categories WHERE status ='Active'";
                using (MySqlCommand cmd = new MySqlCommand(query, Con))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Inventory_cmbCateg.Items.Add(dr["category"].ToString());
                    }
                }
            }
        }

        public void DisplayProducts()
        {
            productList productData = new productList();
            List<productList> listData = productData.productListData();
            dataGridView_Inven.DataSource = listData;
        }

        private void Inventory_btnAdd_Click(object sender, EventArgs e)
        {

            if (Inventory_ProductId.Text == "" || Inventory_ProductName.Text == "" || Inventory_cmbCateg.SelectedIndex == -1 || Inventory_Stock.Text == "" || Inventory_ProductPrice.Text == "" || Inventory_Status.Text == "" || Inventory_Image.Image == null)
            {
                MessageBox.Show("Please fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                using (MySqlConnection Con = new MySqlConnection(connectionString))
                {
                    try
                    {
                        Con.Open();

                        string checkProductid = "SELECT * FROM products WHERE productid = @productid";
                        using (MySqlCommand chProductid = new MySqlCommand(checkProductid, Con))
                        {
                            chProductid.Parameters.AddWithValue("@productid", Inventory_ProductId.Text.Trim());

                            MySqlDataAdapter adapter = new MySqlDataAdapter(chProductid);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                MessageBox.Show($"Product ID '{Inventory_ProductId.Text}' Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string relativePath = Path.Combine("products_directory", Inventory_ProductId.Text.Trim() + ".jpg");
                        string path = Path.Combine(baseDirectory, relativePath);
                        string directoryPath = Path.GetDirectoryName(path);

                        // Ensure the directory exists
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        // Copy the image safely
                        if (!string.IsNullOrEmpty(Inventory_Image.ImageLocation))
                        {
                            File.Copy(Inventory_Image.ImageLocation, path, true);
                        }
                        else
                        {
                            MessageBox.Show("No image selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string query = "INSERT INTO products (productid, productname, category, stock, price, status, image, date_create) " +
                                       "VALUES (@productid, @productname, @category, @stock, @price, @status, @image, @date)";

                        using (MySqlCommand cmd = new MySqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@productid", Inventory_ProductId.Text.Trim());
                            cmd.Parameters.AddWithValue("@productname", Inventory_ProductName.Text.Trim());
                            cmd.Parameters.AddWithValue("@category", Inventory_cmbCateg.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@stock", Inventory_Stock.Text.Trim());
                            cmd.Parameters.AddWithValue("@price", Inventory_ProductPrice.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", Inventory_Status.SelectedItem?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@date", DateTime.Today);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (MySqlException sqlEx)
                    {
                        MessageBox.Show($"Database Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show($"File Error: {ioEx.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            DisplayProducts();
        }

        private void Inventory_ImportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";

                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    Inventory_Image.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void ClearText()
        {
            //
            Inventory_ProductId.Clear();
            Inventory_ProductName.Clear();
            Inventory_cmbCateg.SelectedIndex = -1;
            Inventory_Stock.Clear();
            Inventory_ProductPrice.Clear();
            Inventory_Status.SelectedIndex = -1;
            Inventory_Image.Image = null;
            getId = 0;
        }

        int getId = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_Inven.Rows[e.RowIndex];
                getId = Convert.ToInt32(row.Cells[0].Value);
                Inventory_ProductId.Text = row.Cells[1].Value.ToString();
                Inventory_ProductName.Text = row.Cells[2].Value.ToString();
                Inventory_cmbCateg.SelectedItem = row.Cells[3].Value.ToString();
                Inventory_Stock.Text = row.Cells[4].Value.ToString();
                Inventory_ProductPrice.Text = row.Cells[5].Value.ToString();
                Inventory_Status.SelectedItem = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[7].Value.ToString();
                try
                {
                    if (imagePath != null)
                        Inventory_Image.Image = Image.FromFile(imagePath);
                    else
                        Inventory_Image.Image = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Inventory_btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void Inventory_btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to update this {getId}?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (getId == 0)
                {
                    MessageBox.Show("Please select a product to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (MySqlConnection Con = new MySqlConnection(connectionString))
                    {
                        Con.Open();
                        string query = "SELECT * FROM products WHERE productid = @productid ";
                        using (MySqlCommand checkProid = new MySqlCommand(query, Con))
                        {
                            checkProid.Parameters.AddWithValue("@productid", Inventory_ProductId.Text.Trim());

                            MySqlDataAdapter adapter = new MySqlDataAdapter(checkProid);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 2)
                            {
                                MessageBox.Show("Product ID Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {

                                string updateData = "UPDATE products SET productid = @productid,productname =@productname,category=@category,stock=@stock,price=@price,status=@status,date_update=@date_update WHERE id = @id";
                                using (MySqlCommand cmd = new MySqlCommand(updateData, Con))
                                {
                                    cmd.Parameters.AddWithValue("@productid", Inventory_ProductId.Text.Trim());
                                    cmd.Parameters.AddWithValue("@productname", Inventory_ProductName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@category", Inventory_cmbCateg.SelectedItem.ToString()); //Erro
                                    cmd.Parameters.AddWithValue("@stock", Inventory_Stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", Inventory_ProductPrice.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", Inventory_Status.SelectedItem.ToString());


                                    DateTime today = DateTime.Now;
                                    cmd.Parameters.AddWithValue("@date_update", today);
                                    cmd.Parameters.AddWithValue("@id", getId);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Product Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            DisplayProducts();
        }

        private void Inventory_btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to update this {getId}?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (getId == 0)
                {
                    MessageBox.Show("Please select a product to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (MySqlConnection Con = new MySqlConnection(connectionString))
                    {
                        Con.Open();
                        string query = "DELETE FROM products WHERE id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@id", getId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            DisplayProducts();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class ShopControl : UserControl
    {
        private readonly string connectionString = "server=localhost;database=RestaurantMSdb;user=root;password=Hong@@11;";

        public ShopControl()
        {
            InitializeComponent();
            displayProduct();
        }

        public void cardItems(int id, string productname, string stock, string price, string productid, string category, string quantity, string imagePath)
        {
            var card = new cardProduct()
            {
                id = id,
                productname = productname,
                productStock = stock,
                productPrice = price,
                productid = productid,
                category = category,
                productQuantity = quantity,
            };

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    card.productImage = Image.FromFile(imagePath);
                }
                catch
                {
                    card.productImage = null;
                }
            }
            else
            {
                card.productImage = null;
            }

            flowLayoutPanel2.Controls.Add(card);

            card.selectCard += (q, w) =>
            {
                var selectedCard = (cardProduct)q;
                bool found = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["id"].Value != null && (int)row.Cells["id"].Value == selectedCard.id)
                    {
                        decimal getPrice = Convert.ToDecimal(selectedCard.productPrice.Replace("$", ""));
                        int getQty = Convert.ToInt32(selectedCard.productQuantity);

                        row.Cells["price"].Value = getPrice * getQty;
                        row.Cells["Qty"].Value = getQty;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    decimal getPrice = Convert.ToDecimal(selectedCard.productPrice.Replace("$", ""));
                    int getQty = Convert.ToInt32(selectedCard.productQuantity);

                    dataGridView1.Rows.Add(selectedCard.id, selectedCard.productname, getQty, getPrice * getQty);
                }
                updateTotalPrice();
            };

            card.quantityChanged += (q, w) =>
            {
                var selectedCard = (cardProduct)q;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["id"].Value != null && (int)row.Cells["id"].Value == selectedCard.id)
                    {
                        int qty = Convert.ToInt32(selectedCard.productQuantity);
                        row.Cells["Qty"].Value = qty;

                        if (qty == 0)
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                        else
                        {
                            decimal getPrice = Convert.ToDecimal(selectedCard.productPrice.Replace("$", ""));
                            row.Cells["price"].Value = getPrice * qty;
                        }
                        break;
                    }
                }

                updateTotalPrice();
            };

        }


        private void updateTotalPrice()
        {
            decimal totalPrice = 0;
            Console.WriteLine("Updating total price...");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["id"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                    totalPrice += price;
                    Console.WriteLine($"Item: {row.Cells["id"].Value}, Price: {price}");
                }
            }

            shop_total.Text = $"{totalPrice:c2}";
            Console.WriteLine($"New Total Price: {shop_total.Text}");
        }


        public void displayProduct()
        {
            try
            {
                using (MySqlConnection Con = new MySqlConnection(connectionString))
                {
                    Con.Open();
                    string query = "SELECT * FROM products";
                    using (MySqlCommand cmd = new MySqlCommand(query, Con))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        flowLayoutPanel2.Controls.Clear();

                        foreach (DataRow row in table.Rows)
                        {
                            int id = row["id"] != DBNull.Value ? Convert.ToInt32(row["id"]) : 0;
                            string productname = row["productname"]?.ToString() ?? "N/A";
                            string stock = row["stock"]?.ToString() ?? "0";
                            string price = row["price"] != DBNull.Value ? $"${row["price"].ToString()}.00" : "$0.00";
                            string productid = row["productid"]?.ToString() ?? "N/A";
                            string category = row["category"]?.ToString() ?? "N/A";
                            string imagePath = row["image"]?.ToString() ?? "";

                            cardItems(id, productname, stock, price, productid, category, "0", imagePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShopControl_Load(object sender, EventArgs e)
        {
        }

        bool check = false;
        private void shop_change_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    decimal getTotal = Convert.ToDecimal(shop_total.Text.ToString().Replace("$", ""));
                    decimal getChange = Convert.ToDecimal(shop_change.Text);

                    if (getTotal > getChange)
                    {
                        MessageBox.Show("Insufficient amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // return;
                    }
                    else
                    {
                        check = true;
                        shop_amount.Text = $"{getChange - getTotal:c2}";

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading products: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Insufficient amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            else
            {
                if (MessageBox.Show("Are you want to proceed", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection Con = new MySqlConnection(connectionString))
                    {
                        Con.Open();
                        string countDate = "SELECT COUNT(*) FROM orders";
                        int count = 1;
                        using (MySqlCommand cDate = new MySqlCommand(countDate, Con))
                        {
                            count = Convert.ToInt32(cDate.ExecuteScalar()) + 1;
                        }

                        List<string> productids = new List<string>();
                        List<string> quantities = new List<string>();
                        List<string> prices = new List<string>();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["id"].Value != null && row.Cells["price"].Value != null)
                            {
                                productids.Add(row.Cells["id"].Value.ToString());
                                quantities.Add(row.Cells["Qty"].Value.ToString());
                                prices.Add(row.Cells["price"].Value.ToString());
                            }
                        }

                        string productidsStr = string.Join(",", productids);
                        string quantitiesStr = string.Join(",", quantities);
                        string pricesStr = string.Join(",", prices);
                        decimal totalAmount = Convert.ToDecimal(shop_total.Text.ToString().Replace("$", ""));

                        string insertDate = "INSERT INTO orders (customerId,productids,quantities,prices,total,date_order) VALUES(@cid,@pid,@qty,@price,@total,@date)";

                        using (MySqlCommand cmd = new MySqlCommand(insertDate, Con))
                        {
                            cmd.Parameters.AddWithValue("@cid", $"CID-{count}");
                            cmd.Parameters.AddWithValue("@pid", productidsStr);
                            cmd.Parameters.AddWithValue("@qty", quantitiesStr);
                            cmd.Parameters.AddWithValue("@price", pricesStr);
                            cmd.Parameters.AddWithValue("@total", totalAmount);

                            DateTime today = DateTime.Now;

                            cmd.Parameters.AddWithValue("@date", today);

                            int rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                for (int q = 0; q < productids.Count; q++)
                                {

                                    string getStockData = "SELECT stock FROM products WHERE id = @id";
                                    int currentStock = 0;
                                    using (MySqlCommand getSD = new MySqlCommand(getStockData, Con))
                                    {
                                        getSD.Parameters.AddWithValue("@id", productids[q]);
                                        object result = getSD.ExecuteScalar();
                                        if (result != null)
                                        {
                                            currentStock = Convert.ToInt32(result);
                                        }
                                    }

                                    int newStock = currentStock - Convert.ToInt32(quantities[q]);
                                    if (newStock < 0)
                                    {
                                        MessageBox.Show($"Insufficient stock for product ID:{productids[q]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    string updateData = "UPDATE products SET stock = @qty WHERE id = @id";
                                    using (MySqlCommand updateCmd = new MySqlCommand(updateData, Con))
                                    {
                                        updateCmd.Parameters.AddWithValue("@qty", newStock);
                                        updateCmd.Parameters.AddWithValue("@id", productids[q]);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }
                               
                                MessageBox.Show("Order has been placed successfully", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error placing order", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        int indexRow = 0;
        private void btn_Receipt_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            indexRow = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = e.MarginBounds.Top; 
            int colWidth = 120; 
            int rowHeight = 30; 
            int headerMargin = 10; 
            int tableMargin = 20; 

            Font font = new Font("Arial", 12);
            Font boldFont = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            Pen pen = new Pen(Color.Black, 1.5f);

            StringFormat centerAlign = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            string headerText = "BoyHong's Restaurant";
            float headerX = e.MarginBounds.Left + (e.MarginBounds.Width / 2);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerX, y, centerAlign);
            y += headerFont.GetHeight(e.Graphics) + headerMargin;

            string[] headers = { "PID", "Product", "Quantity", "Price" };
            float x = e.MarginBounds.Left;

            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, x, y, colWidth, rowHeight);
                e.Graphics.DrawRectangle(pen, x, y, colWidth, rowHeight);
                e.Graphics.DrawString(headers[i], boldFont, Brushes.Black, new RectangleF(x, y, colWidth, rowHeight), centerAlign);
                x += colWidth;
            }

            y += rowHeight; 

            while (indexRow < dataGridView1.Rows.Count)
            {
                x = e.MarginBounds.Left;
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                for (int j = 0; j < headers.Length; j++)
                {
                    object cellValue = row.Cells[j].Value;
                    string cellText = (cellValue != null) ? cellValue.ToString() : "";

                    e.Graphics.DrawRectangle(pen, x, y, colWidth, rowHeight);
                    e.Graphics.DrawString(cellText, font, Brushes.Black, new RectangleF(x, y, colWidth, rowHeight), centerAlign);
                    x += colWidth;
                }

                y += rowHeight;
                indexRow++;

                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            float footerY = e.MarginBounds.Bottom - 120;
            float footerX = e.MarginBounds.Right - 200;

            e.Graphics.DrawString("Total Price:", labelFont, Brushes.Black, footerX, footerY);
            e.Graphics.DrawString($"${shop_total.Text.Trim()}", labelFont, Brushes.Blue, footerX + 120, footerY);

            footerY += labelFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString("Amount Paid:", labelFont, Brushes.Black, footerX, footerY);
            e.Graphics.DrawString($"${shop_change.Text.Trim()}", labelFont, Brushes.Green, footerX + 120, footerY);

            footerY += labelFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString("Change:", labelFont, Brushes.Black, footerX, footerY);
            e.Graphics.DrawString($"${shop_amount.Text.Trim()}", labelFont, Brushes.Red, footerX + 120, footerY);

            string dateText = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            e.Graphics.DrawString(dateText, labelFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom - 40);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            shop_total.Text = "$0.00";
            shop_change.Text = "0";
            shop_amount.Text = "$0.00";
        }
    }
}

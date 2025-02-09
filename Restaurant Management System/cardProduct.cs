using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class cardProduct : UserControl
    {
        public cardProduct()
        {
            InitializeComponent();
        }

        // Product properties
        public int id { get; set; }
        public string productid { get; set; }

        public string productname
        {
            get => productName.Text;
            set => productName.Text = value;
        }

        public string productStock
        {
            get => stock.Text;
            set => stock.Text = value;
        }

        public string productPrice
        {
            get => price.Text;
            set => price.Text = value;
        }

        public string productQuantity
        {
            get => Qty.Text;
            set
            {
                if (int.TryParse(value, out int qty) && qty >= 0)
                {
                    Qty.Text = qty.ToString();
                }
                else
                {
                    Qty.Text = "0";
                }
            }
        }

        public string category { get; set; }

        // Image property to set the product image in PictureBox
        public Image productImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        // Events
        public event EventHandler selectCard;
        public event EventHandler quantityChanged;

        // Add Button Click
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Qty.Text) || !int.TryParse(Qty.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid quantity (0 or more).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Qty.Text = "0";
                return;
            }

            if (!int.TryParse(productStock, out int stock) || stock < 1)
            {
                MessageBox.Show("Stock information is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (qty >= stock)
            {
                MessageBox.Show($"Cannot add more than available stock ({stock}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Qty.Text = stock.ToString();
            }
            else
            {
                qty++;
                Qty.Text = qty.ToString();
            }

            selectCard?.Invoke(this, EventArgs.Empty);
        }

        private void Qty_TextChanged(object sender, EventArgs e)
        {

        }

        // Minus Button Click
        private void bntMinus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Qty.Text, out int qty) && qty > 0)
            {
                qty--; 
                Qty.Text = qty.ToString();
            }
            else
            {
                Qty.Text = "0"; 
            }

            quantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

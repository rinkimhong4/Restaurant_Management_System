using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Foodie : Form
    {
        public Foodie()
        {
            InitializeComponent();

            //CategoryControl categoryControl = new CategoryControl();
            //InventoryControl inventoryControl = new InventoryControl(categoryControl);

        }

        private void Foodie_Load(object sender, EventArgs e)
        {
            homepageBg.Visible = true;
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();
                new Login().Show();
            }
        }
        //show dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(dashboard);
            SetActiveButton(btnDashboard);
            homepageBg.Visible = false;

        }
        //show shop
        private void btnShop_Click(object sender, EventArgs e)
        {
            ShowPanel(shopControl);
            SetActiveButton(btnShop);
            homepageBg.Visible = false;
        }
        //show inventory
        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowPanel(inventoryControl);
            SetActiveButton(btnInventory);
            homepageBg.Visible = false;

        }
        //show category
        private void btnCategory_Click(object sender, EventArgs e)
        {
            ShowPanel(categoryControl);
            SetActiveButton(btnCategory);
            homepageBg.Visible = false;

        }
        //show customer 
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowPanel(customerControl);
            SetActiveButton(btnCustomer);
            homepageBg.Visible = false;
        }
      

       
        /// <summary>
        /// Method to show panel dynamically
        /// </summary>
        /// <param name="activePanel"></param>
        private void ShowPanel(Control activePanel)
        {
            dashboard.Visible = (activePanel == dashboard);
            shopControl.Visible = (activePanel == shopControl);
            inventoryControl.Visible = (activePanel == inventoryControl);
            categoryControl.Visible = (activePanel == categoryControl);
            customerControl.Visible = (activePanel == customerControl);
        }

        /// <summary>
        ///  Method to set button colors dynamically
        /// </summary>
        /// <param name="activeButton"></param>
        private void SetActiveButton(Button activeButton)
        {
            ResetButtonColors();
            activeButton.BackColor = Color.FromArgb(52, 121, 40);
            activeButton.ForeColor = Color.White;
            activeButton.FlatAppearance.BorderSize = 2;
        }
        /// <summary>
        /// Method to reset button colors
        /// </summary>
        private void ResetButtonColors()
        {

            Color defaultBackColor = Color.FromArgb(255, 255, 255);
            Color defaultTextColor = Color.FromArgb(0, 0, 0);

            btnDashboard.BackColor = defaultBackColor;
            btnDashboard.ForeColor = defaultTextColor;

            btnShop.BackColor = defaultBackColor;
            btnShop.ForeColor = defaultTextColor;

            btnInventory.BackColor = defaultBackColor;
            btnInventory.ForeColor = defaultTextColor;

            btnCategory.BackColor = defaultBackColor;
            btnCategory.ForeColor = defaultTextColor;

            btnCustomer.BackColor = defaultBackColor;
            btnCustomer.ForeColor = defaultTextColor;

           
        }
        //show home page
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            homepageBg.Visible = true;
            ResetButtonColors();
        }
        //show home page
        private void homePage_Click(object sender, EventArgs e)
        {
            homepageBg.Visible = true;
            ResetButtonColors();
        }
    }
}

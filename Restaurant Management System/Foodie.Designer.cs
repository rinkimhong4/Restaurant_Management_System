namespace Restaurant_Management_System
{
    partial class Foodie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foodie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.homePage = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHomePage = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.homepageBg = new Restaurant_Management_System.HomepageBg();
            this.customerControl = new Restaurant_Management_System.CustomerControl();
            this.categoryControl = new Restaurant_Management_System.CategoryControl();
            this.inventoryControl = new Restaurant_Management_System.InventoryControl();
            this.shopControl = new Restaurant_Management_System.ShopControl();
            this.dashboard = new Restaurant_Management_System.Dashboard();
            this.customerControl1 = new Restaurant_Management_System.CustomerControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnShop);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 702);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter Medium", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome Admin!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.homePage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 80);
            this.panel3.TabIndex = 3;
            // 
            // homePage
            // 
            this.homePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePage.Image = ((System.Drawing.Image)(resources.GetObject("homePage.Image")));
            this.homePage.Location = new System.Drawing.Point(36, 0);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(128, 83);
            this.homePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePage.TabIndex = 2;
            this.homePage.TabStop = false;
            this.homePage.Click += new System.EventHandler(this.homePage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(15, 629);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(170, 55);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(15, 465);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(170, 55);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(15, 395);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(170, 55);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Categories";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.White;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(15, 325);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnInventory.Size = new System.Drawing.Size(170, 55);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Invantory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.White;
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShop.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.Image = ((System.Drawing.Image)(resources.GetObject("btnShop.Image")));
            this.btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.Location = new System.Drawing.Point(15, 255);
            this.btnShop.Name = "btnShop";
            this.btnShop.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.btnShop.Size = new System.Drawing.Size(170, 55);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "Shop";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(15, 185);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 55);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnHomePage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 80);
            this.panel2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(632, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 32);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lobster", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(861, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hong.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(799, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Location = new System.Drawing.Point(783, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 80);
            this.panel4.TabIndex = 7;
            // 
            // btnHomePage
            // 
            this.btnHomePage.AutoSize = true;
            this.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePage.Font = new System.Drawing.Font("Lobster", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(121)))), ((int)(((byte)(40)))));
            this.btnHomePage.Location = new System.Drawing.Point(3, 15);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(221, 63);
            this.btnHomePage.TabIndex = 6;
            this.btnHomePage.Text = "Foodielsnd.";
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.homepageBg);
            this.panel5.Controls.Add(this.customerControl);
            this.panel5.Controls.Add(this.categoryControl);
            this.panel5.Controls.Add(this.inventoryControl);
            this.panel5.Controls.Add(this.shopControl);
            this.panel5.Controls.Add(this.dashboard);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(200, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(969, 622);
            this.panel5.TabIndex = 3;
            // 
            // homepageBg
            // 
            this.homepageBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(198)))));
            this.homepageBg.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageBg.Location = new System.Drawing.Point(0, 0);
            this.homepageBg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homepageBg.Name = "homepageBg";
            this.homepageBg.Size = new System.Drawing.Size(969, 622);
            this.homepageBg.TabIndex = 4;
            // 
            // customerControl
            // 
            this.customerControl.BackColor = System.Drawing.Color.Ivory;
            this.customerControl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerControl.Location = new System.Drawing.Point(0, 0);
            this.customerControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerControl.Name = "customerControl";
            this.customerControl.Size = new System.Drawing.Size(969, 622);
            this.customerControl.TabIndex = 3;
            // 
            // categoryControl
            // 
            this.categoryControl.BackColor = System.Drawing.Color.Ivory;
            this.categoryControl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryControl.Location = new System.Drawing.Point(0, 0);
            this.categoryControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryControl.Name = "categoryControl";
            this.categoryControl.Size = new System.Drawing.Size(969, 622);
            this.categoryControl.TabIndex = 2;
            // 
            // inventoryControl
            // 
            this.inventoryControl.BackColor = System.Drawing.Color.Ivory;
            this.inventoryControl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryControl.Location = new System.Drawing.Point(0, 0);
            this.inventoryControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventoryControl.Name = "inventoryControl";
            this.inventoryControl.Size = new System.Drawing.Size(969, 622);
            this.inventoryControl.TabIndex = 1;
            this.inventoryControl.Tag = " ";
            // 
            // shopControl
            // 
            this.shopControl.BackColor = System.Drawing.Color.Ivory;
            this.shopControl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopControl.Location = new System.Drawing.Point(0, 0);
            this.shopControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shopControl.Name = "shopControl";
            this.shopControl.Size = new System.Drawing.Size(969, 622);
            this.shopControl.TabIndex = 0;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Ivory;
            this.dashboard.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(969, 622);
            this.dashboard.TabIndex = 0;
            // 
            // customerControl1
            // 
            this.customerControl1.BackColor = System.Drawing.Color.Ivory;
            this.customerControl1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerControl1.Location = new System.Drawing.Point(0, 0);
            this.customerControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerControl1.Name = "customerControl1";
            this.customerControl1.Size = new System.Drawing.Size(969, 622);
            this.customerControl1.TabIndex = 4;
            // 
            // Foodie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1169, 702);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Foodie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foodie";
            this.Load += new System.EventHandler(this.Foodie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.PictureBox homePage;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label btnHomePage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private CustomerControl customerControl1;
        private Dashboard dashboard;
        private CustomerControl customerControl;
        private CategoryControl categoryControl;
        private InventoryControl inventoryControl;
        private ShopControl shopControl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private HomepageBg homepageBg;
    }
}
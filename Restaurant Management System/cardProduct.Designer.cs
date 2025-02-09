namespace Restaurant_Management_System
{
    partial class cardProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardProduct));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.bntMinus = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 144);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(5, 146);
            this.productName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(129, 24);
            this.productName.TabIndex = 1;
            this.productName.Text = "Product Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Red;
            this.price.Location = new System.Drawing.Point(5, 167);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(69, 28);
            this.price.TabIndex = 2;
            this.price.Text = "$0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock :";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(56, 190);
            this.stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(32, 24);
            this.stock.TabIndex = 4;
            this.stock.Text = "00";
            // 
            // Qty
            // 
            this.Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Qty.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.Location = new System.Drawing.Point(43, 219);
            this.Qty.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Size = new System.Drawing.Size(91, 28);
            this.Qty.TabIndex = 5;
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(138, 217);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(37, 33);
            this.Add.TabIndex = 6;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // bntMinus
            // 
            this.bntMinus.BackColor = System.Drawing.Color.White;
            this.bntMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntMinus.FlatAppearance.BorderSize = 0;
            this.bntMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinus.ForeColor = System.Drawing.Color.White;
            this.bntMinus.Image = ((System.Drawing.Image)(resources.GetObject("bntMinus.Image")));
            this.bntMinus.Location = new System.Drawing.Point(2, 217);
            this.bntMinus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bntMinus.Name = "bntMinus";
            this.bntMinus.Size = new System.Drawing.Size(37, 33);
            this.bntMinus.TabIndex = 8;
            this.bntMinus.UseVisualStyleBackColor = false;
            this.bntMinus.Click += new System.EventHandler(this.bntMinus_Click);
            // 
            // cardProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bntMinus);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cardProduct";
            this.Size = new System.Drawing.Size(178, 266);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button bntMinus;
    }
}

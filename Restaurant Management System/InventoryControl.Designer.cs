namespace Restaurant_Management_System
{
    partial class InventoryControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Inven = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Inventory_btnClear = new System.Windows.Forms.Button();
            this.Inventory_btnDelete = new System.Windows.Forms.Button();
            this.Inventory_btnUpdate = new System.Windows.Forms.Button();
            this.Inventory_btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Inventory_ProductPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Inventory_Status = new System.Windows.Forms.ComboBox();
            this.Inventory_Stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Inventory_ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Inventory_Image = new System.Windows.Forms.PictureBox();
            this.Inventory_ImportBtn = new System.Windows.Forms.Button();
            this.Inventory_cmbCateg = new System.Windows.Forms.ComboBox();
            this.Inventory_ProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inven)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_Inven);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 378);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Product\'s";
            // 
            // dataGridView_Inven
            // 
            this.dataGridView_Inven.AllowUserToAddRows = false;
            this.dataGridView_Inven.AllowUserToResizeColumns = false;
            this.dataGridView_Inven.AllowUserToResizeRows = false;
            this.dataGridView_Inven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Inven.Location = new System.Drawing.Point(3, 37);
            this.dataGridView_Inven.Name = "dataGridView_Inven";
            this.dataGridView_Inven.ReadOnly = true;
            this.dataGridView_Inven.RowHeadersVisible = false;
            this.dataGridView_Inven.RowHeadersWidth = 51;
            this.dataGridView_Inven.RowTemplate.Height = 24;
            this.dataGridView_Inven.Size = new System.Drawing.Size(929, 338);
            this.dataGridView_Inven.TabIndex = 0;
            this.dataGridView_Inven.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Inventory_btnClear);
            this.panel2.Controls.Add(this.Inventory_btnDelete);
            this.panel2.Controls.Add(this.Inventory_btnUpdate);
            this.panel2.Controls.Add(this.Inventory_btnAdd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Inventory_ProductPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Inventory_Status);
            this.panel2.Controls.Add(this.Inventory_Stock);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Inventory_ProductName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Inventory_Image);
            this.panel2.Controls.Add(this.Inventory_ImportBtn);
            this.panel2.Controls.Add(this.Inventory_cmbCateg);
            this.panel2.Controls.Add(this.Inventory_ProductId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 203);
            this.panel2.TabIndex = 1;
            // 
            // Inventory_btnClear
            // 
            this.Inventory_btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.Inventory_btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventory_btnClear.FlatAppearance.BorderSize = 0;
            this.Inventory_btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_btnClear.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_btnClear.ForeColor = System.Drawing.Color.White;
            this.Inventory_btnClear.Location = new System.Drawing.Point(602, 154);
            this.Inventory_btnClear.Name = "Inventory_btnClear";
            this.Inventory_btnClear.Size = new System.Drawing.Size(120, 35);
            this.Inventory_btnClear.TabIndex = 17;
            this.Inventory_btnClear.Text = "Clear";
            this.Inventory_btnClear.UseVisualStyleBackColor = false;
            this.Inventory_btnClear.Click += new System.EventHandler(this.Inventory_btnClear_Click);
            // 
            // Inventory_btnDelete
            // 
            this.Inventory_btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.Inventory_btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventory_btnDelete.FlatAppearance.BorderSize = 0;
            this.Inventory_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_btnDelete.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_btnDelete.ForeColor = System.Drawing.Color.White;
            this.Inventory_btnDelete.Location = new System.Drawing.Point(407, 154);
            this.Inventory_btnDelete.Name = "Inventory_btnDelete";
            this.Inventory_btnDelete.Size = new System.Drawing.Size(120, 35);
            this.Inventory_btnDelete.TabIndex = 16;
            this.Inventory_btnDelete.Text = "Delete";
            this.Inventory_btnDelete.UseVisualStyleBackColor = false;
            this.Inventory_btnDelete.Click += new System.EventHandler(this.Inventory_btnDelete_Click);
            // 
            // Inventory_btnUpdate
            // 
            this.Inventory_btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.Inventory_btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventory_btnUpdate.FlatAppearance.BorderSize = 0;
            this.Inventory_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_btnUpdate.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_btnUpdate.ForeColor = System.Drawing.Color.White;
            this.Inventory_btnUpdate.Location = new System.Drawing.Point(212, 154);
            this.Inventory_btnUpdate.Name = "Inventory_btnUpdate";
            this.Inventory_btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.Inventory_btnUpdate.TabIndex = 15;
            this.Inventory_btnUpdate.Text = "Update";
            this.Inventory_btnUpdate.UseVisualStyleBackColor = false;
            this.Inventory_btnUpdate.Click += new System.EventHandler(this.Inventory_btnUpdate_Click);
            // 
            // Inventory_btnAdd
            // 
            this.Inventory_btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.Inventory_btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventory_btnAdd.FlatAppearance.BorderSize = 0;
            this.Inventory_btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_btnAdd.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_btnAdd.ForeColor = System.Drawing.Color.White;
            this.Inventory_btnAdd.Location = new System.Drawing.Point(17, 154);
            this.Inventory_btnAdd.Name = "Inventory_btnAdd";
            this.Inventory_btnAdd.Size = new System.Drawing.Size(120, 35);
            this.Inventory_btnAdd.TabIndex = 14;
            this.Inventory_btnAdd.Text = "Add";
            this.Inventory_btnAdd.UseVisualStyleBackColor = false;
            this.Inventory_btnAdd.Click += new System.EventHandler(this.Inventory_btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(425, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "status :";
            // 
            // Inventory_ProductPrice
            // 
            this.Inventory_ProductPrice.Location = new System.Drawing.Point(508, 53);
            this.Inventory_ProductPrice.Name = "Inventory_ProductPrice";
            this.Inventory_ProductPrice.Size = new System.Drawing.Size(215, 32);
            this.Inventory_ProductPrice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(407, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "price($) :";
            // 
            // Inventory_Status
            // 
            this.Inventory_Status.FormattingEnabled = true;
            this.Inventory_Status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.Inventory_Status.Location = new System.Drawing.Point(508, 97);
            this.Inventory_Status.Name = "Inventory_Status";
            this.Inventory_Status.Size = new System.Drawing.Size(215, 36);
            this.Inventory_Status.TabIndex = 10;
            // 
            // Inventory_Stock
            // 
            this.Inventory_Stock.Location = new System.Drawing.Point(508, 10);
            this.Inventory_Stock.Name = "Inventory_Stock";
            this.Inventory_Stock.Size = new System.Drawing.Size(215, 32);
            this.Inventory_Stock.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(431, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "stock :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(58, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category :";
            // 
            // Inventory_ProductName
            // 
            this.Inventory_ProductName.Location = new System.Drawing.Point(175, 53);
            this.Inventory_ProductName.Name = "Inventory_ProductName";
            this.Inventory_ProductName.Size = new System.Drawing.Size(215, 32);
            this.Inventory_ProductName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "product name :";
            // 
            // Inventory_Image
            // 
            this.Inventory_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inventory_Image.Location = new System.Drawing.Point(787, 10);
            this.Inventory_Image.Name = "Inventory_Image";
            this.Inventory_Image.Size = new System.Drawing.Size(140, 140);
            this.Inventory_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Inventory_Image.TabIndex = 4;
            this.Inventory_Image.TabStop = false;
            // 
            // Inventory_ImportBtn
            // 
            this.Inventory_ImportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.Inventory_ImportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventory_ImportBtn.FlatAppearance.BorderSize = 0;
            this.Inventory_ImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_ImportBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_ImportBtn.ForeColor = System.Drawing.Color.White;
            this.Inventory_ImportBtn.Location = new System.Drawing.Point(787, 154);
            this.Inventory_ImportBtn.Name = "Inventory_ImportBtn";
            this.Inventory_ImportBtn.Size = new System.Drawing.Size(140, 39);
            this.Inventory_ImportBtn.TabIndex = 3;
            this.Inventory_ImportBtn.Text = "Import";
            this.Inventory_ImportBtn.UseVisualStyleBackColor = false;
            this.Inventory_ImportBtn.Click += new System.EventHandler(this.Inventory_ImportBtn_Click);
            // 
            // Inventory_cmbCateg
            // 
            this.Inventory_cmbCateg.FormattingEnabled = true;
            this.Inventory_cmbCateg.Location = new System.Drawing.Point(175, 97);
            this.Inventory_cmbCateg.Name = "Inventory_cmbCateg";
            this.Inventory_cmbCateg.Size = new System.Drawing.Size(215, 36);
            this.Inventory_cmbCateg.TabIndex = 2;
            // 
            // Inventory_ProductId
            // 
            this.Inventory_ProductId.Location = new System.Drawing.Point(175, 10);
            this.Inventory_ProductId.Name = "Inventory_ProductId";
            this.Inventory_ProductId.Size = new System.Drawing.Size(215, 32);
            this.Inventory_ProductId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(49, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "product id :";
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventoryControl";
            this.Size = new System.Drawing.Size(969, 622);
            this.Tag = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inven)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Inventory_ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Inventory_Image;
        private System.Windows.Forms.Button Inventory_ImportBtn;
        private System.Windows.Forms.ComboBox Inventory_cmbCateg;
        private System.Windows.Forms.TextBox Inventory_ProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Inventory_ProductPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Inventory_Status;
        private System.Windows.Forms.TextBox Inventory_Stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Inventory_btnClear;
        private System.Windows.Forms.Button Inventory_btnDelete;
        private System.Windows.Forms.Button Inventory_btnUpdate;
        private System.Windows.Forms.Button Inventory_btnAdd;
        private System.Windows.Forms.DataGridView dataGridView_Inven;
    }
}

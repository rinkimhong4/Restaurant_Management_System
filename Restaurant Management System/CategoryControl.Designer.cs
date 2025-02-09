namespace Restaurant_Management_System
{
    partial class CategoryControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntCategory_Clear = new System.Windows.Forms.Button();
            this.bntCategory_Delete = new System.Windows.Forms.Button();
            this.bntCategory_Update = new System.Windows.Forms.Button();
            this.bntCategory_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategory_Category = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 589);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 555);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Categories";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bntCategory_Clear);
            this.panel2.Controls.Add(this.bntCategory_Delete);
            this.panel2.Controls.Add(this.bntCategory_Update);
            this.panel2.Controls.Add(this.bntCategory_Add);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCategory_Category);
            this.panel2.Location = new System.Drawing.Point(669, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 589);
            this.panel2.TabIndex = 1;
            // 
            // bntCategory_Clear
            // 
            this.bntCategory_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(107)))), ((int)(((byte)(99)))));
            this.bntCategory_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCategory_Clear.FlatAppearance.BorderSize = 0;
            this.bntCategory_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCategory_Clear.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCategory_Clear.ForeColor = System.Drawing.Color.White;
            this.bntCategory_Clear.Location = new System.Drawing.Point(142, 281);
            this.bntCategory_Clear.Name = "bntCategory_Clear";
            this.bntCategory_Clear.Size = new System.Drawing.Size(115, 46);
            this.bntCategory_Clear.TabIndex = 9;
            this.bntCategory_Clear.Text = "Clear";
            this.bntCategory_Clear.UseVisualStyleBackColor = false;
            this.bntCategory_Clear.Click += new System.EventHandler(this.bntCategory_Clear_Click);
            // 
            // bntCategory_Delete
            // 
            this.bntCategory_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(112)))), ((int)(((byte)(88)))));
            this.bntCategory_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCategory_Delete.FlatAppearance.BorderSize = 0;
            this.bntCategory_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCategory_Delete.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCategory_Delete.ForeColor = System.Drawing.Color.White;
            this.bntCategory_Delete.Location = new System.Drawing.Point(19, 281);
            this.bntCategory_Delete.Name = "bntCategory_Delete";
            this.bntCategory_Delete.Size = new System.Drawing.Size(115, 46);
            this.bntCategory_Delete.TabIndex = 8;
            this.bntCategory_Delete.Text = "Delete";
            this.bntCategory_Delete.UseVisualStyleBackColor = false;
            this.bntCategory_Delete.Click += new System.EventHandler(this.bntCategory_Delete_Click);
            // 
            // bntCategory_Update
            // 
            this.bntCategory_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.bntCategory_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCategory_Update.FlatAppearance.BorderSize = 0;
            this.bntCategory_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCategory_Update.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCategory_Update.ForeColor = System.Drawing.Color.White;
            this.bntCategory_Update.Location = new System.Drawing.Point(142, 229);
            this.bntCategory_Update.Name = "bntCategory_Update";
            this.bntCategory_Update.Size = new System.Drawing.Size(115, 46);
            this.bntCategory_Update.TabIndex = 7;
            this.bntCategory_Update.Text = "Update";
            this.bntCategory_Update.UseVisualStyleBackColor = false;
            this.bntCategory_Update.Click += new System.EventHandler(this.bntCategory_Update_Click);
            // 
            // bntCategory_Add
            // 
            this.bntCategory_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(116)))), ((int)(((byte)(188)))));
            this.bntCategory_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCategory_Add.FlatAppearance.BorderSize = 0;
            this.bntCategory_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCategory_Add.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCategory_Add.ForeColor = System.Drawing.Color.White;
            this.bntCategory_Add.Location = new System.Drawing.Point(19, 229);
            this.bntCategory_Add.Name = "bntCategory_Add";
            this.bntCategory_Add.Size = new System.Drawing.Size(115, 46);
            this.bntCategory_Add.TabIndex = 6;
            this.bntCategory_Add.Text = "Add";
            this.bntCategory_Add.UseVisualStyleBackColor = false;
            this.bntCategory_Add.Click += new System.EventHandler(this.bntCategory_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categories";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbCategory.Location = new System.Drawing.Point(19, 173);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(238, 36);
            this.cmbCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Categories";
            // 
            // txtCategory_Category
            // 
            this.txtCategory_Category.Location = new System.Drawing.Point(19, 96);
            this.txtCategory_Category.Name = "txtCategory_Category";
            this.txtCategory_Category.Size = new System.Drawing.Size(238, 32);
            this.txtCategory_Category.TabIndex = 0;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(969, 622);
            this.Load += new System.EventHandler(this.CategoryControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCategory_Category;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntCategory_Clear;
        private System.Windows.Forms.Button bntCategory_Delete;
        private System.Windows.Forms.Button bntCategory_Update;
        private System.Windows.Forms.Button bntCategory_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

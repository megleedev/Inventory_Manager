namespace InventoryManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvParts = new DataGridView();
            dgvProducts = new DataGridView();
            btnAddPart = new Button();
            btnModifyPart = new Button();
            btnDeletePart = new Button();
            txtSearchParts = new TextBox();
            btnSearchParts = new Button();
            btnDeleteProduct = new Button();
            btnModifyProduct = new Button();
            btnAddProduct = new Button();
            btnSearchProducts = new Button();
            txtSearchProducts = new TextBox();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvParts
            // 
            dgvParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Location = new Point(12, 105);
            dgvParts.MultiSelect = false;
            dgvParts.Name = "dgvParts";
            dgvParts.ReadOnly = true;
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParts.Size = new Size(422, 219);
            dgvParts.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(470, 105);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(402, 219);
            dgvProducts.TabIndex = 1;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(195, 341);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(75, 23);
            btnAddPart.TabIndex = 2;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnModifyPart
            // 
            btnModifyPart.Location = new Point(276, 341);
            btnModifyPart.Name = "btnModifyPart";
            btnModifyPart.Size = new Size(75, 23);
            btnModifyPart.TabIndex = 3;
            btnModifyPart.Text = "Modify";
            btnModifyPart.UseVisualStyleBackColor = true;
            btnModifyPart.Click += btnModifyPart_Click;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(357, 341);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(75, 23);
            btnDeletePart.TabIndex = 4;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // txtSearchParts
            // 
            txtSearchParts.Location = new Point(276, 74);
            txtSearchParts.Name = "txtSearchParts";
            txtSearchParts.Size = new Size(158, 23);
            txtSearchParts.TabIndex = 5;
            // 
            // btnSearchParts
            // 
            btnSearchParts.Location = new Point(195, 76);
            btnSearchParts.Name = "btnSearchParts";
            btnSearchParts.Size = new Size(75, 23);
            btnSearchParts.TabIndex = 6;
            btnSearchParts.Text = "Search";
            btnSearchParts.UseVisualStyleBackColor = true;
            btnSearchParts.Click += btnSearchParts_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(796, 350);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 9;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnModifyProduct
            // 
            btnModifyProduct.Location = new Point(715, 350);
            btnModifyProduct.Name = "btnModifyProduct";
            btnModifyProduct.Size = new Size(75, 23);
            btnModifyProduct.TabIndex = 8;
            btnModifyProduct.Text = "Modify";
            btnModifyProduct.UseVisualStyleBackColor = true;
            btnModifyProduct.Click += btnModifyProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(632, 350);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.Location = new Point(632, 75);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(75, 23);
            btnSearchProducts.TabIndex = 11;
            btnSearchProducts.Text = "Search";
            btnSearchProducts.UseVisualStyleBackColor = true;
            btnSearchProducts.Click += btnSearchProducts_Click;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Location = new Point(713, 76);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.Size = new Size(158, 23);
            txtSearchProducts.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(796, 408);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 25);
            label1.TabIndex = 13;
            label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 14;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(470, 76);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 15;
            label3.Text = "Products";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnSearchProducts);
            Controls.Add(txtSearchProducts);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnModifyProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(btnSearchParts);
            Controls.Add(txtSearchParts);
            Controls.Add(btnDeletePart);
            Controls.Add(btnModifyPart);
            Controls.Add(btnAddPart);
            Controls.Add(dgvProducts);
            Controls.Add(dgvParts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Manager";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvParts;
        private DataGridView dgvProducts;
        private Button btnAddPart;
        private Button btnModifyPart;
        private Button btnDeletePart;
        private TextBox txtSearchParts;
        private Button btnSearchParts;
        private Button btnDeleteProduct;
        private Button btnModifyProduct;
        private Button btnAddProduct;
        private Button btnSearchProducts;
        private TextBox txtSearchProducts;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

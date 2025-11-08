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
            dgvParts.Size = new Size(360, 219);
            dgvParts.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(422, 105);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(366, 219);
            dgvProducts.TabIndex = 1;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(133, 350);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(75, 23);
            btnAddPart.TabIndex = 2;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnModifyPart
            // 
            btnModifyPart.Location = new Point(214, 350);
            btnModifyPart.Name = "btnModifyPart";
            btnModifyPart.Size = new Size(75, 23);
            btnModifyPart.TabIndex = 3;
            btnModifyPart.Text = "Modify";
            btnModifyPart.UseVisualStyleBackColor = true;
            btnModifyPart.Click += btnModifyPart_Click;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(297, 350);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(75, 23);
            btnDeletePart.TabIndex = 4;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // txtSearchParts
            // 
            txtSearchParts.Location = new Point(214, 63);
            txtSearchParts.Name = "txtSearchParts";
            txtSearchParts.Size = new Size(158, 23);
            txtSearchParts.TabIndex = 5;
            // 
            // btnSearchParts
            // 
            btnSearchParts.Location = new Point(133, 63);
            btnSearchParts.Name = "btnSearchParts";
            btnSearchParts.Size = new Size(75, 23);
            btnSearchParts.TabIndex = 6;
            btnSearchParts.Text = "Search";
            btnSearchParts.UseVisualStyleBackColor = true;
            btnSearchParts.Click += btnSearchParts_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(713, 350);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 9;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnModifyProduct
            // 
            btnModifyProduct.Location = new Point(630, 350);
            btnModifyProduct.Name = "btnModifyProduct";
            btnModifyProduct.Size = new Size(75, 23);
            btnModifyProduct.TabIndex = 8;
            btnModifyProduct.Text = "Modify";
            btnModifyProduct.UseVisualStyleBackColor = true;
            btnModifyProduct.Click += btnModifyProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(549, 350);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 23);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "MainForm";
            Text = "Inventory Manager";
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
    }
}

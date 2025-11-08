namespace InventoryManager.Forms
{
    partial class AddProductForm
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
            btnCancel = new Button();
            btnSave = new Button();
            txtMin = new TextBox();
            txtMax = new TextBox();
            txtPrice = new TextBox();
            txtInStock = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblMin = new Label();
            lblMax = new Label();
            lblPrice = new Label();
            lblInStock = new Label();
            lblName = new Label();
            lblId = new Label();
            lblTitle = new Label();
            dgvAllParts = new DataGridView();
            dgvAssociatedParts = new DataGridView();
            btnDeletePart = new Button();
            btnAddPart = new Button();
            btnSearchPartsForProduct = new Button();
            txtSearchPartsForProduct = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedParts).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(647, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(548, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(252, 331);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 36;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(86, 331);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 35;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(86, 275);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(175, 23);
            txtPrice.TabIndex = 34;
            // 
            // txtInStock
            // 
            txtInStock.Location = new Point(86, 222);
            txtInStock.Name = "txtInStock";
            txtInStock.Size = new Size(175, 23);
            txtInStock.TabIndex = 33;
            // 
            // txtName
            // 
            txtName.Location = new Point(86, 169);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 32;
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 118);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 31;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(206, 334);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(28, 15);
            lblMin.TabIndex = 29;
            lblMin.Text = "Min";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(13, 334);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(29, 15);
            lblMax.TabIndex = 28;
            lblMax.Text = "Max";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(13, 278);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 27;
            lblPrice.Text = "Price";
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Location = new Point(13, 225);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(57, 15);
            lblInStock.TabIndex = 26;
            lblInStock.Text = "Inventory";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(13, 172);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 25;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(18, 121);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 24;
            lblId.Text = "ID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(48, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(117, 25);
            lblTitle.TabIndex = 21;
            lblTitle.Text = "Add Product";
            // 
            // dgvAllParts
            // 
            dgvAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllParts.Location = new Point(421, 37);
            dgvAllParts.Name = "dgvAllParts";
            dgvAllParts.Size = new Size(302, 150);
            dgvAllParts.TabIndex = 40;
            // 
            // dgvAssociatedParts
            // 
            dgvAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssociatedParts.Location = new Point(421, 225);
            dgvAssociatedParts.Name = "dgvAssociatedParts";
            dgvAssociatedParts.Size = new Size(302, 150);
            dgvAssociatedParts.TabIndex = 41;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(648, 381);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(75, 23);
            btnDeletePart.TabIndex = 42;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(648, 193);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(75, 23);
            btnAddPart.TabIndex = 43;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnSearchPartsForProduct
            // 
            btnSearchPartsForProduct.Location = new Point(421, 8);
            btnSearchPartsForProduct.Name = "btnSearchPartsForProduct";
            btnSearchPartsForProduct.Size = new Size(75, 23);
            btnSearchPartsForProduct.TabIndex = 44;
            btnSearchPartsForProduct.Text = "Search";
            btnSearchPartsForProduct.UseVisualStyleBackColor = true;
            btnSearchPartsForProduct.Click += btnSearchPartsForProduct_Click;
            // 
            // txtSearchPartsForProduct
            // 
            txtSearchPartsForProduct.Location = new Point(502, 9);
            txtSearchPartsForProduct.Name = "txtSearchPartsForProduct";
            txtSearchPartsForProduct.Size = new Size(180, 23);
            txtSearchPartsForProduct.TabIndex = 45;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearchPartsForProduct);
            Controls.Add(btnSearchPartsForProduct);
            Controls.Add(btnAddPart);
            Controls.Add(btnDeletePart);
            Controls.Add(dgvAssociatedParts);
            Controls.Add(dgvAllParts);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtPrice);
            Controls.Add(txtInStock);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(lblPrice);
            Controls.Add(lblInStock);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(lblTitle);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtMin;
        private TextBox txtMax;
        private TextBox txtPrice;
        private TextBox txtInStock;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblMin;
        private Label lblMax;
        private Label lblPrice;
        private Label lblInStock;
        private Label lblName;
        private Label lblId;
        private Label lblTitle;
        private DataGridView dgvAllParts;
        private DataGridView dgvAssociatedParts;
        private Button btnDeletePart;
        private Button btnAddPart;
        private Button btnSearchPartsForProduct;
        private TextBox txtSearchPartsForProduct;
    }
}
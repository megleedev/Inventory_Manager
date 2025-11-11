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
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedParts).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(780, 426);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(699, 426);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(283, 308);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 4;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(117, 308);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(117, 252);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(175, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtInStock
            // 
            txtInStock.Location = new Point(117, 199);
            txtInStock.Name = "txtInStock";
            txtInStock.Size = new Size(175, 23);
            txtInStock.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(117, 95);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 0;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(237, 311);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(28, 15);
            lblMin.TabIndex = 29;
            lblMin.Text = "Min";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(44, 311);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(29, 15);
            lblMax.TabIndex = 28;
            lblMax.Text = "Max";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(44, 255);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 27;
            lblPrice.Text = "Price";
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Location = new Point(44, 202);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(57, 15);
            lblInStock.TabIndex = 26;
            lblInStock.Text = "Inventory";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(44, 149);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 25;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(49, 98);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 24;
            lblId.Text = "ID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(117, 25);
            lblTitle.TabIndex = 21;
            lblTitle.Text = "Add Product";
            // 
            // dgvAllParts
            // 
            dgvAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllParts.Location = new Point(421, 42);
            dgvAllParts.Name = "dgvAllParts";
            dgvAllParts.Size = new Size(451, 150);
            dgvAllParts.TabIndex = 40;
            // 
            // dgvAssociatedParts
            // 
            dgvAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssociatedParts.Location = new Point(421, 238);
            dgvAssociatedParts.Name = "dgvAssociatedParts";
            dgvAssociatedParts.Size = new Size(451, 150);
            dgvAssociatedParts.TabIndex = 41;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(780, 394);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(75, 23);
            btnDeletePart.TabIndex = 42;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(780, 198);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(75, 23);
            btnAddPart.TabIndex = 43;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnSearchPartsForProduct
            // 
            btnSearchPartsForProduct.Location = new Point(601, 7);
            btnSearchPartsForProduct.Name = "btnSearchPartsForProduct";
            btnSearchPartsForProduct.Size = new Size(75, 23);
            btnSearchPartsForProduct.TabIndex = 14;
            btnSearchPartsForProduct.Text = "Search";
            btnSearchPartsForProduct.UseVisualStyleBackColor = true;
            btnSearchPartsForProduct.Click += btnSearchPartsForProduct_Click;
            // 
            // txtSearchPartsForProduct
            // 
            txtSearchPartsForProduct.Location = new Point(692, 8);
            txtSearchPartsForProduct.Name = "txtSearchPartsForProduct";
            txtSearchPartsForProduct.Size = new Size(180, 23);
            txtSearchPartsForProduct.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 24);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 46;
            label1.Text = "All candidate Parts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 220);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 47;
            label2.Text = "Parts Associated with this Product";
            // 
            // AddProductForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(884, 461);
            Controls.Add(label2);
            Controls.Add(label1);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
        private Label label2;
    }
}
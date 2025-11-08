namespace InventoryManager.Forms
{
    partial class ModifyProductForm
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
            txtSearchPartsForProduct = new TextBox();
            btnSearchPartsForProduct = new Button();
            btnAddPart = new Button();
            btnDeletePart = new Button();
            dgvAssociatedParts = new DataGridView();
            dgvAllParts = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).BeginInit();
            SuspendLayout();
            // 
            // txtSearchPartsForProduct
            // 
            txtSearchPartsForProduct.Location = new Point(534, 11);
            txtSearchPartsForProduct.Name = "txtSearchPartsForProduct";
            txtSearchPartsForProduct.Size = new Size(180, 23);
            txtSearchPartsForProduct.TabIndex = 66;
            // 
            // btnSearchPartsForProduct
            // 
            btnSearchPartsForProduct.Location = new Point(453, 10);
            btnSearchPartsForProduct.Name = "btnSearchPartsForProduct";
            btnSearchPartsForProduct.Size = new Size(75, 23);
            btnSearchPartsForProduct.TabIndex = 65;
            btnSearchPartsForProduct.Text = "Search";
            btnSearchPartsForProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(680, 195);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(75, 23);
            btnAddPart.TabIndex = 64;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(680, 383);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(75, 23);
            btnDeletePart.TabIndex = 63;
            btnDeletePart.Text = "Delete";
            btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // dgvAssociatedParts
            // 
            dgvAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssociatedParts.Location = new Point(453, 227);
            dgvAssociatedParts.Name = "dgvAssociatedParts";
            dgvAssociatedParts.Size = new Size(302, 150);
            dgvAssociatedParts.TabIndex = 62;
            // 
            // dgvAllParts
            // 
            dgvAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllParts.Location = new Point(453, 39);
            dgvAllParts.Name = "dgvAllParts";
            dgvAllParts.Size = new Size(302, 150);
            dgvAllParts.TabIndex = 61;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(679, 417);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 60;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(580, 417);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 59;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(284, 333);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 58;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(118, 333);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 57;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(118, 277);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(175, 23);
            txtPrice.TabIndex = 56;
            // 
            // txtInStock
            // 
            txtInStock.Location = new Point(118, 224);
            txtInStock.Name = "txtInStock";
            txtInStock.Size = new Size(175, 23);
            txtInStock.TabIndex = 55;
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 171);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 54;
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 120);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 53;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(238, 336);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(28, 15);
            lblMin.TabIndex = 52;
            lblMin.Text = "Min";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(45, 336);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(29, 15);
            lblMax.TabIndex = 51;
            lblMax.Text = "Max";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(45, 280);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 50;
            lblPrice.Text = "Price";
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Location = new Point(45, 227);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(57, 15);
            lblInStock.TabIndex = 49;
            lblInStock.Text = "Inventory";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(45, 174);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 48;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(50, 123);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 47;
            lblId.Text = "ID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(80, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 25);
            lblTitle.TabIndex = 46;
            lblTitle.Text = "Modify Product";
            // 
            // ModifyProductForm
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
            Name = "ModifyProductForm";
            Text = "ModifyProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchPartsForProduct;
        private Button btnSearchPartsForProduct;
        private Button btnAddPart;
        private Button btnDeletePart;
        private DataGridView dgvAssociatedParts;
        private DataGridView dgvAllParts;
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
    }
}
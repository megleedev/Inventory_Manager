namespace InventoryManager.Forms
{
    partial class AddPartForm
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
            lblTitle = new Label();
            rdoInHouse = new RadioButton();
            rdoOutsourced = new RadioButton();
            lblId = new Label();
            lblName = new Label();
            lblInStock = new Label();
            lblPrice = new Label();
            lblMax = new Label();
            lblMin = new Label();
            lblVar = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtInStock = new TextBox();
            txtPrice = new TextBox();
            txtMax = new TextBox();
            txtMin = new TextBox();
            txtVar = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Part";
            // 
            // rdoInHouse
            // 
            rdoInHouse.AutoSize = true;
            rdoInHouse.Checked = true;
            rdoInHouse.Location = new Point(291, 15);
            rdoInHouse.Name = "rdoInHouse";
            rdoInHouse.Size = new Size(74, 19);
            rdoInHouse.TabIndex = 1;
            rdoInHouse.TabStop = true;
            rdoInHouse.Text = "In-House";
            rdoInHouse.UseVisualStyleBackColor = true;
            // 
            // rdoOutsourced
            // 
            rdoOutsourced.AutoSize = true;
            rdoOutsourced.Location = new Point(482, 15);
            rdoOutsourced.Name = "rdoOutsourced";
            rdoOutsourced.Size = new Size(87, 19);
            rdoOutsourced.TabIndex = 2;
            rdoOutsourced.Text = "Outsourced";
            rdoOutsourced.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(291, 68);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 3;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(286, 119);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Location = new Point(286, 172);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(57, 15);
            lblInStock.TabIndex = 5;
            lblInStock.Text = "Inventory";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(286, 225);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(286, 281);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(29, 15);
            lblMax.TabIndex = 7;
            lblMax.Text = "Max";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(543, 281);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(28, 15);
            lblMin.TabIndex = 8;
            lblMin.Text = "Min";
            // 
            // lblVar
            // 
            lblVar.AutoSize = true;
            lblVar.Location = new Point(291, 338);
            lblVar.Name = "lblVar";
            lblVar.Size = new Size(67, 15);
            lblVar.TabIndex = 9;
            lblVar.Text = "Machine ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(394, 65);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(394, 111);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 11;
            // 
            // txtInStock
            // 
            txtInStock.Location = new Point(394, 169);
            txtInStock.Name = "txtInStock";
            txtInStock.Size = new Size(175, 23);
            txtInStock.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(394, 222);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(175, 23);
            txtPrice.TabIndex = 13;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(394, 278);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 14;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(617, 278);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 15;
            // 
            // txtVar
            // 
            txtVar.Location = new Point(394, 335);
            txtVar.Name = "txtVar";
            txtVar.Size = new Size(175, 23);
            txtVar.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(543, 401);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(642, 401);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddPartForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtVar);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtPrice);
            Controls.Add(txtInStock);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblVar);
            Controls.Add(lblMin);
            Controls.Add(lblMax);
            Controls.Add(lblPrice);
            Controls.Add(lblInStock);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(rdoOutsourced);
            Controls.Add(rdoInHouse);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPartForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RadioButton rdoInHouse;
        private RadioButton rdoOutsourced;
        private Label lblId;
        private Label lblName;
        private Label lblInStock;
        private Label lblPrice;
        private Label lblMax;
        private Label lblMin;
        private Label lblVar;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtInStock;
        private TextBox txtPrice;
        private TextBox txtMax;
        private TextBox txtMin;
        private TextBox txtVar;
        private Button btnSave;
        private Button btnCancel;
    }
}
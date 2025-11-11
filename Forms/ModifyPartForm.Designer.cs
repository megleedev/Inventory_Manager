namespace InventoryManager.Forms
{
    partial class ModifyPartForm
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
            txtVar = new TextBox();
            txtMin = new TextBox();
            txtMax = new TextBox();
            txtPrice = new TextBox();
            txtInStock = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblVar = new Label();
            lblMin = new Label();
            lblMax = new Label();
            lblPrice = new Label();
            lblInStock = new Label();
            lblName = new Label();
            lblId = new Label();
            rdoOutsourced = new RadioButton();
            rdoInHouse = new RadioButton();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(621, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(522, 405);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtVar
            // 
            txtVar.Location = new Point(373, 349);
            txtVar.Name = "txtVar";
            txtVar.Size = new Size(175, 23);
            txtVar.TabIndex = 5;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(596, 292);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 4;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(373, 292);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(373, 236);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(175, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtInStock
            // 
            txtInStock.Location = new Point(373, 183);
            txtInStock.Name = "txtInStock";
            txtInStock.Size = new Size(175, 23);
            txtInStock.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(373, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(373, 79);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 31;
            // 
            // lblVar
            // 
            lblVar.AutoSize = true;
            lblVar.Location = new Point(265, 357);
            lblVar.Name = "lblVar";
            lblVar.Size = new Size(67, 15);
            lblVar.TabIndex = 30;
            lblVar.Text = "Machine ID";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(522, 295);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(28, 15);
            lblMin.TabIndex = 29;
            lblMin.Text = "Min";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(265, 295);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(29, 15);
            lblMax.TabIndex = 28;
            lblMax.Text = "Max";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(265, 239);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(68, 15);
            lblPrice.TabIndex = 27;
            lblPrice.Text = "Price / Cost";
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Location = new Point(265, 186);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(57, 15);
            lblInStock.TabIndex = 26;
            lblInStock.Text = "Inventory";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(265, 133);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 25;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(270, 82);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 24;
            lblId.Text = "ID";
            // 
            // rdoOutsourced
            // 
            rdoOutsourced.AutoSize = true;
            rdoOutsourced.Location = new Point(463, 15);
            rdoOutsourced.Name = "rdoOutsourced";
            rdoOutsourced.Size = new Size(87, 19);
            rdoOutsourced.TabIndex = 23;
            rdoOutsourced.Text = "Outsourced";
            rdoOutsourced.UseVisualStyleBackColor = true;
            rdoOutsourced.CheckedChanged += rdoOutsourced_CheckedChanged;
            // 
            // rdoInHouse
            // 
            rdoInHouse.AutoSize = true;
            rdoInHouse.Checked = true;
            rdoInHouse.Location = new Point(272, 15);
            rdoInHouse.Name = "rdoInHouse";
            rdoInHouse.Size = new Size(74, 19);
            rdoInHouse.TabIndex = 22;
            rdoInHouse.TabStop = true;
            rdoInHouse.Text = "In-House";
            rdoInHouse.UseVisualStyleBackColor = true;
            rdoInHouse.CheckedChanged += rdoInHouse_CheckedChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(109, 25);
            lblTitle.TabIndex = 21;
            lblTitle.Text = "Modify Part";
            // 
            // ModifyPartForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(884, 461);
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
            Name = "ModifyPartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModifyPartForm";
            Load += ModifyPartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtVar;
        private TextBox txtMin;
        private TextBox txtMax;
        private TextBox txtPrice;
        private TextBox txtInStock;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblVar;
        private Label lblMin;
        private Label lblMax;
        private Label lblPrice;
        private Label lblInStock;
        private Label lblName;
        private Label lblId;
        private RadioButton rdoOutsourced;
        private RadioButton rdoInHouse;
        private Label lblTitle;
    }
}
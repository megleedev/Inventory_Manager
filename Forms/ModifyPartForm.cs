using System;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using InventoryManager.Models;

namespace InventoryManager.Forms
{
    public partial class ModifyPartForm : Form
    {
        private readonly Part _originalPart = null!;
        private readonly int _rowIndex;


        public ModifyPartForm()
        {
            InitializeComponent();
        }

        public ModifyPartForm(Part partToEdit, int rowIndex) : this()
        {
            _originalPart = partToEdit;
            _rowIndex = rowIndex;

            this.Text = "Modify Part";
            LoadPartIntoControls();
        }

        private void LoadPartIntoControls()
        {
            txtId.Text = _originalPart.PartID.ToString();
            txtName.Text = _originalPart.Name;
            txtInStock.Text = _originalPart.InStock.ToString();
            txtPrice.Text = _originalPart.Price.ToString(CultureInfo.CurrentCulture);
            txtMax.Text = _originalPart.Max.ToString();
            txtMin.Text = _originalPart.Min.ToString();

            if (_originalPart is InHouse ih)
            {
                rdoInHouse.Checked = true;
                lblVar.Text = "Machine ID";
                txtVar.Text = ih.MachineID.ToString();
            }

            else if (_originalPart is Outsourced os)
            {
                rdoOutsourced.Checked = true;
                lblVar.Text = "Company Name";
                txtVar.Text = os.CompanyName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var errors = new StringBuilder();

            // Basic validation
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
                errors.AppendLine("Name cannot be empty.");

            if (!int.TryParse(txtInStock.Text.Trim(), out int inStock))
                errors.AppendLine("Inventory must be a whole number.");

            if (!decimal.TryParse(txtPrice.Text.Trim(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal price))
                errors.AppendLine("Price must be a valid currency amount (e.g., $12.50).");

            if (!int.TryParse(txtMax.Text.Trim(), out int max))
                errors.AppendLine("Max must be a whole number.");

            if (!int.TryParse(txtMin.Text.Trim(), out int min))
                errors.AppendLine("Min must be a whole number.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inStock < min || inStock > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (price < 0m || min < 0 || max < 0 || inStock < 0)
            {
                MessageBox.Show("Inventory, Min, and Max must be zero or greater.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Commit the next available ID only when saving
            int partId = _originalPart.PartID;
            txtId.Text = partId.ToString();

            Part newPart;

            if (rdoInHouse.Checked)
            {
                if (!int.TryParse(txtVar.Text.Trim(), out int machineId))
                {
                    MessageBox.Show("Machine ID must be a whole number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                newPart = new InHouse
                {
                    PartID = partId,
                    Name = name,
                    Price = price,
                    InStock = inStock,
                    Min = min,
                    Max = max,
                    MachineID = machineId
                };
            }

            else
            {
                string company = txtVar.Text.Trim();

                if (string.IsNullOrWhiteSpace(company))
                {
                    MessageBox.Show("Company name cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                newPart = new Outsourced
                {
                    PartID = partId,
                    Name = name,
                    Price = price,
                    InStock = inStock,
                    Min = min,
                    Max = max,
                    CompanyName = company
                };
            }

            // Add to inventory and close
            Inventory.updatePart(_rowIndex, newPart);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInHouse.Checked) lblVar.Text = "Machine ID";
        }

        private void rdoOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOutsourced.Checked) lblVar.Text = "Company Name";
        }
    }
}

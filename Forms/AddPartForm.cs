using System;
using System.Text;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using InventoryManager.Models;
using System.Drawing.Text;

namespace InventoryManager.Forms
{
    public partial class AddPartForm : Form
    {
        // Adds red color if validation is invalid, no color if valid
        private void ColorRequired(TextBox tb, bool isValid)
        {
            tb.BackColor = isValid ? SystemColors.Window : Color.MistyRose;
        }

        // Re-runs validation color check for all fields on demand
        private void UpdateValidationColor()
        {
            // Name: required, non-empty
            ColorRequired(txtName, !string.IsNullOrWhiteSpace(txtName.Text));

            // InStock: required int
            ColorRequired(txtInStock, int.TryParse(txtInStock.Text.Trim(), out _));

            // Price: required currency
            ColorRequired(txtPrice, decimal.TryParse(
                txtPrice.Text.Trim(),
                NumberStyles.Currency,
                CultureInfo.CurrentCulture,
                out _));

            // Min/Max: required int
            ColorRequired(txtMin, int.TryParse(txtMin.Text.Trim(), out _));
            ColorRequired(txtMax, int.TryParse(txtMax.Text.Trim(), out _));

            // Var field based on radio
            if (rdoInHouse.Checked)
                ColorRequired(txtVar, int.TryParse(txtVar.Text.Trim(), out _));

            else
                ColorRequired(txtVar, !string.IsNullOrWhiteSpace(txtVar.Text));
        }

        private void WireValidationEvents()
        {
            txtName.TextChanged += (_, _) => UpdateValidationColor();
            txtInStock.TextChanged += (_, _) => UpdateValidationColor();
            txtPrice.TextChanged += (_, _) => UpdateValidationColor();
            txtMin.TextChanged += (_, _) => UpdateValidationColor();
            txtMax.TextChanged += (_, _) => UpdateValidationColor();
            txtVar.TextChanged += (_, _) => UpdateValidationColor();
        }

        public AddPartForm()
        {
            InitializeComponent();

            // Defaults
            rdoInHouse.Checked = true;
            lblVar.Text = "Machine ID";

            // ID is assigned and read-only
            txtId.ReadOnly = true;
            txtId.Text = Inventory.PeekNextPartID().ToString();

            WireValidationEvents();
            UpdateValidationColor();


            // Toggle the last label based on radio choice
            rdoInHouse.CheckedChanged += (_, _) =>
            {
                if (rdoInHouse.Checked) lblVar.Text = "Machine ID";
                UpdateValidationColor();
            };

            rdoOutsourced.CheckedChanged += (_, _) =>
            {
                if (rdoOutsourced.Checked) lblVar.Text = "Company Name";
                UpdateValidationColor();
            };
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

            if (price < 0m)
            {
                MessageBox.Show("Price cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (min < 0 || max < 0 || inStock < 0)
            {
                MessageBox.Show("Inventory, Min, and Max must be zero or greater.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Commit the next available ID only when saving
            int partId = Inventory.NextPartID();
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
            Inventory.addPart(newPart);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
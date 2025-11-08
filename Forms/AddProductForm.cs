using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using InventoryManager.Models;

namespace InventoryManager.Forms
{
    public partial class AddProductForm : Form
    {
        private readonly BindingList<Part> _associated = new();

        public AddProductForm()
        {
            InitializeComponent();

            txtId.ReadOnly = true;
            txtId.Text = Inventory.PeekNextProductID().ToString();

            dgvAllParts.AutoGenerateColumns = true;
            dgvAllParts.DataSource = Inventory.AllParts;

            dgvAssociatedParts.AutoGenerateColumns = true;
            dgvAssociatedParts.DataSource = _associated;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow?.DataBoundItem is not Part selected)
            {
                MessageBox.Show("Select a part to add.", "Add Part", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Avoid duplicates by PartID
            if (_associated.Any(p => p.PartID == selected.PartID))
                return;

            _associated.Add(selected);
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow?.DataBoundItem is not Part selected)
            {
                MessageBox.Show("Select an associated part to remove.", "Remove Part", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Remove '{selected.Name}' from this product?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _associated.Remove(selected);
            }
        }

        private void btnSearchPartsForProduct_Click(object sender, EventArgs e)
        {
            string q = txtSearchPartsForProduct.Text.Trim();

            if (string.IsNullOrEmpty(q))
            {
                dgvAllParts.DataSource = Inventory.AllParts;
                return;
            }

            var matches = Inventory.AllParts
                .Where(p => p.Name.Contains(q, StringComparison.OrdinalIgnoreCase)
                || p.PartID.ToString() == q)
                .ToList();

            if (matches.Count == 0)
            {
                MessageBox.Show("No matching parts found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAllParts.DataSource = Inventory.AllParts;
                return;
            }

            dgvAllParts.DataSource = new BindingList<Part>(matches);
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
                MessageBox.Show("Price, Inventory, Min, and Max must be zero or greater.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Inventory.NextProductID();
            txtId.Text = productId.ToString();

            var product = new Product
            {
                ProductID = productId,
                Name = name,
                Price = price,
                InStock = inStock,
                Min = min,
                Max = max
            };

            foreach (var p in _associated)
                product.AssociatedParts.Add(p);

            Inventory.addProduct(product);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

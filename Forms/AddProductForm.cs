using System.ComponentModel;
using System.Globalization;
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
    }
}

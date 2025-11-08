using System.ComponentModel;
using InventoryManager.Models;
using InventoryManager.Forms;

namespace InventoryManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Binding live lists
            dgvParts.AutoGenerateColumns = true;
            dgvParts.DataSource = Inventory.AllParts;

            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = Inventory.Products;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            using var dlg = new AddPartForm();
            var result = dlg.ShowDialog(this);
        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dgvParts.CurrentRow == null || dgvParts.CurrentRow.DataBoundItem is not Part selectedPart)
            {
                MessageBox.Show("Please select a part to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get index in the BindingList so the correct item can be updated
            int rowIndex = dgvParts.CurrentRow.Index;

            using var dlg = new ModifyPartForm(selectedPart, rowIndex);
            dlg.ShowDialog(this);
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow?.DataBoundItem is not Part selectedPart)
            {
                MessageBox.Show("Please select a part to delete.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"Delete part '{selectedPart.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    Inventory.deletePart(selectedPart);

                    MessageBox.Show($"Part '{selectedPart.Name}' deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            string query = txtSearchParts.Text.Trim();

            // If empty, restore the full list.
            if (string.IsNullOrWhiteSpace(query))
            {
                dgvParts.DataSource = Inventory.AllParts;
                return;
            }

            // Case-insensitive name match + optional ID match
            bool isId = int.TryParse(query, out int id);
            var matches = Inventory.AllParts
                .Where(p =>
                    (isId && p.PartID == id) ||
                    (!string.IsNullOrEmpty(p.Name) &&
                    p.Name.IndexOf(query, StringComparison.CurrentCultureIgnoreCase) >= 0))
                .ToList();

            if (matches.Count == 0)
            {
                MessageBox.Show("No matching parts found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvParts.DataSource = Inventory.AllParts;
                return;
            }

            // Show only the matches
            dgvParts.DataSource = new BindingList<Part>(matches);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using var dlg = new AddProductForm();
            dlg.ShowDialog(this);
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not Product selected)
            {
                MessageBox.Show("Please select a product to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int rowIndex = dgvProducts.CurrentRow.Index;

            using var dlg = new ModifyProductForm(selected, rowIndex);
            dlg.ShowDialog(this);
        }
    }
}
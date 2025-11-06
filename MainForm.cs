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
    }
}
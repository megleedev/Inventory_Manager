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
    }
}
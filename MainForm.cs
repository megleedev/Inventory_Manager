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

            Inventory.AllParts.Add(new InHouse
            {
                PartID = Inventory.NextPartID(),
                Name = "Test Bolt",
                Price = 0.99m,
                InStock = 100,
                Min = 1,
                Max = 500,
                MachineID = 101
            });

            Inventory.Products.Add(new Product
            {
                ProductID = Inventory.NextProductID(),
                Name = "Test Widget",
                Price = 12.49m,
                InStock = 15,
                Min = 1,
                Max = 100
            });
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            using var dlg = new AddPartForm();
            var result = dlg.ShowDialog(this);
        }
    }
}
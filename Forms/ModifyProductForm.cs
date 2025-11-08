using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InventoryManager.Models;

namespace InventoryManager.Forms
{
    public partial class ModifyProductForm : Form
    {
        private readonly Product _original;
        private readonly int _rowIndex;
        private readonly BindingList<Part> _associated = new();

        public ModifyProductForm(Product productToEdit, int rowIndex)
        {
            InitializeComponent();
            _original = productToEdit;
            _rowIndex = rowIndex;

            txtId.ReadOnly = true;

            dgvAllParts.AutoGenerateColumns = true;
            dgvAllParts.DataSource = Inventory.AllParts;

            dgvAssociatedParts.AutoGenerateColumns = true;
            dgvAssociatedParts.DataSource = _associated;

            LoadProductIntoControls();
        }

        private void LoadProductIntoControls()
        {
            txtId.Text = _original.ProductID.ToString();
            txtName.Text = _original.Name.ToString();
            txtInStock.Text = _original.InStock.ToString();
            txtPrice.Text = _original.Price.ToString(CultureInfo.CurrentCulture);
            txtMax.Text = _original.Max.ToString();
            txtMin.Text = _original.Min.ToString();

            _associated.Clear();
            foreach (var p in _original.AssociatedParts)
                _associated.Add(p);
        }
    }
}

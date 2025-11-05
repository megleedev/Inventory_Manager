using System.ComponentModel;

namespace InventoryManager.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; } = new();


        public void addAssociatedPart (Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart (int partID)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == partID)
                {
                    AssociatedParts.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public Part lookupAssociatedPart (int partID)
        {
            foreach (var p in AssociatedParts)
            {
                if (p.PartID == partID) return p;
            }

            throw new KeyNotFoundException($"No associated part found with the ID {partID}.");
        }
    }
}
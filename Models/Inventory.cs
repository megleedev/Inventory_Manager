using System.ComponentModel;
using System.Linq;

namespace InventoryManager.Models
{
    public static class Inventory
    {
        public static BindingList<Part> AllParts { get; } = new();
        public static BindingList<Product> Products { get; } = new();


        // ID generators for Parts and Products
        private static int _nextPartID = 1;
        private static int _nextProductID = 1;
        public static int NextPartID() => _nextPartID++;
        public static int PeekNextPartID() => _nextPartID;
        public static int NextProductID() => _nextProductID++;
        public static int PeekNextProductID() => _nextProductID;

        // Part methods
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            bool isAssociated = Products.Any(prod => prod.AssociatedParts.Any(ap => ap.PartID == part.PartID));

            if (isAssociated)
            {
                throw new InvalidOperationException("Cannot delete a part that is associated with a product.");
            }

            return AllParts.Remove(part);
        }

        public static Part lookupPart(int partID)
        {
            foreach (var p in AllParts)
            {
                if (p.PartID == partID) return p;
            }

            throw new KeyNotFoundException($"No part found with ID {partID}");
        }

        public static void updatePart(int index, Part replacement)
        {
            AllParts[index] = replacement;
        }

        // Product methods
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            // remove according to the ID; return true if removed
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    if (Products[i].AssociatedParts.Count > 0)
                        throw new InvalidOperationException("Cannot delete a product with associated parts.");

                    Products.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public static Product lookupProduct(int productID)
        {
            foreach (var p in Products)
            {
                if (p.ProductID == productID) return p;
            }

            throw new KeyNotFoundException($"No product found with the ID {productID}.");
        }

        public static void updateProduct(int index, Product replacement)
        {
            Products[index] = replacement;
        }
    }
}
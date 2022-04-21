using System.ComponentModel;

namespace C968_Software_I_Dainen_Mann
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();
        public static int uniquePartID = 0;
        public static int uniqueProductID = 0;
        public static void incUniquePartID()
        {
            for (int i = 1; i < +100; i++)
            {
                uniquePartID = uniquePartID + 1;
                return;
            }
        }
        public static void incUniqueProductID()
        {
            for (int i = 1; i <= 100; i++)
            {
                uniqueProductID = uniqueProductID + 1;
                return;
            }
        }

        //Product Methods
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool deleteProduct(int productID)
        {
            Product productToDelete = lookupProduct(productID);
            if (productToDelete == null)
            {
                return false;
            }
            else
            {
                Products.Remove(productToDelete);
                return true;
            }
        }
        public static Product lookupProduct(int productID)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    return p;
                }
            }
            return null;
        }
        public static void updateProduct(int productID, Product product)
        {
            deleteProduct(productID);
            AddProduct(product);
        }

        //Part Methods
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }
        public static Part lookupPart(int partID)
        {
            foreach (Part p in Parts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }

        public static void updatePart(int partID, Part part)
        {
            deletePart(partID);
            AddPart(part);
        }


        public static bool deletePart(int partID)
        {
            Part partToDelete = lookupPart(partID);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                Parts.Remove(partToDelete);
                return true;
            }
        }

    }
}

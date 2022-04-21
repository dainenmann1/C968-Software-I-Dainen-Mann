using System.ComponentModel;

namespace C968_Software_I_Dainen_Mann
{
    public class Product
    {
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        //getters and setters
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //Methods
        public void AddAssociatedParts(Part part)
        {
            AssociatedParts.Add(part);
        }
        public Part lookupAssociatedPart(int partID)
        {
            foreach (Part p in AssociatedParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }
        public bool removeAssociatedPart(int partID)
        {
            Part partToRemove = lookupAssociatedPart(partID);
            if (partToRemove == null)
            {
                return false;
            }
            else
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
        }
    }
}

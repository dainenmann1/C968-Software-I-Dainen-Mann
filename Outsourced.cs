namespace C968_Software_I_Dainen_Mann
{
    public class Outsourced : Part
    {
        private string companyName;
        public string CompanyName { get; set; }

        //Constructor
        public Outsourced(BasePart b, string companyName)
        {
            PartID = b.partID;
            Name = b.name;
            Inventory = b.inStock;
            Price = b.price;
            Min = b.min;
            Max = b.max;
            CompanyName = companyName;
        }
    }
}

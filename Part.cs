namespace C968_Software_I_Dainen_Mann
{
    public struct BasePart
    {
        public int partID;
        public string name;
        public decimal price;
        public int inStock;
        public int min;
        public int max;

    }
    public abstract class Part
    {
        private int _partID;
        private string _partName;
        private int _partInventory;
        private double _partPrice;
        private int _partMin;
        private int _partMax;

        //getters and setters
        public int PartID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}

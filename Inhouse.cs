namespace C968_Software_I_Dainen_Mann
{
    class InHouse : Part
    {
        private int machineID;
        public int MachineID { get; set; }

        //Constructor
        public InHouse(BasePart b, int machineID)
        {
            PartID = b.partID;
            Name = b.name;
            Inventory = b.inStock;
            Price = b.price;
            Min = b.min;
            Max = b.max;
            MachineID = machineID;
        }
    }
}

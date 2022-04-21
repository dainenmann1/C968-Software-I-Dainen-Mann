using System;
using System.Windows.Forms;

namespace C968_Software_I_Dainen_Mann
{
    public partial class ModifyPartScreen : Form
    {
        public int selectedID;
        public ModifyPartScreen()
        {
            InitializeComponent();
        }
        private void inHouseOrOutsourcedLabel()
        {
            if (modifyInHouseRadio.Checked)
                modifyMachineIDLabel.Text = "Machine ID";
            else
                modifyMachineIDLabel.Text = "Company Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var selectedPart = Inventory.lookupPart(selectedID);

            // Populates form with selected part details
            modifyIDBox.Text = selectedPart.PartID.ToString();
            modifyNameBox.Text = selectedPart.Name;
            modifyInventoryBox.Text = selectedPart.Inventory.ToString();
            modifyPriceBox.Text = selectedPart.Price.ToString();
            modifyMaxBox.Text = selectedPart.Max.ToString();
            modifyMinBox.Text = selectedPart.Min.ToString();
            if (selectedPart is InHouse)
            {
                modifyMachineIDLabel.Text = "Machine ID";
                modifyInHouseRadio.Checked = true;
                modifyMachineIDBox.Text = ((InHouse)selectedPart).MachineID.ToString();
            }
            else
            {
                modifyMachineIDLabel.Text = "Company Name";
                modifyOutsourcedRadio.Checked = true;
                modifyMachineIDBox.Text = ((Outsourced)selectedPart).CompanyName.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            inHouseOrOutsourcedLabel();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void modifyInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            inHouseOrOutsourcedLabel();
        }

        private void modifyCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifySaveButton_Click(object sender, EventArgs e)
        {
            int inventoryStock;
            int maxInStock;
            int minInStock;
            decimal priceValue;
            int machineIDValue;

            bool invParse = int.TryParse(modifyInventoryBox.Text, out inventoryStock);
            bool minParse = int.TryParse(modifyMinBox.Text, out minInStock);
            bool maxParse = int.TryParse(modifyMaxBox.Text, out maxInStock);
            bool priceParse = decimal.TryParse(modifyPriceBox.Text, out priceValue);
            bool machineIDParse = int.TryParse(modifyMachineIDBox.Text, out machineIDValue);

            if (!modifyInHouseRadio.Checked && !modifyOutsourcedRadio.Checked)
            {
                MessageBox.Show("Error: In-House or Outsourced should be checked.");
                return;
            }
            else if (!minParse)
            {
                MessageBox.Show("Error: Min value must be numeric.");
                return;
            }
            else if (!maxParse)
            {
                MessageBox.Show("Error: Max value must be numeric.");
                return;
            }
            else if (!invParse)
            {
                MessageBox.Show("Error: Inventory value must be numeric.");
                return;
            }
            else if (!priceParse)
            {
                MessageBox.Show("Error: Price value must be a decimal.");
                return;
            }
            else if (modifyInHouseRadio.Checked && !machineIDParse)
            {
                MessageBox.Show("Error: Machine ID value must be a numeric value.");
                return;
            }

            if (minInStock > maxInStock)
            {
                MessageBox.Show("Error: Minimum stock cannot be more than maximum stock.");
                return;
            }

            if (inventoryStock < minInStock || inventoryStock > maxInStock)
            {
                MessageBox.Show("Error: Inventory Stock cannot be higher or lower than Max/Min value.");
                return;
            }

            BasePart b = new BasePart();
            b.partID = Int32.Parse(modifyIDBox.Text);
            b.name = modifyNameBox.Text;
            b.price = decimal.Parse(modifyPriceBox.Text);
            b.min = Int32.Parse(modifyMinBox.Text);
            b.max = Int32.Parse(modifyMaxBox.Text);
            b.inStock = Int32.Parse(modifyInventoryBox.Text);

            if (modifyInHouseRadio.Checked)
            {
                InHouse newPart = new InHouse(b, Int32.Parse(modifyMachineIDBox.Text));
                Inventory.updatePart(newPart.PartID, newPart);
            }
            else
            {
                Outsourced newPart = new Outsourced(b, modifyMachineIDBox.Text);
                Inventory.updatePart(newPart.PartID, newPart);
            }
            Close();
        }
    }
}

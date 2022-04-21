using System;
using System.Windows.Forms;

namespace C968_Software_I_Dainen_Mann
{
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
            partIDTextBox.Text = Inventory.uniquePartID.ToString();
        }
        private void inhouseOrOutsourcedLabel()
        {
            if (inHouseRadio.Checked)
                partMachineOrCompanyLabel.Text = "Machine ID";
            else
                partMachineOrCompanyLabel.Text = "Company Name";
        }

        private void AddPartScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddPartLabel_Click(object sender, EventArgs e)
        {

        }

        private void PartCancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            inhouseOrOutsourcedLabel();
        }

        private void PartMachineIDlabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void PartSavebutton_Click(object sender, EventArgs e)
        {
            int inventoryStock;
            int maxInStock;
            int minInStock;
            decimal priceValue;
            int machineIDValue;

            bool invParse = int.TryParse(partInvTextBox.Text, out inventoryStock);
            bool minParse = int.TryParse(partMinTextBox.Text, out minInStock);
            bool maxParse = int.TryParse(partMaxTextBox.Text, out maxInStock);
            bool priceParse = decimal.TryParse(partPriceTextBox.Text, out priceValue);
            bool machineIDParse = int.TryParse(machineOrCompTextBox.Text, out machineIDValue);

            if (!inHouseRadio.Checked && !AddPartOutsourced.Checked)
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
            else if (inHouseRadio.Checked && !machineIDParse)
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
            b.partID = Int32.Parse(partIDTextBox.Text);
            b.name = partNameTextBox.Text;
            b.price = decimal.Parse(partPriceTextBox.Text);
            b.min = Int32.Parse(partMinTextBox.Text);
            b.max = Int32.Parse(partMaxTextBox.Text);
            b.inStock = Int32.Parse(partInvTextBox.Text);

            if (inHouseRadio.Checked)
            {
                InHouse newPart = new InHouse(b, Int32.Parse(machineOrCompTextBox.Text));
                Inventory.AddPart(newPart);
            }
            else
            {
                Outsourced newPart = new Outsourced(b, machineOrCompTextBox.Text);
                Inventory.AddPart(newPart);
            }
            Close();
        }

        private void partIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

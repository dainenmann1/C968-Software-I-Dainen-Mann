using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace C968_Software_I_Dainen_Mann
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            LoadFormData();
            productIDTextBox.Text = Inventory.uniqueProductID.ToString();
        }

        public void LoadFormData()
        {
            addCandidateParts.DataSource = Inventory.Parts;
        }
        
        public BindingList<Part> preAssociatedParts = new BindingList<Part>();

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> filtered = new BindingList<Part>(Inventory.Parts.Where(obj => obj.Name.Contains(searchTextBox.Text)).ToList());

            addCandidateParts.DataSource = filtered;
            addCandidateParts.Update();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int inventoryStock;
            int maxInStock;
            int minInStock;
            decimal priceValue;

            bool invParse = int.TryParse(productInvBox.Text, out inventoryStock);
            bool minParse = int.TryParse(productMinBox.Text, out minInStock);
            bool maxParse = int.TryParse(productMaxBox.Text, out maxInStock);
            bool priceParse = decimal.TryParse(productPriceBox.Text, out priceValue);

            if (!minParse)
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

            Product newProduct = new Product();
            newProduct.ProductID = Int32.Parse(productIDTextBox.Text);
            newProduct.Name = productNameBox.Text;
            newProduct.Price = decimal.Parse(productPriceBox.Text);
            newProduct.Min = Int32.Parse(productMinBox.Text);
            newProduct.Max = Int32.Parse(productMaxBox.Text);
            newProduct.InStock = Int32.Parse(productInvBox.Text);

            foreach (Part part in preAssociatedParts)
            {
                newProduct.AddAssociatedParts(part);
            }

            Inventory.AddProduct(newProduct);
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int selectedPartID = Int32.Parse(addCandidateParts.Rows[addCandidateParts.CurrentCell.RowIndex].Cells[addCandidateParts.CurrentCell.ColumnIndex].Value.ToString());
            var selectedPart = Inventory.lookupPart(selectedPartID);
            preAssociatedParts.Add(selectedPart);
            associatedParts.DataSource = preAssociatedParts;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            associatedParts.Rows.Remove(associatedParts.CurrentRow);
        }
    }
}

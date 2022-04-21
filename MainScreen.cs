using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace C968_Software_I_Dainen_Mann
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            LoadFormData();
        }

        int selectedRowIndex;

        //Load Data Grid source method
        public void LoadFormData()
        {
            partDataGrid.DataSource = Inventory.Parts;
            productDataGrid.DataSource = Inventory.Products;
        }
        public void removeRow()
        {
            if (this.partDataGrid.SelectedRows.Count > 0)
            {
                partDataGrid.Rows.RemoveAt(this.partDataGrid.SelectedRows[0].Index);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory.incUniquePartID();
            AddPartScreen newPart = new AddPartScreen();
            newPart.Show();

        }

        private void PartDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Warning", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
                Inventory.deletePart(Int32.Parse(partDataGrid.Rows[partDataGrid.CurrentCell.RowIndex].Cells[partDataGrid.CurrentCell.ColumnIndex].Value.ToString()));
                removeRow();
            }
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PartModify_Click(object sender, EventArgs e)
        {
            ModifyPartScreen modifyPartScreen = new ModifyPartScreen();
            modifyPartScreen.selectedID = Int32.Parse(partDataGrid.Rows[partDataGrid.CurrentCell.RowIndex].Cells[partDataGrid.CurrentCell.ColumnIndex].Value.ToString());
            modifyPartScreen.Show();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            Inventory.incUniqueProductID();
            AddProduct newProduct = new AddProduct();
            newProduct.Show();
        }

        private void searchPartButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> filtered = new BindingList<Part>(Inventory.Parts.Where(obj => obj.Name.Contains(partSearchBox.Text)).ToList());

            if (partSearchBox.Text.Count() > 0)
            {
                partDataGrid.DataSource = filtered;
                partDataGrid.Update();
            }
            else
            {
                partDataGrid.DataSource = Inventory.Parts;
                partDataGrid.Update();
            }
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            BindingList<Product> filtered = new BindingList<Product>(Inventory.Products.Where(obj => obj.Name.Contains(productSearchBox.Text)).ToList());

            productDataGrid.DataSource = filtered;
            productDataGrid.Update();
        }

        private void ProductDelete_Click(object sender, EventArgs e)
        {
            Product delProduct = Inventory.lookupProduct(Int32.Parse(productDataGrid.Rows[productDataGrid.CurrentCell.RowIndex].Cells[productDataGrid.CurrentCell.ColumnIndex].Value.ToString()));
            DialogResult prodDialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Warning", MessageBoxButtons.YesNo);

            if (prodDialogResult == DialogResult.No)
            {
                return;
            }
            if (delProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Unable to delete product with associated parts. Remove associated parts and try again", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                Inventory.deleteProduct(Int32.Parse(productDataGrid.Rows[productDataGrid.CurrentCell.RowIndex].Cells[productDataGrid.CurrentCell.ColumnIndex].Value.ToString()));
                removeRow();
            }
        }

        private void ProductModify_Click(object sender, EventArgs e)
        {
            ModifyProduct modifyProductScreen = new ModifyProduct();
            modifyProductScreen.selectedID = Int32.Parse(productDataGrid.Rows[productDataGrid.CurrentCell.RowIndex].Cells[productDataGrid.CurrentCell.ColumnIndex].Value.ToString());
            modifyProductScreen.Show();
        }
    }
}

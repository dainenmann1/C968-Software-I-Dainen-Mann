
namespace C968_Software_I_Dainen_Mann
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addCandidateParts = new System.Windows.Forms.DataGridView();
            this.associatedParts = new System.Windows.Forms.DataGridView();
            this.associatedLabel = new System.Windows.Forms.Label();
            this.candidateLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.productInvBox = new System.Windows.Forms.TextBox();
            this.productPriceBox = new System.Windows.Forms.TextBox();
            this.productMaxBox = new System.Windows.Forms.TextBox();
            this.productMinBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addCandidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(137, 207);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(119, 254);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(111, 307);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(55, 15);
            this.inventoryLabel.TabIndex = 2;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(121, 362);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 15);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(119, 425);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(31, 15);
            this.maxLabel.TabIndex = 4;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(281, 425);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 15);
            this.minLabel.TabIndex = 5;
            this.minLabel.Text = "Min";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(13, 13);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(73, 15);
            this.ProductLabel.TabIndex = 6;
            this.ProductLabel.Text = "Add Product";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(798, 66);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(258, 21);
            this.searchTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(687, 66);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addCandidateParts
            // 
            this.addCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addCandidateParts.Location = new System.Drawing.Point(499, 111);
            this.addCandidateParts.Name = "addCandidateParts";
            this.addCandidateParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addCandidateParts.Size = new System.Drawing.Size(557, 203);
            this.addCandidateParts.TabIndex = 9;
            // 
            // associatedParts
            // 
            this.associatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedParts.Location = new System.Drawing.Point(499, 415);
            this.associatedParts.Name = "associatedParts";
            this.associatedParts.Size = new System.Drawing.Size(557, 205);
            this.associatedParts.TabIndex = 10;
            // 
            // associatedLabel
            // 
            this.associatedLabel.AutoSize = true;
            this.associatedLabel.Location = new System.Drawing.Point(496, 387);
            this.associatedLabel.Name = "associatedLabel";
            this.associatedLabel.Size = new System.Drawing.Size(189, 15);
            this.associatedLabel.TabIndex = 11;
            this.associatedLabel.Text = "Parts Associated with this Product";
            // 
            // candidateLabel
            // 
            this.candidateLabel.AutoSize = true;
            this.candidateLabel.Location = new System.Drawing.Point(496, 74);
            this.candidateLabel.Name = "candidateLabel";
            this.candidateLabel.Size = new System.Drawing.Size(108, 15);
            this.candidateLabel.TabIndex = 12;
            this.candidateLabel.Text = "All candidate Parts";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(981, 643);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 30);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(878, 698);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(981, 698);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(981, 336);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 30);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Enabled = false;
            this.productIDTextBox.Location = new System.Drawing.Point(184, 207);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(100, 21);
            this.productIDTextBox.TabIndex = 17;
            // 
            // productNameBox
            // 
            this.productNameBox.Location = new System.Drawing.Point(184, 251);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(100, 21);
            this.productNameBox.TabIndex = 18;
            // 
            // productInvBox
            // 
            this.productInvBox.Location = new System.Drawing.Point(184, 304);
            this.productInvBox.Name = "productInvBox";
            this.productInvBox.Size = new System.Drawing.Size(100, 21);
            this.productInvBox.TabIndex = 19;
            // 
            // productPriceBox
            // 
            this.productPriceBox.Location = new System.Drawing.Point(184, 359);
            this.productPriceBox.Name = "productPriceBox";
            this.productPriceBox.Size = new System.Drawing.Size(100, 21);
            this.productPriceBox.TabIndex = 20;
            // 
            // productMaxBox
            // 
            this.productMaxBox.Location = new System.Drawing.Point(162, 422);
            this.productMaxBox.Name = "productMaxBox";
            this.productMaxBox.Size = new System.Drawing.Size(100, 21);
            this.productMaxBox.TabIndex = 21;
            // 
            // productMinBox
            // 
            this.productMinBox.Location = new System.Drawing.Point(315, 422);
            this.productMinBox.Name = "productMinBox";
            this.productMinBox.Size = new System.Drawing.Size(100, 21);
            this.productMinBox.TabIndex = 22;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(C968_Software_I_Dainen_Mann.Product);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 738);
            this.Controls.Add(this.productMinBox);
            this.Controls.Add(this.productMaxBox);
            this.Controls.Add(this.productPriceBox);
            this.Controls.Add(this.productInvBox);
            this.Controls.Add(this.productNameBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.candidateLabel);
            this.Controls.Add(this.associatedLabel);
            this.Controls.Add(this.associatedParts);
            this.Controls.Add(this.addCandidateParts);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.addCandidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView addCandidateParts;
        private System.Windows.Forms.DataGridView associatedParts;
        private System.Windows.Forms.Label associatedLabel;
        private System.Windows.Forms.Label candidateLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.TextBox productInvBox;
        private System.Windows.Forms.TextBox productPriceBox;
        private System.Windows.Forms.TextBox productMaxBox;
        private System.Windows.Forms.TextBox productMinBox;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}
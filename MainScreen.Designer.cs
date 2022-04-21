
namespace C968_Software_I_Dainen_Mann
{
    partial class MainScreen
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
            this.ProductLabelmain = new System.Windows.Forms.Label();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.partDataGrid = new System.Windows.Forms.DataGridView();
            this.PartLabelmain = new System.Windows.Forms.Label();
            this.PartAdd = new System.Windows.Forms.Button();
            this.PartModify = new System.Windows.Forms.Button();
            this.PartDelete = new System.Windows.Forms.Button();
            this.ProductAdd = new System.Windows.Forms.Button();
            this.ProductModify = new System.Windows.Forms.Button();
            this.ProductDelete = new System.Windows.Forms.Button();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.searchPartButton = new System.Windows.Forms.Button();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductLabelmain
            // 
            this.ProductLabelmain.AutoSize = true;
            this.ProductLabelmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabelmain.Location = new System.Drawing.Point(681, 81);
            this.ProductLabelmain.Name = "ProductLabelmain";
            this.ProductLabelmain.Size = new System.Drawing.Size(72, 20);
            this.ProductLabelmain.TabIndex = 0;
            this.ProductLabelmain.Text = "Products";
            this.ProductLabelmain.Click += new System.EventHandler(this.label1_Click);
            // 
            // productDataGrid
            // 
            this.productDataGrid.AllowUserToAddRows = false;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Location = new System.Drawing.Point(685, 109);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGrid.Size = new System.Drawing.Size(642, 250);
            this.productDataGrid.TabIndex = 1;
            this.productDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // partDataGrid
            // 
            this.partDataGrid.AllowUserToAddRows = false;
            this.partDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.partDataGrid.Location = new System.Drawing.Point(12, 109);
            this.partDataGrid.Name = "partDataGrid";
            this.partDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.partDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDataGrid.Size = new System.Drawing.Size(642, 250);
            this.partDataGrid.TabIndex = 2;
            this.partDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // PartLabelmain
            // 
            this.PartLabelmain.AutoSize = true;
            this.PartLabelmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartLabelmain.Location = new System.Drawing.Point(8, 81);
            this.PartLabelmain.Name = "PartLabelmain";
            this.PartLabelmain.Size = new System.Drawing.Size(46, 20);
            this.PartLabelmain.TabIndex = 3;
            this.PartLabelmain.Text = "Parts";
            // 
            // PartAdd
            // 
            this.PartAdd.Location = new System.Drawing.Point(395, 379);
            this.PartAdd.Name = "PartAdd";
            this.PartAdd.Size = new System.Drawing.Size(75, 23);
            this.PartAdd.TabIndex = 4;
            this.PartAdd.Text = "Add";
            this.PartAdd.UseVisualStyleBackColor = true;
            this.PartAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // PartModify
            // 
            this.PartModify.Location = new System.Drawing.Point(487, 379);
            this.PartModify.Name = "PartModify";
            this.PartModify.Size = new System.Drawing.Size(75, 23);
            this.PartModify.TabIndex = 5;
            this.PartModify.Text = "Modify";
            this.PartModify.UseVisualStyleBackColor = true;
            this.PartModify.Click += new System.EventHandler(this.PartModify_Click);
            // 
            // PartDelete
            // 
            this.PartDelete.Location = new System.Drawing.Point(579, 379);
            this.PartDelete.Name = "PartDelete";
            this.PartDelete.Size = new System.Drawing.Size(75, 23);
            this.PartDelete.TabIndex = 6;
            this.PartDelete.Text = "Delete";
            this.PartDelete.UseVisualStyleBackColor = true;
            this.PartDelete.Click += new System.EventHandler(this.PartDelete_Click);
            // 
            // ProductAdd
            // 
            this.ProductAdd.Location = new System.Drawing.Point(1059, 379);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(75, 23);
            this.ProductAdd.TabIndex = 7;
            this.ProductAdd.Text = "Add";
            this.ProductAdd.UseVisualStyleBackColor = true;
            this.ProductAdd.Click += new System.EventHandler(this.ProductAdd_Click);
            // 
            // ProductModify
            // 
            this.ProductModify.Location = new System.Drawing.Point(1151, 379);
            this.ProductModify.Name = "ProductModify";
            this.ProductModify.Size = new System.Drawing.Size(75, 23);
            this.ProductModify.TabIndex = 8;
            this.ProductModify.Text = "Modify";
            this.ProductModify.UseVisualStyleBackColor = true;
            this.ProductModify.Click += new System.EventHandler(this.ProductModify_Click);
            // 
            // ProductDelete
            // 
            this.ProductDelete.Location = new System.Drawing.Point(1252, 379);
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.Size = new System.Drawing.Size(75, 23);
            this.ProductDelete.TabIndex = 9;
            this.ProductDelete.Text = "Delete";
            this.ProductDelete.UseVisualStyleBackColor = true;
            this.ProductDelete.Click += new System.EventHandler(this.ProductDelete_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(1252, 456);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(75, 23);
            this.ExitProgram.TabIndex = 10;
            this.ExitProgram.Text = "Exit";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(454, 81);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(200, 20);
            this.partSearchBox.TabIndex = 11;
            // 
            // productSearchBox
            // 
            this.productSearchBox.Location = new System.Drawing.Point(1127, 79);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(200, 20);
            this.productSearchBox.TabIndex = 12;
            // 
            // searchPartButton
            // 
            this.searchPartButton.Location = new System.Drawing.Point(373, 79);
            this.searchPartButton.Name = "searchPartButton";
            this.searchPartButton.Size = new System.Drawing.Size(75, 23);
            this.searchPartButton.TabIndex = 13;
            this.searchPartButton.Text = "Search";
            this.searchPartButton.UseVisualStyleBackColor = true;
            this.searchPartButton.Click += new System.EventHandler(this.searchPartButton_Click);
            // 
            // searchProductButton
            // 
            this.searchProductButton.Location = new System.Drawing.Point(1042, 79);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(75, 23);
            this.searchProductButton.TabIndex = 14;
            this.searchProductButton.Text = "Search";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(C968_Software_I_Dainen_Mann.Part);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(C968_Software_I_Dainen_Mann.Inventory);
            // 
            // partBindingSource1
            // 
            this.partBindingSource1.DataSource = typeof(C968_Software_I_Dainen_Mann.Part);
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataSource = typeof(C968_Software_I_Dainen_Mann.Inventory);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 561);
            this.Controls.Add(this.searchProductButton);
            this.Controls.Add(this.searchPartButton);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.ExitProgram);
            this.Controls.Add(this.ProductDelete);
            this.Controls.Add(this.ProductModify);
            this.Controls.Add(this.ProductAdd);
            this.Controls.Add(this.PartDelete);
            this.Controls.Add(this.PartModify);
            this.Controls.Add(this.PartAdd);
            this.Controls.Add(this.PartLabelmain);
            this.Controls.Add(this.partDataGrid);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.ProductLabelmain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductLabelmain;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Label PartLabelmain;
        private System.Windows.Forms.Button PartAdd;
        private System.Windows.Forms.Button PartModify;
        private System.Windows.Forms.Button PartDelete;
        private System.Windows.Forms.Button ProductAdd;
        private System.Windows.Forms.Button ProductModify;
        private System.Windows.Forms.Button ProductDelete;
        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.BindingSource partBindingSource1;
        private System.Windows.Forms.DataGridView partDataGrid;
        private System.Windows.Forms.Button searchPartButton;
        private System.Windows.Forms.Button searchProductButton;
    }
}


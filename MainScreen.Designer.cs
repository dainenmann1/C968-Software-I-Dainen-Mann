
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
            this.ProductLabelmain = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartLabelmain = new System.Windows.Forms.Label();
            this.PartAdd = new System.Windows.Forms.Button();
            this.PartModify = new System.Windows.Forms.Button();
            this.PartDelete = new System.Windows.Forms.Button();
            this.ProductAdd = new System.Windows.Forms.Button();
            this.ProductModify = new System.Windows.Forms.Button();
            this.ProductDelete = new System.Windows.Forms.Button();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.PartSearch = new System.Windows.Forms.TextBox();
            this.ProductSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.ProductLabelmain.UseWaitCursor = true;
            this.ProductLabelmain.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.ProductInventory,
            this.ProductPrice,
            this.ProductMin,
            this.ProductMax});
            this.dataGridView1.Location = new System.Drawing.Point(685, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(642, 250);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            // 
            // ProductInventory
            // 
            this.ProductInventory.HeaderText = "Inventory";
            this.ProductInventory.Name = "ProductInventory";
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // ProductMin
            // 
            this.ProductMin.HeaderText = "Min";
            this.ProductMin.Name = "ProductMin";
            // 
            // ProductMax
            // 
            this.ProductMax.HeaderText = "Max";
            this.ProductMax.Name = "ProductMax";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.PartInventory,
            this.PartPrice,
            this.PartMin,
            this.PartMax});
            this.dataGridView2.Location = new System.Drawing.Point(12, 109);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(642, 250);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.UseWaitCursor = true;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // PartID
            // 
            this.PartID.HeaderText = "Part ID";
            this.PartID.Name = "PartID";
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Name";
            this.PartName.Name = "PartName";
            // 
            // PartInventory
            // 
            this.PartInventory.HeaderText = "Inventory";
            this.PartInventory.Name = "PartInventory";
            // 
            // PartPrice
            // 
            this.PartPrice.HeaderText = "Price";
            this.PartPrice.Name = "PartPrice";
            // 
            // PartMin
            // 
            this.PartMin.HeaderText = "Min";
            this.PartMin.Name = "PartMin";
            // 
            // PartMax
            // 
            this.PartMax.HeaderText = "Max";
            this.PartMax.Name = "PartMax";
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
            this.PartLabelmain.UseWaitCursor = true;
            // 
            // PartAdd
            // 
            this.PartAdd.Location = new System.Drawing.Point(395, 379);
            this.PartAdd.Name = "PartAdd";
            this.PartAdd.Size = new System.Drawing.Size(75, 23);
            this.PartAdd.TabIndex = 4;
            this.PartAdd.Text = "Add";
            this.PartAdd.UseVisualStyleBackColor = true;
            this.PartAdd.UseWaitCursor = true;
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
            this.PartModify.UseWaitCursor = true;
            // 
            // PartDelete
            // 
            this.PartDelete.Location = new System.Drawing.Point(579, 379);
            this.PartDelete.Name = "PartDelete";
            this.PartDelete.Size = new System.Drawing.Size(75, 23);
            this.PartDelete.TabIndex = 6;
            this.PartDelete.Text = "Delete";
            this.PartDelete.UseVisualStyleBackColor = true;
            this.PartDelete.UseWaitCursor = true;
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
            this.ProductAdd.UseWaitCursor = true;
            // 
            // ProductModify
            // 
            this.ProductModify.Location = new System.Drawing.Point(1151, 379);
            this.ProductModify.Name = "ProductModify";
            this.ProductModify.Size = new System.Drawing.Size(75, 23);
            this.ProductModify.TabIndex = 8;
            this.ProductModify.Text = "Modify";
            this.ProductModify.UseVisualStyleBackColor = true;
            this.ProductModify.UseWaitCursor = true;
            // 
            // ProductDelete
            // 
            this.ProductDelete.Location = new System.Drawing.Point(1252, 379);
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.Size = new System.Drawing.Size(75, 23);
            this.ProductDelete.TabIndex = 9;
            this.ProductDelete.Text = "Delete";
            this.ProductDelete.UseVisualStyleBackColor = true;
            this.ProductDelete.UseWaitCursor = true;
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(1252, 456);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(75, 23);
            this.ExitProgram.TabIndex = 10;
            this.ExitProgram.Text = "Exit";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.UseWaitCursor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // PartSearch
            // 
            this.PartSearch.Location = new System.Drawing.Point(454, 81);
            this.PartSearch.Name = "PartSearch";
            this.PartSearch.Size = new System.Drawing.Size(200, 20);
            this.PartSearch.TabIndex = 11;
            this.PartSearch.UseWaitCursor = true;
            // 
            // ProductSearch
            // 
            this.ProductSearch.Location = new System.Drawing.Point(1123, 81);
            this.ProductSearch.Name = "ProductSearch";
            this.ProductSearch.Size = new System.Drawing.Size(200, 20);
            this.ProductSearch.TabIndex = 12;
            this.ProductSearch.UseWaitCursor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 561);
            this.Controls.Add(this.ProductSearch);
            this.Controls.Add(this.PartSearch);
            this.Controls.Add(this.ExitProgram);
            this.Controls.Add(this.ProductDelete);
            this.Controls.Add(this.ProductModify);
            this.Controls.Add(this.ProductAdd);
            this.Controls.Add(this.PartDelete);
            this.Controls.Add(this.PartModify);
            this.Controls.Add(this.PartAdd);
            this.Controls.Add(this.PartLabelmain);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProductLabelmain);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductLabelmain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductMax;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label PartLabelmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartMax;
        private System.Windows.Forms.Button PartAdd;
        private System.Windows.Forms.Button PartModify;
        private System.Windows.Forms.Button PartDelete;
        private System.Windows.Forms.Button ProductAdd;
        private System.Windows.Forms.Button ProductModify;
        private System.Windows.Forms.Button ProductDelete;
        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.TextBox PartSearch;
        private System.Windows.Forms.TextBox ProductSearch;
    }
}


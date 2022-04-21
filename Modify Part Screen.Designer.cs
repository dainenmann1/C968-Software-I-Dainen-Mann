
namespace C968_Software_I_Dainen_Mann
{
    partial class ModifyPartScreen
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
            this.modifySaveButton = new System.Windows.Forms.Button();
            this.modifyCancelButton = new System.Windows.Forms.Button();
            this.modifyInHouseRadio = new System.Windows.Forms.RadioButton();
            this.modifyOutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.modifyIDLabel = new System.Windows.Forms.Label();
            this.modifyNameLabel = new System.Windows.Forms.Label();
            this.modifyPriceLabel = new System.Windows.Forms.Label();
            this.modifyInventoryLabel = new System.Windows.Forms.Label();
            this.modifyMinLabel = new System.Windows.Forms.Label();
            this.modifyMaxLabel = new System.Windows.Forms.Label();
            this.modifyMachineIDLabel = new System.Windows.Forms.Label();
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.modifyIDBox = new System.Windows.Forms.TextBox();
            this.modifyNameBox = new System.Windows.Forms.TextBox();
            this.modifyInventoryBox = new System.Windows.Forms.TextBox();
            this.modifyPriceBox = new System.Windows.Forms.TextBox();
            this.modifyMinBox = new System.Windows.Forms.TextBox();
            this.modifyMaxBox = new System.Windows.Forms.TextBox();
            this.modifyMachineIDBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modifySaveButton
            // 
            this.modifySaveButton.Location = new System.Drawing.Point(249, 386);
            this.modifySaveButton.Name = "modifySaveButton";
            this.modifySaveButton.Size = new System.Drawing.Size(87, 27);
            this.modifySaveButton.TabIndex = 0;
            this.modifySaveButton.Text = "Save";
            this.modifySaveButton.UseVisualStyleBackColor = true;
            this.modifySaveButton.Click += new System.EventHandler(this.modifySaveButton_Click);
            // 
            // modifyCancelButton
            // 
            this.modifyCancelButton.Location = new System.Drawing.Point(384, 386);
            this.modifyCancelButton.Name = "modifyCancelButton";
            this.modifyCancelButton.Size = new System.Drawing.Size(87, 27);
            this.modifyCancelButton.TabIndex = 1;
            this.modifyCancelButton.Text = "Cancel";
            this.modifyCancelButton.UseVisualStyleBackColor = true;
            this.modifyCancelButton.Click += new System.EventHandler(this.modifyCancelButton_Click);
            // 
            // modifyInHouseRadio
            // 
            this.modifyInHouseRadio.AutoSize = true;
            this.modifyInHouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyInHouseRadio.Location = new System.Drawing.Point(167, 15);
            this.modifyInHouseRadio.Name = "modifyInHouseRadio";
            this.modifyInHouseRadio.Size = new System.Drawing.Size(75, 19);
            this.modifyInHouseRadio.TabIndex = 2;
            this.modifyInHouseRadio.TabStop = true;
            this.modifyInHouseRadio.Text = "In-House";
            this.modifyInHouseRadio.UseVisualStyleBackColor = true;
            this.modifyInHouseRadio.CheckedChanged += new System.EventHandler(this.modifyInHouseRadio_CheckedChanged);
            // 
            // modifyOutsourcedRadio
            // 
            this.modifyOutsourcedRadio.AutoSize = true;
            this.modifyOutsourcedRadio.Location = new System.Drawing.Point(293, 15);
            this.modifyOutsourcedRadio.Name = "modifyOutsourcedRadio";
            this.modifyOutsourcedRadio.Size = new System.Drawing.Size(88, 19);
            this.modifyOutsourcedRadio.TabIndex = 3;
            this.modifyOutsourcedRadio.TabStop = true;
            this.modifyOutsourcedRadio.Text = "Outsourced";
            this.modifyOutsourcedRadio.UseVisualStyleBackColor = true;
            this.modifyOutsourcedRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // modifyIDLabel
            // 
            this.modifyIDLabel.AutoSize = true;
            this.modifyIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyIDLabel.Location = new System.Drawing.Point(164, 75);
            this.modifyIDLabel.Name = "modifyIDLabel";
            this.modifyIDLabel.Size = new System.Drawing.Size(19, 15);
            this.modifyIDLabel.TabIndex = 4;
            this.modifyIDLabel.Text = "ID";
            this.modifyIDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // modifyNameLabel
            // 
            this.modifyNameLabel.AutoSize = true;
            this.modifyNameLabel.Location = new System.Drawing.Point(164, 118);
            this.modifyNameLabel.Name = "modifyNameLabel";
            this.modifyNameLabel.Size = new System.Drawing.Size(41, 15);
            this.modifyNameLabel.TabIndex = 5;
            this.modifyNameLabel.Text = "Name";
            // 
            // modifyPriceLabel
            // 
            this.modifyPriceLabel.AutoSize = true;
            this.modifyPriceLabel.Location = new System.Drawing.Point(164, 218);
            this.modifyPriceLabel.Name = "modifyPriceLabel";
            this.modifyPriceLabel.Size = new System.Drawing.Size(62, 15);
            this.modifyPriceLabel.TabIndex = 6;
            this.modifyPriceLabel.Text = "Price/Cost";
            // 
            // modifyInventoryLabel
            // 
            this.modifyInventoryLabel.AutoSize = true;
            this.modifyInventoryLabel.Location = new System.Drawing.Point(164, 171);
            this.modifyInventoryLabel.Name = "modifyInventoryLabel";
            this.modifyInventoryLabel.Size = new System.Drawing.Size(55, 15);
            this.modifyInventoryLabel.TabIndex = 7;
            this.modifyInventoryLabel.Text = "Inventory";
            this.modifyInventoryLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // modifyMinLabel
            // 
            this.modifyMinLabel.AutoSize = true;
            this.modifyMinLabel.Location = new System.Drawing.Point(326, 272);
            this.modifyMinLabel.Name = "modifyMinLabel";
            this.modifyMinLabel.Size = new System.Drawing.Size(28, 15);
            this.modifyMinLabel.TabIndex = 8;
            this.modifyMinLabel.Text = "Min";
            // 
            // modifyMaxLabel
            // 
            this.modifyMaxLabel.AutoSize = true;
            this.modifyMaxLabel.Location = new System.Drawing.Point(164, 272);
            this.modifyMaxLabel.Name = "modifyMaxLabel";
            this.modifyMaxLabel.Size = new System.Drawing.Size(31, 15);
            this.modifyMaxLabel.TabIndex = 9;
            this.modifyMaxLabel.Text = "Max";
            // 
            // modifyMachineIDLabel
            // 
            this.modifyMachineIDLabel.AutoSize = true;
            this.modifyMachineIDLabel.Location = new System.Drawing.Point(164, 315);
            this.modifyMachineIDLabel.Name = "modifyMachineIDLabel";
            this.modifyMachineIDLabel.Size = new System.Drawing.Size(70, 15);
            this.modifyMachineIDLabel.TabIndex = 10;
            this.modifyMachineIDLabel.Text = "Machine ID";
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartLabel.Location = new System.Drawing.Point(15, 15);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(68, 15);
            this.modifyPartLabel.TabIndex = 11;
            this.modifyPartLabel.Text = "Modify Part";
            // 
            // modifyIDBox
            // 
            this.modifyIDBox.Enabled = false;
            this.modifyIDBox.Location = new System.Drawing.Point(281, 75);
            this.modifyIDBox.Name = "modifyIDBox";
            this.modifyIDBox.Size = new System.Drawing.Size(100, 21);
            this.modifyIDBox.TabIndex = 12;
            // 
            // modifyNameBox
            // 
            this.modifyNameBox.Location = new System.Drawing.Point(281, 118);
            this.modifyNameBox.Name = "modifyNameBox";
            this.modifyNameBox.Size = new System.Drawing.Size(100, 21);
            this.modifyNameBox.TabIndex = 13;
            // 
            // modifyInventoryBox
            // 
            this.modifyInventoryBox.Location = new System.Drawing.Point(281, 165);
            this.modifyInventoryBox.Name = "modifyInventoryBox";
            this.modifyInventoryBox.Size = new System.Drawing.Size(100, 21);
            this.modifyInventoryBox.TabIndex = 14;
            // 
            // modifyPriceBox
            // 
            this.modifyPriceBox.Location = new System.Drawing.Point(281, 218);
            this.modifyPriceBox.Name = "modifyPriceBox";
            this.modifyPriceBox.Size = new System.Drawing.Size(100, 21);
            this.modifyPriceBox.TabIndex = 15;
            // 
            // modifyMinBox
            // 
            this.modifyMinBox.Location = new System.Drawing.Point(371, 266);
            this.modifyMinBox.Name = "modifyMinBox";
            this.modifyMinBox.Size = new System.Drawing.Size(100, 21);
            this.modifyMinBox.TabIndex = 16;
            // 
            // modifyMaxBox
            // 
            this.modifyMaxBox.Location = new System.Drawing.Point(211, 266);
            this.modifyMaxBox.Name = "modifyMaxBox";
            this.modifyMaxBox.Size = new System.Drawing.Size(100, 21);
            this.modifyMaxBox.TabIndex = 17;
            // 
            // modifyMachineIDBox
            // 
            this.modifyMachineIDBox.Location = new System.Drawing.Point(281, 312);
            this.modifyMachineIDBox.Name = "modifyMachineIDBox";
            this.modifyMachineIDBox.Size = new System.Drawing.Size(100, 21);
            this.modifyMachineIDBox.TabIndex = 18;
            // 
            // ModifyPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.modifyMachineIDBox);
            this.Controls.Add(this.modifyMaxBox);
            this.Controls.Add(this.modifyMinBox);
            this.Controls.Add(this.modifyPriceBox);
            this.Controls.Add(this.modifyInventoryBox);
            this.Controls.Add(this.modifyNameBox);
            this.Controls.Add(this.modifyIDBox);
            this.Controls.Add(this.modifyPartLabel);
            this.Controls.Add(this.modifyMachineIDLabel);
            this.Controls.Add(this.modifyMaxLabel);
            this.Controls.Add(this.modifyMinLabel);
            this.Controls.Add(this.modifyInventoryLabel);
            this.Controls.Add(this.modifyPriceLabel);
            this.Controls.Add(this.modifyNameLabel);
            this.Controls.Add(this.modifyIDLabel);
            this.Controls.Add(this.modifyOutsourcedRadio);
            this.Controls.Add(this.modifyInHouseRadio);
            this.Controls.Add(this.modifyCancelButton);
            this.Controls.Add(this.modifySaveButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ModifyPartScreen";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifySaveButton;
        private System.Windows.Forms.Button modifyCancelButton;
        private System.Windows.Forms.RadioButton modifyInHouseRadio;
        private System.Windows.Forms.RadioButton modifyOutsourcedRadio;
        private System.Windows.Forms.Label modifyIDLabel;
        private System.Windows.Forms.Label modifyNameLabel;
        private System.Windows.Forms.Label modifyPriceLabel;
        private System.Windows.Forms.Label modifyInventoryLabel;
        private System.Windows.Forms.Label modifyMinLabel;
        private System.Windows.Forms.Label modifyMaxLabel;
        private System.Windows.Forms.Label modifyMachineIDLabel;
        private System.Windows.Forms.Label modifyPartLabel;
        private System.Windows.Forms.TextBox modifyIDBox;
        private System.Windows.Forms.TextBox modifyNameBox;
        private System.Windows.Forms.TextBox modifyInventoryBox;
        private System.Windows.Forms.TextBox modifyPriceBox;
        private System.Windows.Forms.TextBox modifyMinBox;
        private System.Windows.Forms.TextBox modifyMaxBox;
        private System.Windows.Forms.TextBox modifyMachineIDBox;
    }
}
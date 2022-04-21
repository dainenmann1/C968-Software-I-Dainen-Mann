
namespace C968_Software_I_Dainen_Mann
{
    partial class AddPartScreen
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
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.inHouseRadio = new System.Windows.Forms.RadioButton();
            this.AddPartOutsourced = new System.Windows.Forms.RadioButton();
            this.AddPartID = new System.Windows.Forms.Label();
            this.AddPartName = new System.Windows.Forms.Label();
            this.PartInventorylabel = new System.Windows.Forms.Label();
            this.PartPricelabel = new System.Windows.Forms.Label();
            this.PartMaxlabel = new System.Windows.Forms.Label();
            this.PartMinlabel = new System.Windows.Forms.Label();
            this.partMachineOrCompanyLabel = new System.Windows.Forms.Label();
            this.PartSavebutton = new System.Windows.Forms.Button();
            this.PartCancelbutton = new System.Windows.Forms.Button();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partInvTextBox = new System.Windows.Forms.TextBox();
            this.partPriceTextBox = new System.Windows.Forms.TextBox();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.machineOrCompTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLabel.Location = new System.Drawing.Point(12, 9);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(38, 20);
            this.AddPartLabel.TabIndex = 0;
            this.AddPartLabel.Text = "Part";
            this.AddPartLabel.Click += new System.EventHandler(this.AddPartLabel_Click);
            // 
            // inHouseRadio
            // 
            this.inHouseRadio.AutoSize = true;
            this.inHouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inHouseRadio.Location = new System.Drawing.Point(149, 9);
            this.inHouseRadio.Name = "inHouseRadio";
            this.inHouseRadio.Size = new System.Drawing.Size(75, 19);
            this.inHouseRadio.TabIndex = 1;
            this.inHouseRadio.Text = "In-House";
            this.inHouseRadio.UseVisualStyleBackColor = true;
            // 
            // AddPartOutsourced
            // 
            this.AddPartOutsourced.AutoSize = true;
            this.AddPartOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartOutsourced.Location = new System.Drawing.Point(261, 9);
            this.AddPartOutsourced.Name = "AddPartOutsourced";
            this.AddPartOutsourced.Size = new System.Drawing.Size(88, 19);
            this.AddPartOutsourced.TabIndex = 2;
            this.AddPartOutsourced.Text = "Outsourced";
            this.AddPartOutsourced.UseVisualStyleBackColor = true;
            this.AddPartOutsourced.CheckedChanged += new System.EventHandler(this.AddPartOutsourced_CheckedChanged);
            // 
            // AddPartID
            // 
            this.AddPartID.AutoSize = true;
            this.AddPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartID.Location = new System.Drawing.Point(146, 65);
            this.AddPartID.Name = "AddPartID";
            this.AddPartID.Size = new System.Drawing.Size(19, 15);
            this.AddPartID.TabIndex = 3;
            this.AddPartID.Text = "ID";
            this.AddPartID.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddPartName
            // 
            this.AddPartName.AutoSize = true;
            this.AddPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartName.Location = new System.Drawing.Point(146, 109);
            this.AddPartName.Name = "AddPartName";
            this.AddPartName.Size = new System.Drawing.Size(41, 15);
            this.AddPartName.TabIndex = 4;
            this.AddPartName.Text = "Name";
            this.AddPartName.Click += new System.EventHandler(this.label2_Click);
            // 
            // PartInventorylabel
            // 
            this.PartInventorylabel.AutoSize = true;
            this.PartInventorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartInventorylabel.Location = new System.Drawing.Point(146, 157);
            this.PartInventorylabel.Name = "PartInventorylabel";
            this.PartInventorylabel.Size = new System.Drawing.Size(55, 15);
            this.PartInventorylabel.TabIndex = 5;
            this.PartInventorylabel.Text = "Inventory";
            // 
            // PartPricelabel
            // 
            this.PartPricelabel.AutoSize = true;
            this.PartPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartPricelabel.Location = new System.Drawing.Point(146, 204);
            this.PartPricelabel.Name = "PartPricelabel";
            this.PartPricelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PartPricelabel.Size = new System.Drawing.Size(62, 15);
            this.PartPricelabel.TabIndex = 6;
            this.PartPricelabel.Text = "Price/Cost";
            // 
            // PartMaxlabel
            // 
            this.PartMaxlabel.AutoSize = true;
            this.PartMaxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartMaxlabel.Location = new System.Drawing.Point(146, 255);
            this.PartMaxlabel.Name = "PartMaxlabel";
            this.PartMaxlabel.Size = new System.Drawing.Size(31, 15);
            this.PartMaxlabel.TabIndex = 7;
            this.PartMaxlabel.Text = "Max";
            // 
            // PartMinlabel
            // 
            this.PartMinlabel.AutoSize = true;
            this.PartMinlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartMinlabel.Location = new System.Drawing.Point(321, 255);
            this.PartMinlabel.Name = "PartMinlabel";
            this.PartMinlabel.Size = new System.Drawing.Size(28, 15);
            this.PartMinlabel.TabIndex = 8;
            this.PartMinlabel.Text = "Min";
            // 
            // partMachineOrCompanyLabel
            // 
            this.partMachineOrCompanyLabel.AutoSize = true;
            this.partMachineOrCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMachineOrCompanyLabel.Location = new System.Drawing.Point(146, 307);
            this.partMachineOrCompanyLabel.Name = "partMachineOrCompanyLabel";
            this.partMachineOrCompanyLabel.Size = new System.Drawing.Size(70, 15);
            this.partMachineOrCompanyLabel.TabIndex = 9;
            this.partMachineOrCompanyLabel.Text = "Machine ID";
            this.partMachineOrCompanyLabel.Click += new System.EventHandler(this.PartMachineIDlabel_Click);
            // 
            // PartSavebutton
            // 
            this.PartSavebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSavebutton.Location = new System.Drawing.Point(283, 393);
            this.PartSavebutton.Name = "PartSavebutton";
            this.PartSavebutton.Size = new System.Drawing.Size(75, 23);
            this.PartSavebutton.TabIndex = 10;
            this.PartSavebutton.Text = "Save";
            this.PartSavebutton.UseVisualStyleBackColor = true;
            this.PartSavebutton.Click += new System.EventHandler(this.PartSavebutton_Click);
            // 
            // PartCancelbutton
            // 
            this.PartCancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartCancelbutton.Location = new System.Drawing.Point(409, 393);
            this.PartCancelbutton.Name = "PartCancelbutton";
            this.PartCancelbutton.Size = new System.Drawing.Size(75, 23);
            this.PartCancelbutton.TabIndex = 11;
            this.PartCancelbutton.Text = "Cancel";
            this.PartCancelbutton.UseVisualStyleBackColor = true;
            this.PartCancelbutton.Click += new System.EventHandler(this.PartCancelbutton_Click);
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Enabled = false;
            this.partIDTextBox.Location = new System.Drawing.Point(258, 65);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.partIDTextBox.TabIndex = 12;
            this.partIDTextBox.TextChanged += new System.EventHandler(this.partIDTextBox_TextChanged);
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Location = new System.Drawing.Point(258, 109);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.partNameTextBox.TabIndex = 13;
            // 
            // partInvTextBox
            // 
            this.partInvTextBox.Location = new System.Drawing.Point(258, 156);
            this.partInvTextBox.Name = "partInvTextBox";
            this.partInvTextBox.Size = new System.Drawing.Size(100, 20);
            this.partInvTextBox.TabIndex = 14;
            // 
            // partPriceTextBox
            // 
            this.partPriceTextBox.Location = new System.Drawing.Point(258, 203);
            this.partPriceTextBox.Name = "partPriceTextBox";
            this.partPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.partPriceTextBox.TabIndex = 15;
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Location = new System.Drawing.Point(197, 250);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.partMaxTextBox.TabIndex = 16;
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.Location = new System.Drawing.Point(368, 250);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.partMinTextBox.TabIndex = 17;
            // 
            // machineOrCompTextBox
            // 
            this.machineOrCompTextBox.Location = new System.Drawing.Point(258, 302);
            this.machineOrCompTextBox.Name = "machineOrCompTextBox";
            this.machineOrCompTextBox.Size = new System.Drawing.Size(100, 20);
            this.machineOrCompTextBox.TabIndex = 18;
            this.machineOrCompTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.machineOrCompTextBox);
            this.Controls.Add(this.partMinTextBox);
            this.Controls.Add(this.partMaxTextBox);
            this.Controls.Add(this.partPriceTextBox);
            this.Controls.Add(this.partInvTextBox);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(this.partIDTextBox);
            this.Controls.Add(this.PartCancelbutton);
            this.Controls.Add(this.PartSavebutton);
            this.Controls.Add(this.partMachineOrCompanyLabel);
            this.Controls.Add(this.PartMinlabel);
            this.Controls.Add(this.PartMaxlabel);
            this.Controls.Add(this.PartPricelabel);
            this.Controls.Add(this.PartInventorylabel);
            this.Controls.Add(this.AddPartName);
            this.Controls.Add(this.AddPartID);
            this.Controls.Add(this.AddPartOutsourced);
            this.Controls.Add(this.inHouseRadio);
            this.Controls.Add(this.AddPartLabel);
            this.Name = "AddPartScreen";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.RadioButton inHouseRadio;
        private System.Windows.Forms.RadioButton AddPartOutsourced;
        private System.Windows.Forms.Label AddPartID;
        private System.Windows.Forms.Label AddPartName;
        private System.Windows.Forms.Label PartInventorylabel;
        private System.Windows.Forms.Label PartPricelabel;
        private System.Windows.Forms.Label PartMaxlabel;
        private System.Windows.Forms.Label PartMinlabel;
        private System.Windows.Forms.Label partMachineOrCompanyLabel;
        private System.Windows.Forms.Button PartSavebutton;
        private System.Windows.Forms.Button PartCancelbutton;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partInvTextBox;
        private System.Windows.Forms.TextBox partPriceTextBox;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.TextBox machineOrCompTextBox;
    }
}
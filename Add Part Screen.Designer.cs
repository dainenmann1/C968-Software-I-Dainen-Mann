
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
            this.AddPartInhouse = new System.Windows.Forms.RadioButton();
            this.AddPartOutsourced = new System.Windows.Forms.RadioButton();
            this.AddPartID = new System.Windows.Forms.Label();
            this.AddPartName = new System.Windows.Forms.Label();
            this.PartInventorylabel = new System.Windows.Forms.Label();
            this.PartPricelabel = new System.Windows.Forms.Label();
            this.PartMaxlabel = new System.Windows.Forms.Label();
            this.PartMinlabel = new System.Windows.Forms.Label();
            this.PartMachineIDlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // AddPartInhouse
            // 
            this.AddPartInhouse.AutoSize = true;
            this.AddPartInhouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartInhouse.Location = new System.Drawing.Point(149, 9);
            this.AddPartInhouse.Name = "AddPartInhouse";
            this.AddPartInhouse.Size = new System.Drawing.Size(75, 19);
            this.AddPartInhouse.TabIndex = 1;
            this.AddPartInhouse.TabStop = true;
            this.AddPartInhouse.Text = "In-House";
            this.AddPartInhouse.UseVisualStyleBackColor = true;
            // 
            // AddPartOutsourced
            // 
            this.AddPartOutsourced.AutoSize = true;
            this.AddPartOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartOutsourced.Location = new System.Drawing.Point(261, 9);
            this.AddPartOutsourced.Name = "AddPartOutsourced";
            this.AddPartOutsourced.Size = new System.Drawing.Size(88, 19);
            this.AddPartOutsourced.TabIndex = 2;
            this.AddPartOutsourced.TabStop = true;
            this.AddPartOutsourced.Text = "Outsourced";
            this.AddPartOutsourced.UseVisualStyleBackColor = true;
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
            // PartMachineIDlabel
            // 
            this.PartMachineIDlabel.AutoSize = true;
            this.PartMachineIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartMachineIDlabel.Location = new System.Drawing.Point(146, 307);
            this.PartMachineIDlabel.Name = "PartMachineIDlabel";
            this.PartMachineIDlabel.Size = new System.Drawing.Size(70, 15);
            this.PartMachineIDlabel.TabIndex = 9;
            this.PartMachineIDlabel.Text = "Machine ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PartMachineIDlabel);
            this.Controls.Add(this.PartMinlabel);
            this.Controls.Add(this.PartMaxlabel);
            this.Controls.Add(this.PartPricelabel);
            this.Controls.Add(this.PartInventorylabel);
            this.Controls.Add(this.AddPartName);
            this.Controls.Add(this.AddPartID);
            this.Controls.Add(this.AddPartOutsourced);
            this.Controls.Add(this.AddPartInhouse);
            this.Controls.Add(this.AddPartLabel);
            this.Name = "AddPartScreen";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.RadioButton AddPartInhouse;
        private System.Windows.Forms.RadioButton AddPartOutsourced;
        private System.Windows.Forms.Label AddPartID;
        private System.Windows.Forms.Label AddPartName;
        private System.Windows.Forms.Label PartInventorylabel;
        private System.Windows.Forms.Label PartPricelabel;
        private System.Windows.Forms.Label PartMaxlabel;
        private System.Windows.Forms.Label PartMinlabel;
        private System.Windows.Forms.Label PartMachineIDlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
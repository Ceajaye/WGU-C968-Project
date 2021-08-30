
using System;

namespace InventoryProgram
{
    partial class ModifyPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInHouse = new System.Windows.Forms.RadioButton();
            this.btnOutsourced = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MachineIDtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Part";
            // 
            // btnInHouse
            // 
            this.btnInHouse.AutoSize = true;
            this.btnInHouse.Location = new System.Drawing.Point(149, 33);
            this.btnInHouse.Name = "btnInHouse";
            this.btnInHouse.Size = new System.Drawing.Size(68, 17);
            this.btnInHouse.TabIndex = 1;
            this.btnInHouse.TabStop = true;
            this.btnInHouse.Text = "In-House";
            this.btnInHouse.UseVisualStyleBackColor = true;
            this.btnInHouse.CheckedChanged += new System.EventHandler(this.btnInHouse_CheckedChanged);
            // 
            // btnOutsourced
            // 
            this.btnOutsourced.AutoSize = true;
            this.btnOutsourced.Location = new System.Drawing.Point(265, 33);
            this.btnOutsourced.Name = "btnOutsourced";
            this.btnOutsourced.Size = new System.Drawing.Size(80, 17);
            this.btnOutsourced.TabIndex = 2;
            this.btnOutsourced.TabStop = true;
            this.btnOutsourced.Text = "Outsourced";
            this.btnOutsourced.UseVisualStyleBackColor = true;
            this.btnOutsourced.CheckedChanged += new System.EventHandler(this.btnOutsourced_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(70, 102);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 5;
            this.IDlabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(53, 153);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(37, 191);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(46, 13);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "     Price";
            this.PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(57, 233);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 8;
            this.InventoryLabel.Text = "Inventory";
            this.InventoryLabel.Click += new System.EventHandler(this.InventoryLabel_Click);
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(61, 281);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 9;
            this.MinLabel.Text = "Min";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(26, 319);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(62, 13);
            this.Label.TabIndex = 10;
            this.Label.Text = "Machine ID";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(133, 99);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(100, 20);
            this.IDtextBox.TabIndex = 11;
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(133, 146);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 12;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(133, 184);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 13;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(133, 226);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.InventoryTextBox.TabIndex = 14;
            this.InventoryTextBox.TextChanged += new System.EventHandler(this.InventoryTextBox_TextChanged);
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(133, 274);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinTextBox.TabIndex = 15;
            this.MinTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(350, 274);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxTextBox.TabIndex = 16;
            this.MaxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(295, 281);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 17;
            this.MaxLabel.Text = "Max";
            // 
            // MachineIDtextBox
            // 
            this.MachineIDtextBox.Location = new System.Drawing.Point(133, 312);
            this.MachineIDtextBox.Name = "MachineIDtextBox";
            this.MachineIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.MachineIDtextBox.TabIndex = 18;
            this.MachineIDtextBox.TextChanged += new System.EventHandler(this.MachineIDtextBox_TextChanged);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 417);
            this.Controls.Add(this.MachineIDtextBox);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOutsourced);
            this.Controls.Add(this.btnInHouse);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        
        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnInHouse;
        private System.Windows.Forms.RadioButton btnOutsourced;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.TextBox MachineIDtextBox;
    }
}
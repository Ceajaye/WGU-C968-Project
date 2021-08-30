
namespace InventoryProgram
{
    partial class ModifyProduct
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.MinTextBox = new System.Windows.Forms.TextBox();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PartsLabel1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Product";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(74, 242);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(61, 276);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(48, 320);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(46, 13);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "     Price";
            this.PriceLabel.Click += new System.EventHandler(this.InventoryLabel_Click);
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(65, 363);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.InventoryLabel.TabIndex = 4;
            this.InventoryLabel.Text = "Inventory";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(65, 407);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 5;
            this.MinLabel.Text = "Min";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(145, 235);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(100, 20);
            this.IDtextBox.TabIndex = 6;
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(145, 273);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(145, 313);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 8;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(145, 356);
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.InventoryTextBox.TabIndex = 9;
            this.InventoryTextBox.TextChanged += new System.EventHandler(this.InventoryTextBox_TextChanged);
            // 
            // MinTextBox
            // 
            this.MinTextBox.Location = new System.Drawing.Point(145, 400);
            this.MinTextBox.Name = "MinTextBox";
            this.MinTextBox.Size = new System.Drawing.Size(72, 20);
            this.MinTextBox.TabIndex = 10;
            this.MinTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Location = new System.Drawing.Point(314, 400);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(72, 20);
            this.MaxTextBox.TabIndex = 11;
            this.MaxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(265, 407);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 12;
            this.MaxLabel.Text = "Max";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(464, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 257);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(464, 392);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(653, 212);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Location = new System.Drawing.Point(461, 38);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(96, 13);
            this.PartsLabel.TabIndex = 14;
            this.PartsLabel.Text = "All Candidate Parts";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(861, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(942, 30);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(175, 20);
            this.SearchTextBox.TabIndex = 16;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1016, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PartsLabel1
            // 
            this.PartsLabel1.AutoSize = true;
            this.PartsLabel1.Location = new System.Drawing.Point(461, 366);
            this.PartsLabel1.Name = "PartsLabel1";
            this.PartsLabel1.Size = new System.Drawing.Size(167, 13);
            this.PartsLabel1.TabIndex = 18;
            this.PartsLabel1.Text = "Parts Associated with this Product";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1042, 620);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1042, 649);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(961, 649);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 684);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.PartsLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MaxTextBox);
            this.Controls.Add(this.MinTextBox);
            this.Controls.Add(this.InventoryTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox InventoryTextBox;
        private System.Windows.Forms.TextBox MinTextBox;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label PartsLabel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}

namespace InventoryProgram
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
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.Grid1Search = new System.Windows.Forms.Button();
            this.Grid1TextBox = new System.Windows.Forms.TextBox();
            this.Grid2Search = new System.Windows.Forms.Button();
            this.Grid2TextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Grid1Add = new System.Windows.Forms.Button();
            this.Grid1Modify = new System.Windows.Forms.Button();
            this.Grid1Delete = new System.Windows.Forms.Button();
            this.Grid2Add = new System.Windows.Forms.Button();
            this.Grid2Modify = new System.Windows.Forms.Button();
            this.Grid2Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel.Location = new System.Drawing.Point(13, 13);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(229, 20);
            this.InventoryLabel.TabIndex = 0;
            this.InventoryLabel.Text = "Inventory Management System";
            this.InventoryLabel.Click += new System.EventHandler(this.InventoryLabel_Click);
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(23, 67);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(46, 20);
            this.PartsLabel.TabIndex = 1;
            this.PartsLabel.Text = "Parts";
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(626, 67);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(72, 20);
            this.ProductsLabel.TabIndex = 2;
            this.ProductsLabel.Text = "Products";
            // 
            // Grid1Search
            // 
            this.Grid1Search.Location = new System.Drawing.Point(356, 62);
            this.Grid1Search.Name = "Grid1Search";
            this.Grid1Search.Size = new System.Drawing.Size(75, 23);
            this.Grid1Search.TabIndex = 3;
            this.Grid1Search.Text = "Search";
            this.Grid1Search.UseVisualStyleBackColor = true;
            this.Grid1Search.Click += new System.EventHandler(this.Grid1Search_Click);
            // 
            // Grid1TextBox
            // 
            this.Grid1TextBox.Location = new System.Drawing.Point(437, 64);
            this.Grid1TextBox.Name = "Grid1TextBox";
            this.Grid1TextBox.Size = new System.Drawing.Size(170, 20);
            this.Grid1TextBox.TabIndex = 4;
            this.Grid1TextBox.TextChanged += new System.EventHandler(this.Grid1TextBox_TextChanged);
            // 
            // Grid2Search
            // 
            this.Grid2Search.Location = new System.Drawing.Point(959, 62);
            this.Grid2Search.Name = "Grid2Search";
            this.Grid2Search.Size = new System.Drawing.Size(75, 23);
            this.Grid2Search.TabIndex = 5;
            this.Grid2Search.Text = "Search";
            this.Grid2Search.UseVisualStyleBackColor = true;
            this.Grid2Search.Click += new System.EventHandler(this.Grid2Search_Click);
            // 
            // Grid2TextBox
            // 
            this.Grid2TextBox.Location = new System.Drawing.Point(1040, 64);
            this.Grid2TextBox.Name = "Grid2TextBox";
            this.Grid2TextBox.Size = new System.Drawing.Size(170, 20);
            this.Grid2TextBox.TabIndex = 6;
            this.Grid2TextBox.TextChanged += new System.EventHandler(this.Grid2TextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 277);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(630, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(580, 277);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Grid1Add
            // 
            this.Grid1Add.Location = new System.Drawing.Point(371, 373);
            this.Grid1Add.Name = "Grid1Add";
            this.Grid1Add.Size = new System.Drawing.Size(75, 23);
            this.Grid1Add.TabIndex = 8;
            this.Grid1Add.Text = "Add";
            this.Grid1Add.UseVisualStyleBackColor = true;
            this.Grid1Add.Click += new System.EventHandler(this.Grid1Add_Click);
            // 
            // Grid1Modify
            // 
            this.Grid1Modify.Location = new System.Drawing.Point(451, 373);
            this.Grid1Modify.Name = "Grid1Modify";
            this.Grid1Modify.Size = new System.Drawing.Size(75, 23);
            this.Grid1Modify.TabIndex = 9;
            this.Grid1Modify.Text = "Modify";
            this.Grid1Modify.UseVisualStyleBackColor = true;
            this.Grid1Modify.Click += new System.EventHandler(this.Grid1Modify_Click);
            // 
            // Grid1Delete
            // 
            this.Grid1Delete.Location = new System.Drawing.Point(532, 373);
            this.Grid1Delete.Name = "Grid1Delete";
            this.Grid1Delete.Size = new System.Drawing.Size(75, 23);
            this.Grid1Delete.TabIndex = 10;
            this.Grid1Delete.Text = "Delete";
            this.Grid1Delete.UseVisualStyleBackColor = true;
            this.Grid1Delete.Click += new System.EventHandler(this.Grid1Delete_Click);
            // 
            // Grid2Add
            // 
            this.Grid2Add.Location = new System.Drawing.Point(973, 373);
            this.Grid2Add.Name = "Grid2Add";
            this.Grid2Add.Size = new System.Drawing.Size(75, 23);
            this.Grid2Add.TabIndex = 11;
            this.Grid2Add.Text = "Add";
            this.Grid2Add.UseVisualStyleBackColor = true;
            this.Grid2Add.Click += new System.EventHandler(this.Grid2Add_Click);
            // 
            // Grid2Modify
            // 
            this.Grid2Modify.Location = new System.Drawing.Point(1054, 373);
            this.Grid2Modify.Name = "Grid2Modify";
            this.Grid2Modify.Size = new System.Drawing.Size(75, 23);
            this.Grid2Modify.TabIndex = 12;
            this.Grid2Modify.Text = "Modify";
            this.Grid2Modify.UseVisualStyleBackColor = true;
            this.Grid2Modify.Click += new System.EventHandler(this.Grid2Modify_Click);
            // 
            // Grid2Delete
            // 
            this.Grid2Delete.Location = new System.Drawing.Point(1135, 373);
            this.Grid2Delete.Name = "Grid2Delete";
            this.Grid2Delete.Size = new System.Drawing.Size(75, 23);
            this.Grid2Delete.TabIndex = 13;
            this.Grid2Delete.Text = "Delete";
            this.Grid2Delete.UseVisualStyleBackColor = true;
            this.Grid2Delete.Click += new System.EventHandler(this.Grid2Delete_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1135, 402);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 451);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Grid2Delete);
            this.Controls.Add(this.Grid2Modify);
            this.Controls.Add(this.Grid2Add);
            this.Controls.Add(this.Grid1Delete);
            this.Controls.Add(this.Grid1Modify);
            this.Controls.Add(this.Grid1Add);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Grid2TextBox);
            this.Controls.Add(this.Grid2Search);
            this.Controls.Add(this.Grid1TextBox);
            this.Controls.Add(this.Grid1Search);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.InventoryLabel);
            this.Name = "MainScreen";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button Grid1Search;
        private System.Windows.Forms.TextBox Grid1TextBox;
        private System.Windows.Forms.Button Grid2Search;
        private System.Windows.Forms.TextBox Grid2TextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Grid1Add;
        private System.Windows.Forms.Button Grid1Modify;
        private System.Windows.Forms.Button Grid1Delete;
        private System.Windows.Forms.Button Grid2Add;
        private System.Windows.Forms.Button Grid2Modify;
        private System.Windows.Forms.Button Grid2Delete;
        private System.Windows.Forms.Button Exit;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            Inventory.SelectedPartIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = Inventory.Parts;
            //RefreshdataGridView1();
            //RefreshdataGridView2();

            Inventory.SelectedProductIndex = -1;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.DataSource = Inventory.Products;
        }

        private void SetSelectedPartIndex()
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                Inventory.SelectedPartIndex = row.Index;
            }
            else
            {
                Inventory.SelectedPartIndex = -1;
            }
        }

        private void SetSelectedProductIndex()
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView2.SelectedRows[0];
                Inventory.SelectedProductIndex = row.Index;
            }
            else
            {
                Inventory.SelectedProductIndex = -1;
            }
        }

         ////public void RefreshdataGridView1()
        //// {
        ////    //DataTable table = new DataTable();
        ////    //table.Columns.Add("Part ID", typeof(int));
        ////    //table.Columns.Add("Name", typeof(string));
        ////    //table.Columns.Add("Price", typeof(decimal));
        ////    //table.Columns.Add("Inventory", typeof(int));
        ////    //table.Columns.Add("Min", typeof(int));
        ////    //table.Columns.Add("Max", typeof(int));

        ////    //table.Rows.Add(0, "Wheel", 12.11, 15, 5, 25);
        ////    //table.Rows.Add(1, "Pedal", 8.22, 11, 5, 25);
        ////    //table.Rows.Add(2, "Chain", 8.33, 12, 5, 25);
        ////    //table.Rows.Add(3, "Seat", 4.55, 8, 2, 15);

        ////    //dataGridView1.DataSource = table;


        //    }



        ////public void RefreshdataGridView2()
        ////{
        ////  //DataTable table = new DataTable();
        ////  // table.Columns.Add("Product ID", typeof(int));
        ////  // table.Columns.Add("Name", typeof(string));
        ////  // table.Columns.Add("Price", typeof(decimal));
        ////  // table.Columns.Add("Inventory", typeof(int));
        ////  // table.Columns.Add("Min", typeof(int));
        ////  // table.Columns.Add("Max", typeof(int));

        ////  // table.Rows.Add(0, "Red Bicycle", 11.44, 15, 1, 25);
        ////  // table.Rows.Add(1, "Yellow bicycle", 9.66, 15, 1, 20);
        ////  // table.Rows.Add(2, "Blue Bicycle", 12.77, 5, 1, 25);

        ////  // dataGridView2.DataSource = table;

        //  }



        private void MainScreen_Load(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = dataGridView1.SelectedCells;
            // Call clearSelection 
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
           
        }

        private void Grid1Search_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempPartList = new BindingList<Part>();
            bool found = false;
            if (Grid1TextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Parts.Count; i++)
                {
                    if (Inventory.Parts[i].Name.ToUpper().Contains(Grid1TextBox.Text.ToUpper()))
                    {
                        TempPartList.Add(Inventory.Parts[i]);
                        found = true;
                    }
                }
                if (found)
                    dataGridView1.DataSource = TempPartList;
            }
            if (!found)
            {
                MessageBox.Show("No Results Found.");
                dataGridView1.DataSource = Inventory.Parts;
            }

        }

       
        private void Grid1TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Grid2Search_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempPartList = new BindingList<Product>();
            bool found = false;
            if (Grid2TextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(Grid2TextBox.Text.ToUpper()))
                    {
                        TempPartList.Add(Inventory.Products[i]);
                        found = true;
                    }
                }
                if (found)
                    dataGridView2.DataSource = TempPartList;
            }
            if (!found)
            {
                MessageBox.Show("No Results Found.");
                dataGridView2.DataSource = Inventory.Products;
            }

        }
        private void Grid2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetSelectedPartIndex();
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetSelectedProductIndex();
            dataGridView2.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;

        }

        private void Grid1Add_Click(object sender, EventArgs e)
        {

            Inventory.CurrentPart = null;
            AddPart AddPartForm = new AddPart();
            AddPartForm.Show();
            this.Hide();
        }

        private void Grid1Modify_Click(object sender, EventArgs e)
        {
            SetSelectedPartIndex();
            if (Inventory.SelectedPartIndex >= 0)
            {
                Inventory.CurrentPart = Inventory.Parts[Inventory.SelectedPartIndex];
                this.Hide();
                ModifyPart ModifyPartForm = new ModifyPart();
                ModifyPartForm.Show();
            }
            else
            {
                MessageBox.Show("Please select something to modify.");
            }

        }       


        private void Grid1Delete_Click(object sender, EventArgs e)
        {
            SetSelectedPartIndex();
            if (Inventory.SelectedPartIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Inventory.Parts.RemoveAt(Inventory.SelectedPartIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }

        }

        private void Grid2Add_Click(object sender, EventArgs e)
        {

            Inventory.CurrentProduct = null;
            AddProduct AddProductForm = new AddProduct();
            AddProductForm.Show();
            this.Hide();
        }

        private void Grid2Modify_Click(object sender, EventArgs e)
        {
            SetSelectedProductIndex();
            if (Inventory.SelectedProductIndex >= 0)
            {
                Inventory.CurrentProduct = Inventory.Products[Inventory.SelectedProductIndex];
                this.Hide();
                ModifyProduct ModifyProductForm = new ModifyProduct();
                ModifyProductForm.Show();
            }
            else
            {
                MessageBox.Show("Please select something to modify.");
            }

        }
        

        private void Grid2Delete_Click(object sender, EventArgs e)
        {
            SetSelectedProductIndex();

            if (Inventory.SelectedProductIndex >= 0)
            {
                Inventory.CurrentProduct = Inventory.Products[Inventory.SelectedProductIndex];
                if (Inventory.CurrentProduct.AssociatedParts.Count == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Inventory.Products.RemoveAt(Inventory.SelectedProductIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot delete product with parts associated.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

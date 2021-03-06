using System;
using System.Windows.Forms;

namespace InventoryProgram
{

    public partial class AddPart : Form
    {
        
        private bool isInhouse;
        private Part part;

        private bool allowSave()
        {
            if (!ValidateFields.IsNotNullOrWhiteSpace(NameTextBox.Text))
            {
                return false;
            }
            if (!ValidateFields.IsDecimal(PriceTextBox.Text))
            {
                return false;
            }
            if (!ValidateFields.IsInt(InventoryTextBox.Text))
            {
                return false;
            }
            if (!ValidateFields.IsInt(MinTextBox.Text))
            {
                return false;
            }
            if (!ValidateFields.IsInt(MaxTextBox.Text))
            {
                return false;
            }
            if (!ValidateFields.InvBetweenMinMax(InventoryTextBox.Text, MinTextBox.Text, MaxTextBox.Text))
            {
                return false;
            }
            if (isInhouse)
            {
                if (!ValidateFields.IsInt(MachineIDtextBox.Text))
                {
                    return false;
                }
            }
            if (!ValidateFields.IsNotNullOrWhiteSpace(MachineIDtextBox.Text))
            {
                return false;
            }
            return true;

        }

        public AddPart()
        {
            InitializeComponent();
            part = Inventory.CurrentPart;

            if (part != null)
            {
                IDtextBox.Text = part.PartID.ToString();
                NameTextBox.Text = part.Name.ToString();
                PriceTextBox.Text = part.Price.ToString();
                InventoryTextBox.Text = part.InStock.ToString();
                MinTextBox.Text = part.Min.ToString();
                MaxTextBox.Text = part.Max.ToString();

                if (Inventory.CurrentPart is Inhouse)
                {
                    Inhouse e = (Inhouse)part;
                    MachineIDtextBox.Text = e.MachineID.ToString();
                    isInhouse = true;
                    btnInHouse.Checked = true;

                }
                else
                {
                    Outsourced e = (Outsourced)part;
                    MachineIDtextBox.Text = e.CompanyName;
                    isInhouse = false;
                    btnOutsourced.Checked = true;
                }
             }

        }

        

        private void AddPart_Load(object sender, EventArgs e)
        {
            
        }

        private void MaxTextBox_TextChanged(object sender, EventArgs e)
        {
            bool ValidMax = ValidateFields.InvBetweenMinMax(InventoryTextBox.Text, MinTextBox.Text, MaxTextBox.Text) &&
            ValidateFields.IsInt(MaxTextBox.Text);
            ValidateFields.ValidateField(MaxTextBox, ValidMax);
            ValidateFields.ValidateField(InventoryTextBox, ValidMax);

            btnSave.Enabled = allowSave();
        }

        private void btnInHouse_CheckedChanged(object sender, EventArgs e)
        {
            Label.Text = "Machine ID";
            isInhouse = true;
            bool ValidMachineID = ValidateFields.IsInt(MachineIDtextBox.Text);
            ValidateFields.ValidateField(MachineIDtextBox, ValidMachineID);
            btnSave.Enabled = allowSave();
        }

        private void btnOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            Label.Text = "Company Name";
            isInhouse = false;
            bool NotEmpty = ValidateFields.IsNotNullOrWhiteSpace(MachineIDtextBox.Text);
            ValidateFields.ValidateField(MachineIDtextBox, NotEmpty);
            btnSave.Enabled = allowSave();     
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (part == null)
            {
                CreateNewPart();
            }
            this.Close();
            this.Hide();
            MainScreen Main = new MainScreen();
            Main.Show();
        }

        void CreateNewPart()
        {
            if (isInhouse)
            {
                Inhouse inhousePart = new Inhouse(NameTextBox.Text, Convert.ToDecimal(PriceTextBox.Text),
                Convert.ToInt32(InventoryTextBox.Text), Convert.ToInt32(MinTextBox.Text),
                Convert.ToInt32(MaxTextBox.Text), Convert.ToInt32(MachineIDtextBox.Text)); 
                Inventory.AddPart(inhousePart);
            }
            else
            {
                Outsourced outsourcedPart = new Outsourced(NameTextBox.Text, Convert.ToDecimal(PriceTextBox.Text),
                Convert.ToInt32(InventoryTextBox.Text), Convert.ToInt32(MinTextBox.Text),
                Convert.ToInt32(MaxTextBox.Text), MachineIDtextBox.Text);
                Inventory.AddPart(outsourcedPart);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            MainScreen Main = new MainScreen();
            Main.Show();

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            bool ValidName = ValidateFields.IsNotNullOrWhiteSpace(NameTextBox.Text);
            ValidateFields.ValidateField(NameTextBox, ValidName);
            btnSave.Enabled = allowSave();

        }



        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            {
                bool ValidInventory = ValidateFields.IsInt(InventoryTextBox.Text) &&
                ValidateFields.InvBetweenMinMax(InventoryTextBox.Text, MinTextBox.Text, MaxTextBox.Text);
                ValidateFields.ValidateField(InventoryTextBox, ValidInventory);
                ValidateFields.ValidateField(MinTextBox, ValidInventory);
                ValidateFields.ValidateField(MaxTextBox, ValidInventory);

                btnSave.Enabled = allowSave();
            }

        }
        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            bool ValidPrice = ValidateFields.IsDecimal(PriceTextBox.Text);
            ValidateFields.ValidateField(PriceTextBox, ValidPrice);
            btnSave.Enabled = allowSave();

        }
        private void MinTextBox_TextChanged(object sender, EventArgs e)
        {
            bool ValidMin = ValidateFields.InvBetweenMinMax(InventoryTextBox.Text, MinTextBox.Text, MaxTextBox.Text) &&
            ValidateFields.IsInt(MinTextBox.Text);
            ValidateFields.ValidateField(MinTextBox, ValidMin);
            ValidateFields.ValidateField(InventoryTextBox, ValidMin);
            btnSave.Enabled = allowSave();
        }

        private void MachineIDtextBox_TextChanged(object sender, EventArgs e)
        {
            if (isInhouse)
            {
                bool MachineID = ValidateFields.IsInt(MachineIDtextBox.Text);
                ValidateFields.ValidateField(MachineIDtextBox, MachineID);
            }
            else
            {
                bool CompanyName = ValidateFields.IsNotNullOrWhiteSpace(MachineIDtextBox.Text);
                ValidateFields.ValidateField(MachineIDtextBox, CompanyName);
            }
            btnSave.Enabled = allowSave();

        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void MinLabel_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void InventoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void IDlabel_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void MaxLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace Blood_Bank_Inventory_Management_Interface
{
     public partial class InventoryManagementForm : Form
     {

          public InventoryManagementForm()
          {
               InitializeComponent();
          }

          private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
          {
               MessageBox.Show("This is a basic version of a Blood Bank Inventory Management Interface. It is a project that is created and used for learning purposes. It is created by Foster Smith.");
          }

          private void enterComponentIntoInventoryToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var nonModalForms = new entercomponentintoinventoryForm1();
               nonModalForms.Show();
          }

          private void AssignaComputerHoldMenuItem_Click(object sender, EventArgs e)
          {
               var nonModalForms = new assignholdsForm1();
               nonModalForms.Show();
          }

          private void revmoveAComputerHoldToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var nonModalForms = new removeholdsForm1();
               nonModalForms.Show();
          }

          private void discardAComponentToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var nonModalForms = new discardcomponentForm1();
               nonModalForms.Show();
          }

          private void assignAComputerHoldToolStripMenuItem2_Click(object sender, EventArgs e)
          {
               var nonModalForms = new assignholdsForm1();
               nonModalForms.Show();
          }

          private void removeAComputerHoldToolStripMenuItem2_Click(object sender, EventArgs e)
          {
               var nonModalForms = new removeholdsForm1();
               nonModalForms.Show();
          }

          private void receiveProductsToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var nonModalForms = new receiveproductsForm1();
               nonModalForms.Show();
          }

          private void rBCsToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var nonModalForms = new RBCsInventory();
               nonModalForms.Show();
          }

          private void plateletsToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var nonModalForms = new PlateletInventory();
               nonModalForms.Show();
          }

          private void frozenPlasmaToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var nonModalForms = new FrozenInventory();
               nonModalForms.Show();
          }

          private void allInventoryToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var nonModalForms = new AllInventory();
               nonModalForms.Show();
          }

          private void enterOrdersToolStripMenuItem_Click_1(object sender, EventArgs e)
          {
               var nonModalForms = new ShipProductsForm1();
               nonModalForms.Show();
          }

          private void exitToolStripMenuItem_Click(object sender, EventArgs e)
          {
               this.Close();
          }

     }
}

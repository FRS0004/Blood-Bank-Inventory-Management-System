
namespace Blood_Bank_Inventory_Management_Interface
{
     partial class InventoryManagementForm
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
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.LaboratoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.enterComponentIntoInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
               this.AssignaComputerHoldMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.revmoveAComputerHoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.discardAComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.distributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.enterOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.receiveProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
               this.assignAComputerHoldToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
               this.removeAComputerHoldToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
               this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.rBCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.plateletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.frozenPlasmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.allInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.menuStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // menuStrip1
               // 
               this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.LaboratoryMenuItem,
            this.distributionToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.aboutToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
               this.menuStrip1.Size = new System.Drawing.Size(973, 24);
               this.menuStrip1.TabIndex = 0;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // FileMenuItem
               // 
               this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
               this.FileMenuItem.Name = "FileMenuItem";
               this.FileMenuItem.Size = new System.Drawing.Size(37, 22);
               this.FileMenuItem.Text = "File";
               // 
               // exitToolStripMenuItem
               // 
               this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
               this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.exitToolStripMenuItem.Text = "Exit";
               this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
               // 
               // LaboratoryMenuItem
               // 
               this.LaboratoryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterComponentIntoInventoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.AssignaComputerHoldMenuItem,
            this.revmoveAComputerHoldToolStripMenuItem,
            this.discardAComponentToolStripMenuItem});
               this.LaboratoryMenuItem.Name = "LaboratoryMenuItem";
               this.LaboratoryMenuItem.Size = new System.Drawing.Size(88, 22);
               this.LaboratoryMenuItem.Text = "Components";
               // 
               // enterComponentIntoInventoryToolStripMenuItem
               // 
               this.enterComponentIntoInventoryToolStripMenuItem.Name = "enterComponentIntoInventoryToolStripMenuItem";
               this.enterComponentIntoInventoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
               this.enterComponentIntoInventoryToolStripMenuItem.Text = "Enter Component Into Inventory";
               this.enterComponentIntoInventoryToolStripMenuItem.Click += new System.EventHandler(this.enterComponentIntoInventoryToolStripMenuItem_Click);
               // 
               // toolStripSeparator1
               // 
               this.toolStripSeparator1.Name = "toolStripSeparator1";
               this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
               // 
               // AssignaComputerHoldMenuItem
               // 
               this.AssignaComputerHoldMenuItem.Name = "AssignaComputerHoldMenuItem";
               this.AssignaComputerHoldMenuItem.Size = new System.Drawing.Size(245, 22);
               this.AssignaComputerHoldMenuItem.Text = "Assign a Computer Hold";
               this.AssignaComputerHoldMenuItem.Click += new System.EventHandler(this.AssignaComputerHoldMenuItem_Click);
               // 
               // revmoveAComputerHoldToolStripMenuItem
               // 
               this.revmoveAComputerHoldToolStripMenuItem.Name = "revmoveAComputerHoldToolStripMenuItem";
               this.revmoveAComputerHoldToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
               this.revmoveAComputerHoldToolStripMenuItem.Text = "Remove a Computer Hold";
               this.revmoveAComputerHoldToolStripMenuItem.Click += new System.EventHandler(this.revmoveAComputerHoldToolStripMenuItem_Click);
               // 
               // discardAComponentToolStripMenuItem
               // 
               this.discardAComponentToolStripMenuItem.Name = "discardAComponentToolStripMenuItem";
               this.discardAComponentToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
               this.discardAComponentToolStripMenuItem.Text = "Discard a Component";
               this.discardAComponentToolStripMenuItem.Click += new System.EventHandler(this.discardAComponentToolStripMenuItem_Click);
               // 
               // distributionToolStripMenuItem
               // 
               this.distributionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterOrdersToolStripMenuItem,
            this.receiveProductsToolStripMenuItem,
            this.toolStripSeparator4,
            this.assignAComputerHoldToolStripMenuItem2,
            this.removeAComputerHoldToolStripMenuItem2});
               this.distributionToolStripMenuItem.Name = "distributionToolStripMenuItem";
               this.distributionToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
               this.distributionToolStripMenuItem.Text = "Distribution";
               // 
               // enterOrdersToolStripMenuItem
               // 
               this.enterOrdersToolStripMenuItem.Name = "enterOrdersToolStripMenuItem";
               this.enterOrdersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
               this.enterOrdersToolStripMenuItem.Text = "Ship Products";
               this.enterOrdersToolStripMenuItem.Click += new System.EventHandler(this.enterOrdersToolStripMenuItem_Click_1);
               // 
               // receiveProductsToolStripMenuItem
               // 
               this.receiveProductsToolStripMenuItem.Name = "receiveProductsToolStripMenuItem";
               this.receiveProductsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
               this.receiveProductsToolStripMenuItem.Text = "Receive Products";
               this.receiveProductsToolStripMenuItem.Click += new System.EventHandler(this.receiveProductsToolStripMenuItem_Click);
               // 
               // toolStripSeparator4
               // 
               this.toolStripSeparator4.Name = "toolStripSeparator4";
               this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
               // 
               // assignAComputerHoldToolStripMenuItem2
               // 
               this.assignAComputerHoldToolStripMenuItem2.Name = "assignAComputerHoldToolStripMenuItem2";
               this.assignAComputerHoldToolStripMenuItem2.Size = new System.Drawing.Size(212, 22);
               this.assignAComputerHoldToolStripMenuItem2.Text = "Assign a Computer Hold";
               this.assignAComputerHoldToolStripMenuItem2.Click += new System.EventHandler(this.assignAComputerHoldToolStripMenuItem2_Click);
               // 
               // removeAComputerHoldToolStripMenuItem2
               // 
               this.removeAComputerHoldToolStripMenuItem2.Name = "removeAComputerHoldToolStripMenuItem2";
               this.removeAComputerHoldToolStripMenuItem2.Size = new System.Drawing.Size(212, 22);
               this.removeAComputerHoldToolStripMenuItem2.Text = "Remove a Computer Hold";
               this.removeAComputerHoldToolStripMenuItem2.Click += new System.EventHandler(this.removeAComputerHoldToolStripMenuItem2_Click);
               // 
               // aboutToolStripMenuItem
               // 
               this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
               this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
               this.aboutToolStripMenuItem.Text = "About";
               this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
               // 
               // inventoryToolStripMenuItem
               // 
               this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rBCsToolStripMenuItem,
            this.plateletsToolStripMenuItem,
            this.frozenPlasmaToolStripMenuItem,
            this.allInventoryToolStripMenuItem});
               this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
               this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
               this.inventoryToolStripMenuItem.Text = "Inventory";
               // 
               // rBCsToolStripMenuItem
               // 
               this.rBCsToolStripMenuItem.Name = "rBCsToolStripMenuItem";
               this.rBCsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.rBCsToolStripMenuItem.Text = "RBCs";
               this.rBCsToolStripMenuItem.Click += new System.EventHandler(this.rBCsToolStripMenuItem_Click);
               // 
               // plateletsToolStripMenuItem
               // 
               this.plateletsToolStripMenuItem.Name = "plateletsToolStripMenuItem";
               this.plateletsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.plateletsToolStripMenuItem.Text = "Platelets";
               this.plateletsToolStripMenuItem.Click += new System.EventHandler(this.plateletsToolStripMenuItem_Click);
               // 
               // frozenPlasmaToolStripMenuItem
               // 
               this.frozenPlasmaToolStripMenuItem.Name = "frozenPlasmaToolStripMenuItem";
               this.frozenPlasmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.frozenPlasmaToolStripMenuItem.Text = "Frozen Plasma";
               this.frozenPlasmaToolStripMenuItem.Click += new System.EventHandler(this.frozenPlasmaToolStripMenuItem_Click);
               // 
               // allInventoryToolStripMenuItem
               // 
               this.allInventoryToolStripMenuItem.Name = "allInventoryToolStripMenuItem";
               this.allInventoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.allInventoryToolStripMenuItem.Text = "All Inventory";
               this.allInventoryToolStripMenuItem.Click += new System.EventHandler(this.allInventoryToolStripMenuItem_Click);
               // 
               // InventoryManagementForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(973, 546);
               this.Controls.Add(this.menuStrip1);
               this.MainMenuStrip = this.menuStrip1;
               this.Margin = new System.Windows.Forms.Padding(2);
               this.Name = "InventoryManagementForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Blood Bank Inventory Management Interface";
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
          private System.Windows.Forms.ToolStripMenuItem LaboratoryMenuItem;
          private System.Windows.Forms.ToolStripMenuItem AssignaComputerHoldMenuItem;
          private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem revmoveAComputerHoldToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem discardAComponentToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem distributionToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem enterOrdersToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem receiveProductsToolStripMenuItem;
          private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
          private System.Windows.Forms.ToolStripMenuItem assignAComputerHoldToolStripMenuItem2;
          private System.Windows.Forms.ToolStripMenuItem removeAComputerHoldToolStripMenuItem2;
          private System.Windows.Forms.ToolStripMenuItem enterComponentIntoInventoryToolStripMenuItem;
          private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
          private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem rBCsToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem plateletsToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem frozenPlasmaToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem allInventoryToolStripMenuItem;
     }
}



namespace Blood_Bank_Inventory_Management_Interface
{
     partial class AllInventory
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
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.dataGridView2 = new System.Windows.Forms.DataGridView();
               this.dataGridView3 = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
               this.label1.Location = new System.Drawing.Point(12, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(105, 17);
               this.label1.TabIndex = 0;
               this.label1.Text = "RBCs Inventory";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
               this.label2.Location = new System.Drawing.Point(12, 207);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(117, 17);
               this.label2.TabIndex = 1;
               this.label2.Text = "Platelet Inventory";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
               this.label3.Location = new System.Drawing.Point(12, 417);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(164, 17);
               this.label3.TabIndex = 2;
               this.label3.Text = "Frozen Plasma Inventory";
               // 
               // dataGridView1
               // 
               this.dataGridView1.AllowUserToAddRows = false;
               this.dataGridView1.AllowUserToDeleteRows = false;
               this.dataGridView1.AllowUserToResizeColumns = false;
               this.dataGridView1.AllowUserToResizeRows = false;
               this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
               this.dataGridView1.Location = new System.Drawing.Point(15, 39);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(896, 153);
               this.dataGridView1.TabIndex = 3;
               // 
               // dataGridView2
               // 
               this.dataGridView2.AllowUserToAddRows = false;
               this.dataGridView2.AllowUserToDeleteRows = false;
               this.dataGridView2.AllowUserToResizeColumns = false;
               this.dataGridView2.AllowUserToResizeRows = false;
               this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
               this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
               this.dataGridView2.Location = new System.Drawing.Point(15, 244);
               this.dataGridView2.Name = "dataGridView2";
               this.dataGridView2.Size = new System.Drawing.Size(896, 153);
               this.dataGridView2.TabIndex = 4;
               // 
               // dataGridView3
               // 
               this.dataGridView3.AllowUserToAddRows = false;
               this.dataGridView3.AllowUserToDeleteRows = false;
               this.dataGridView3.AllowUserToResizeColumns = false;
               this.dataGridView3.AllowUserToResizeRows = false;
               this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
               this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
               this.dataGridView3.Location = new System.Drawing.Point(15, 451);
               this.dataGridView3.Name = "dataGridView3";
               this.dataGridView3.Size = new System.Drawing.Size(896, 153);
               this.dataGridView3.TabIndex = 5;
               // 
               // AllInventory
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(923, 633);
               this.Controls.Add(this.dataGridView3);
               this.Controls.Add(this.dataGridView2);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Name = "AllInventory";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "All Inventory";
               this.Load += new System.EventHandler(this.AllInventory_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.DataGridView dataGridView2;
          private System.Windows.Forms.DataGridView dataGridView3;
     }
}
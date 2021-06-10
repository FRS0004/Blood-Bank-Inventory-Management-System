
namespace Blood_Bank_Inventory_Management_Interface
{
     partial class ShipProductsForm1
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
               this.comboBox2 = new System.Windows.Forms.ComboBox();
               this.enterintoinventorybutton1 = new System.Windows.Forms.Button();
               this.componentcodelabel1 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.DINlabel1 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.comboBox3 = new System.Windows.Forms.ComboBox();
               this.SuspendLayout();
               // 
               // comboBox2
               // 
               this.comboBox2.FormattingEnabled = true;
               this.comboBox2.Items.AddRange(new object[] {
            "E0336V00",
            "E3087V00",
            "E4545V00"});
               this.comboBox2.Location = new System.Drawing.Point(260, 199);
               this.comboBox2.Name = "comboBox2";
               this.comboBox2.Size = new System.Drawing.Size(100, 21);
               this.comboBox2.TabIndex = 27;
               // 
               // enterintoinventorybutton1
               // 
               this.enterintoinventorybutton1.Location = new System.Drawing.Point(153, 275);
               this.enterintoinventorybutton1.Name = "enterintoinventorybutton1";
               this.enterintoinventorybutton1.Size = new System.Drawing.Size(119, 23);
               this.enterintoinventorybutton1.TabIndex = 24;
               this.enterintoinventorybutton1.Text = "Ship Product";
               this.enterintoinventorybutton1.UseVisualStyleBackColor = true;
               this.enterintoinventorybutton1.Click += new System.EventHandler(this.enterintoinventorybutton1_Click);
               // 
               // componentcodelabel1
               // 
               this.componentcodelabel1.AutoSize = true;
               this.componentcodelabel1.Location = new System.Drawing.Point(84, 202);
               this.componentcodelabel1.Name = "componentcodelabel1";
               this.componentcodelabel1.Size = new System.Drawing.Size(89, 13);
               this.componentcodelabel1.TabIndex = 23;
               this.componentcodelabel1.Text = "Component Code";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(260, 136);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(100, 20);
               this.textBox1.TabIndex = 22;
               // 
               // DINlabel1
               // 
               this.DINlabel1.AutoSize = true;
               this.DINlabel1.Location = new System.Drawing.Point(84, 139);
               this.DINlabel1.Name = "DINlabel1";
               this.DINlabel1.Size = new System.Drawing.Size(26, 13);
               this.DINlabel1.TabIndex = 21;
               this.DINlabel1.Text = "DIN";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(84, 65);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(25, 13);
               this.label1.TabIndex = 28;
               this.label1.Text = "TO:";
               // 
               // comboBox3
               // 
               this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "MONT",
            "AL101"});
               this.comboBox3.FormattingEnabled = true;
               this.comboBox3.Items.AddRange(new object[] {
            "AL101",
            "AL106"});
               this.comboBox3.Location = new System.Drawing.Point(260, 62);
               this.comboBox3.Name = "comboBox3";
               this.comboBox3.Size = new System.Drawing.Size(100, 21);
               this.comboBox3.TabIndex = 30;
               // 
               // ShipProductsForm1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(465, 364);
               this.Controls.Add(this.comboBox3);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.comboBox2);
               this.Controls.Add(this.enterintoinventorybutton1);
               this.Controls.Add(this.componentcodelabel1);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.DINlabel1);
               this.Name = "ShipProductsForm1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Ship Products";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ComboBox comboBox2;
          private System.Windows.Forms.Button enterintoinventorybutton1;
          private System.Windows.Forms.Label componentcodelabel1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label DINlabel1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.ComboBox comboBox3;
     }
}

namespace Blood_Bank_Inventory_Management_Interface
{
     partial class receiveproductsForm1
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
               this.SuspendLayout();
               // 
               // comboBox2
               // 
               this.comboBox2.FormattingEnabled = true;
               this.comboBox2.Items.AddRange(new object[] {
            "E0336V00",
            "E3087V00",
            "E4545V00"});
               this.comboBox2.Location = new System.Drawing.Point(254, 132);
               this.comboBox2.Name = "comboBox2";
               this.comboBox2.Size = new System.Drawing.Size(100, 21);
               this.comboBox2.TabIndex = 20;
               // 
               // enterintoinventorybutton1
               // 
               this.enterintoinventorybutton1.Location = new System.Drawing.Point(147, 215);
               this.enterintoinventorybutton1.Name = "enterintoinventorybutton1";
               this.enterintoinventorybutton1.Size = new System.Drawing.Size(119, 23);
               this.enterintoinventorybutton1.TabIndex = 17;
               this.enterintoinventorybutton1.Text = "Enter Into Inventory";
               this.enterintoinventorybutton1.UseVisualStyleBackColor = true;
               this.enterintoinventorybutton1.Click += new System.EventHandler(this.enterintoinventorybutton1_Click);
               // 
               // componentcodelabel1
               // 
               this.componentcodelabel1.AutoSize = true;
               this.componentcodelabel1.Location = new System.Drawing.Point(78, 135);
               this.componentcodelabel1.Name = "componentcodelabel1";
               this.componentcodelabel1.Size = new System.Drawing.Size(89, 13);
               this.componentcodelabel1.TabIndex = 16;
               this.componentcodelabel1.Text = "Component Code";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(254, 60);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(100, 20);
               this.textBox1.TabIndex = 15;
               // 
               // DINlabel1
               // 
               this.DINlabel1.AutoSize = true;
               this.DINlabel1.Location = new System.Drawing.Point(78, 63);
               this.DINlabel1.Name = "DINlabel1";
               this.DINlabel1.Size = new System.Drawing.Size(26, 13);
               this.DINlabel1.TabIndex = 14;
               this.DINlabel1.Text = "DIN";
               // 
               // receiveproductsForm1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(451, 314);
               this.Controls.Add(this.comboBox2);
               this.Controls.Add(this.enterintoinventorybutton1);
               this.Controls.Add(this.componentcodelabel1);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.DINlabel1);
               this.Name = "receiveproductsForm1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Receive Product";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.ComboBox comboBox2;
          private System.Windows.Forms.Button enterintoinventorybutton1;
          private System.Windows.Forms.Label componentcodelabel1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label DINlabel1;
     }
}
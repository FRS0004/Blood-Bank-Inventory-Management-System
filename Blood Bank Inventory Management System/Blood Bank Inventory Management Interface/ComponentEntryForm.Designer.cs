
namespace Blood_Bank_Inventory_Management_Interface
{
     partial class entercomponentintoinventoryForm1
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
               this.DINlabel1 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.componentcodelabel1 = new System.Windows.Forms.Label();
               this.enterintoinventorybutton1 = new System.Windows.Forms.Button();
               this.ABOlabel = new System.Windows.Forms.Label();
               this.comboBox1 = new System.Windows.Forms.ComboBox();
               this.comboBox2 = new System.Windows.Forms.ComboBox();
               this.SuspendLayout();
               // 
               // DINlabel1
               // 
               this.DINlabel1.AutoSize = true;
               this.DINlabel1.Location = new System.Drawing.Point(42, 84);
               this.DINlabel1.Name = "DINlabel1";
               this.DINlabel1.Size = new System.Drawing.Size(26, 13);
               this.DINlabel1.TabIndex = 0;
               this.DINlabel1.Text = "DIN";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(218, 81);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(100, 20);
               this.textBox1.TabIndex = 1;
               // 
               // componentcodelabel1
               // 
               this.componentcodelabel1.AutoSize = true;
               this.componentcodelabel1.Location = new System.Drawing.Point(42, 195);
               this.componentcodelabel1.Name = "componentcodelabel1";
               this.componentcodelabel1.Size = new System.Drawing.Size(89, 13);
               this.componentcodelabel1.TabIndex = 2;
               this.componentcodelabel1.Text = "Component Code";
               // 
               // enterintoinventorybutton1
               // 
               this.enterintoinventorybutton1.Location = new System.Drawing.Point(120, 285);
               this.enterintoinventorybutton1.Name = "enterintoinventorybutton1";
               this.enterintoinventorybutton1.Size = new System.Drawing.Size(119, 23);
               this.enterintoinventorybutton1.TabIndex = 6;
               this.enterintoinventorybutton1.Text = "Enter Into Inventory";
               this.enterintoinventorybutton1.UseVisualStyleBackColor = true;
               this.enterintoinventorybutton1.Click += new System.EventHandler(this.enterintoinventorybutton1_Click);
               // 
               // ABOlabel
               // 
               this.ABOlabel.AutoSize = true;
               this.ABOlabel.Location = new System.Drawing.Point(42, 139);
               this.ABOlabel.Name = "ABOlabel";
               this.ABOlabel.Size = new System.Drawing.Size(29, 13);
               this.ABOlabel.TabIndex = 8;
               this.ABOlabel.Text = "ABO";
               // 
               // comboBox1
               // 
               this.comboBox1.FormattingEnabled = true;
               this.comboBox1.Items.AddRange(new object[] {
            "A+",
            "A=",
            "O+",
            "O=",
            "B+",
            "B=",
            "AB+",
            "AB="});
               this.comboBox1.Location = new System.Drawing.Point(218, 131);
               this.comboBox1.Name = "comboBox1";
               this.comboBox1.Size = new System.Drawing.Size(100, 21);
               this.comboBox1.TabIndex = 12;
               // 
               // comboBox2
               // 
               this.comboBox2.FormattingEnabled = true;
               this.comboBox2.Items.AddRange(new object[] {
            "E0336V00",
            "E3087V00",
            "E4545V00"});
               this.comboBox2.Location = new System.Drawing.Point(218, 192);
               this.comboBox2.Name = "comboBox2";
               this.comboBox2.Size = new System.Drawing.Size(100, 21);
               this.comboBox2.TabIndex = 13;
               // 
               // entercomponentintoinventoryForm1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(378, 384);
               this.Controls.Add(this.comboBox2);
               this.Controls.Add(this.comboBox1);
               this.Controls.Add(this.ABOlabel);
               this.Controls.Add(this.enterintoinventorybutton1);
               this.Controls.Add(this.componentcodelabel1);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.DINlabel1);
               this.Name = "entercomponentintoinventoryForm1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Enter Component into Inventory";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label DINlabel1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label componentcodelabel1;
          private System.Windows.Forms.Button enterintoinventorybutton1;
          private System.Windows.Forms.Label ABOlabel;
          private System.Windows.Forms.ComboBox comboBox1;
          private System.Windows.Forms.ComboBox comboBox2;
     }
}
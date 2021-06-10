
namespace Blood_Bank_Inventory_Management_Interface
{
     partial class removeholdsForm1
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
               this.removeholdbutton1 = new System.Windows.Forms.Button();
               this.componentcodelabel1 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.DINlabel1 = new System.Windows.Forms.Label();
               this.comboBox2 = new System.Windows.Forms.ComboBox();
               this.SuspendLayout();
               // 
               // removeholdbutton1
               // 
               this.removeholdbutton1.Location = new System.Drawing.Point(167, 169);
               this.removeholdbutton1.Name = "removeholdbutton1";
               this.removeholdbutton1.Size = new System.Drawing.Size(75, 21);
               this.removeholdbutton1.TabIndex = 13;
               this.removeholdbutton1.Text = "Remove Hold";
               this.removeholdbutton1.UseVisualStyleBackColor = true;
               this.removeholdbutton1.Click += new System.EventHandler(this.removeholdbutton1_Click);
               // 
               // componentcodelabel1
               // 
               this.componentcodelabel1.AutoSize = true;
               this.componentcodelabel1.Location = new System.Drawing.Point(83, 111);
               this.componentcodelabel1.Name = "componentcodelabel1";
               this.componentcodelabel1.Size = new System.Drawing.Size(89, 13);
               this.componentcodelabel1.TabIndex = 11;
               this.componentcodelabel1.Text = "Component Code";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(249, 60);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(100, 20);
               this.textBox1.TabIndex = 10;
               // 
               // DINlabel1
               // 
               this.DINlabel1.AutoSize = true;
               this.DINlabel1.Location = new System.Drawing.Point(83, 63);
               this.DINlabel1.Name = "DINlabel1";
               this.DINlabel1.Size = new System.Drawing.Size(26, 13);
               this.DINlabel1.TabIndex = 9;
               this.DINlabel1.Text = "DIN";
               // 
               // comboBox2
               // 
               this.comboBox2.FormattingEnabled = true;
               this.comboBox2.Items.AddRange(new object[] {
            "E0336V00",
            "E3087V00",
            "E4545V00"});
               this.comboBox2.Location = new System.Drawing.Point(249, 108);
               this.comboBox2.Name = "comboBox2";
               this.comboBox2.Size = new System.Drawing.Size(100, 21);
               this.comboBox2.TabIndex = 15;
               // 
               // removeholdsForm1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(459, 247);
               this.Controls.Add(this.comboBox2);
               this.Controls.Add(this.removeholdbutton1);
               this.Controls.Add(this.componentcodelabel1);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.DINlabel1);
               this.Name = "removeholdsForm1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Remove Holds";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button removeholdbutton1;
          private System.Windows.Forms.Label componentcodelabel1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label DINlabel1;
          private System.Windows.Forms.ComboBox comboBox2;
     }
}
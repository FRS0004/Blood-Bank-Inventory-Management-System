
namespace Blood_Bank_Inventory_Management_Interface
{
     partial class assignholdsForm1
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
               this.componentcodelabel1 = new System.Windows.Forms.Label();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.DINlabel1 = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               this.comboBox2 = new System.Windows.Forms.ComboBox();
               this.SuspendLayout();
               // 
               // componentcodelabel1
               // 
               this.componentcodelabel1.AutoSize = true;
               this.componentcodelabel1.Location = new System.Drawing.Point(70, 108);
               this.componentcodelabel1.Name = "componentcodelabel1";
               this.componentcodelabel1.Size = new System.Drawing.Size(89, 13);
               this.componentcodelabel1.TabIndex = 6;
               this.componentcodelabel1.Text = "Component Code";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(236, 57);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(100, 20);
               this.textBox1.TabIndex = 5;
               // 
               // DINlabel1
               // 
               this.DINlabel1.AutoSize = true;
               this.DINlabel1.Location = new System.Drawing.Point(70, 60);
               this.DINlabel1.Name = "DINlabel1";
               this.DINlabel1.Size = new System.Drawing.Size(26, 13);
               this.DINlabel1.TabIndex = 4;
               this.DINlabel1.Text = "DIN";
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(154, 166);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(75, 29);
               this.button1.TabIndex = 8;
               this.button1.Text = "Assign Hold";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // comboBox2
               // 
               this.comboBox2.FormattingEnabled = true;
               this.comboBox2.Items.AddRange(new object[] {
            "E0336V00",
            "E3087V00",
            "E4545V00"});
               this.comboBox2.Location = new System.Drawing.Point(236, 108);
               this.comboBox2.Name = "comboBox2";
               this.comboBox2.Size = new System.Drawing.Size(100, 21);
               this.comboBox2.TabIndex = 14;
               // 
               // assignholdsForm1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(440, 246);
               this.Controls.Add(this.comboBox2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.componentcodelabel1);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.DINlabel1);
               this.Name = "assignholdsForm1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Assign Holds";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Label componentcodelabel1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label DINlabel1;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.ComboBox comboBox2;
     }
}
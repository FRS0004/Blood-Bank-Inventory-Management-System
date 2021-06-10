using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Blood_Bank_Inventory_Management_Interface
{
     public partial class ShipProductsForm1 : Form
     {
          MySqlConnection con = new MySqlConnection(
               "server = localhost; userid = root; password =; database = inventory;");
          MySqlCommand cmd;

          string sql;
          int result;

          DateTime todaysDate = DateTime.Today;

          public ShipProductsForm1()
          {
               InitializeComponent();

          }

          private void enterintoinventorybutton1_Click(object sender, EventArgs e)
          {
               string pcode;
               pcode = comboBox2.Text;

               if (pcode == "E0336V00")
               {
                    sql = "UPDATE rbcs SET Location = '" + comboBox3.Text + "'  WHERE DIN = '" + textBox1.Text + "' AND Product_Code = '" + comboBox2.Text + "' AND Expiration_Date >= '" + todaysDate + "' AND Location = 'MONT' AND Holds = 'N' ";
                    ConnectionMethod(sql, "unable to ship product", "unit shipped");
               }
               else if (pcode == "E3087V00")
               {
                    sql = "UPDATE platelets SET Location = '" + comboBox3.Text + "' WHERE DIN = '" + textBox1.Text + "' AND Product_Code = '" + comboBox2.Text + "' AND Expiration_Date >= '" + todaysDate + "' AND Location = 'MONT' AND Holds = 'N' ";
                    ConnectionMethod(sql, "unable to ship product", "unit shipped");
               }
               else if (pcode == "E4545V00")
               {
                    sql = "UPDATE frozen_plasma SET Location = '" + comboBox3.Text + "' WHERE DIN = '" + textBox1.Text + "' AND Product_Code = '" + comboBox2.Text + "' AND Expiration_Date >= '" + todaysDate + "' AND Location = 'MONT' AND Holds = 'N' ";
                    ConnectionMethod(sql, "unable to ship product", "unit shipped");
               }
               else
               {
                    MessageBox.Show("Please enter a valid DIN, Product Code, or check the location of the Product.");
               }
          }

          private void ConnectionMethod(string sql, string msg_false, string msg_true)
          {
               try
               {
                    con.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = sql;
                    result = cmd.ExecuteNonQuery();


                    if (result > 0)
                    {
                         MessageBox.Show(msg_true);
                    }
                    else
                    {
                         MessageBox.Show(msg_false);
                    }
               }

               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
               finally
               {
                    con.Close();
               }
          }
     }
}

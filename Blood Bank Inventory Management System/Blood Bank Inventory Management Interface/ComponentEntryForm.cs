using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Blood_Bank_Inventory_Management_Interface
{
     public partial class entercomponentintoinventoryForm1 : Form
     {
          MySqlConnection con = new MySqlConnection(
               "server = localhost; userid = root; password =; database = inventory;");
          MySqlCommand cmd;
          string sql;
          int result;

          DateTime RBCExpirationDate = DateTime.Today.AddDays(45);
          DateTime TCPExpirationDate = DateTime.Today.AddDays(5);
          DateTime FrozenPlasmaExpirationDate = DateTime.Today.AddYears(1);

          public entercomponentintoinventoryForm1()
          {
               InitializeComponent();
          }

          private void enterintoinventorybutton1_Click(object sender, EventArgs e)
          {
               string pcode;
               pcode = comboBox2.Text;

               if (pcode == "E0336V00")
               {
                    sql = "Insert INTO rbcs ( DIN, ABO, Product_Code, Expiration_Date, Location, Holds ) values "
                         + "('" + textBox1.Text + "' " + ",'" + comboBox1.Text + "' " +
                         ", '" + comboBox2.Text + "' " + ", '" + RBCExpirationDate + "' , 'MONT' " + ", 'N' )";
                    ConnectionMethod(sql, "unable to add unit to inventory", "unit added to inventory");
               }
               else if (pcode == "E3087V00")
               {
                    sql = "Insert INTO platelets ( DIN, ABO, Product_Code, Expiration_Date, Location, Holds ) values "
                         + "('" + textBox1.Text + "' " + ",'" + comboBox1.Text + "' " +
                         ", '" + comboBox2.Text + "' " + ", '" + TCPExpirationDate + "' , 'MONT' " + ", 'N' )";
                    ConnectionMethod(sql, "unable to add unit to inventory", "unit added to inventory");
               }
               else if (pcode == "E4545V00")
               {
                    sql = "Insert INTO frozen_plasma ( DIN, ABO, Product_Code, Expiration_Date, Location, Holds ) values "
                         + "('" + textBox1.Text + "' " + ",'" + comboBox1.Text + "' " +
                         ", '" + comboBox2.Text + "' " + ", '" + FrozenPlasmaExpirationDate + "' , 'MONT' " + ", 'N' )";
                    ConnectionMethod(sql, "unable to add unit to inventory", "unit added to inventory");
               }
               else
               {
                    MessageBox.Show("Please enter a valid product code.");
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

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Blood_Bank_Inventory_Management_Interface
{
     public partial class assignholdsForm1 : Form
     {
          MySqlConnection con = new MySqlConnection(
               "server = localhost; userid = root; password =; database = inventory;");
          MySqlCommand cmd;
          string sql;
          int result;

          public assignholdsForm1()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               string pcode;
               pcode = comboBox2.Text;

               if (pcode == "E0336V00")
               {
                    sql = "UPDATE rbcs SET Holds = 'Y' WHERE DIN = '" + textBox1.Text + "' ";
                    ConnectionMethod(sql, "unable to apply hold", "hold applied");
               }
               else if (pcode == "E3087V00")
               {
                    sql = "UPDATE platelets SET Holds = 'Y' WHERE DIN = '" + textBox1.Text + "' ";
                    ConnectionMethod(sql, "unable to apply hold", "hold applied");
               }
               else if (pcode == "E4545V00")
               {
                    sql = "UPDATE frozen_plasma SET Holds = 'Y' WHERE DIN = '" + textBox1.Text + "' ";
                    ConnectionMethod(sql, "unable to apply hold", "hold applied");
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

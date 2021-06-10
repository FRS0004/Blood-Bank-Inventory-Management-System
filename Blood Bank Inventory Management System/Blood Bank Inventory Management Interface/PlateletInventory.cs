using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Blood_Bank_Inventory_Management_Interface
{
     public partial class PlateletInventory : Form
     {
          MySqlConnection con = new MySqlConnection(
              "server = localhost; userid = root; password =; database = inventory;");
          MySqlCommand cmd;

#pragma warning disable CS0169 // The field 'PlateletInventory.sql' is never used
          string sql;
#pragma warning restore CS0169 // The field 'PlateletInventory.sql' is never used
          int result;

          public PlateletInventory()
          {
               InitializeComponent();
          }

          private void PlateletInventory_Load(object sender, EventArgs e)
          {
               string sqlquery = "select * from platelets";

               MySqlCommand mysqlcomm = new MySqlCommand(sqlquery, con);
               con.Open();

               MySqlDataAdapter sdr = new MySqlDataAdapter(mysqlcomm);

               DataTable dt = new DataTable();
               sdr.Fill(dt);
               dataGridView1.DataSource = dt;
               con.Close();
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

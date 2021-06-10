using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Blood_Bank_Inventory_Management_Interface
{
     public partial class RBCsInventory : Form
     {
          MySqlConnection con = new MySqlConnection(
               "server = localhost; userid = root; password =; database = inventory;");

          public RBCsInventory()
          {
               InitializeComponent();
          }

          private void RBCsInventory_Load(object sender, EventArgs e)
          {
               string sqlquery = "select * from rbcs";

               MySqlCommand mysqlcomm = new MySqlCommand(sqlquery, con);
               con.Open();

               MySqlDataAdapter sdr = new MySqlDataAdapter(mysqlcomm);

               DataTable dt = new DataTable();
               sdr.Fill(dt);
               dataGridView1.DataSource = dt;
               con.Close();
          }
     }
}

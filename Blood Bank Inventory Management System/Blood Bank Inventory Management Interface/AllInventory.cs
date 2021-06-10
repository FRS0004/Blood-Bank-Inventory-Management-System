using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Blood_Bank_Inventory_Management_Interface
{
     public partial class AllInventory : Form
     {
          MySqlConnection con = new MySqlConnection(
               "server = localhost; userid = root; password =; database = inventory;");

          public AllInventory()
          {
               InitializeComponent();
          }

          private void AllInventory_Load(object sender, EventArgs e)
          {
               string sqlquery = "select * from rbcs";
               string sqlquery2 = "select * from platelets";
               string sqlquery3 = "select * from frozen_plasma";

               MySqlCommand mysqlcomm = new MySqlCommand(sqlquery, con);
               MySqlCommand mysqlcomm2 = new MySqlCommand(sqlquery2, con);
               MySqlCommand mysqlcomm3 = new MySqlCommand(sqlquery3, con);

               con.Open();

               MySqlDataAdapter sdr = new MySqlDataAdapter(mysqlcomm);
               MySqlDataAdapter sdr2 = new MySqlDataAdapter(mysqlcomm2);
               MySqlDataAdapter sdr3 = new MySqlDataAdapter(mysqlcomm3);


               DataTable dt = new DataTable();
               sdr.Fill(dt);
               dataGridView1.DataSource = dt;

               DataTable dt2 = new DataTable();
               sdr2.Fill(dt2);
               dataGridView2.DataSource = dt2;

               DataTable dt3 = new DataTable();
               sdr3.Fill(dt3);
               dataGridView3.DataSource = dt3;


               con.Close();
          }
     }
}

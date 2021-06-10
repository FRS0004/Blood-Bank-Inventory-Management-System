﻿using System;
using System.Windows.Forms;

namespace Blood_Bank_Inventory_Management_Interface
{
     static class Program
     {
          /// <summary>
          /// The main entry point for the application.
          /// </summary>
          [STAThread]
          static void Main()
          {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new InventoryManagementForm());
          }
     }
}

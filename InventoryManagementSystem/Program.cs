using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Finds the Access provider, creates InventoryDB.accdb and the tables if they don't exist yet
                Database.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new SignInForm());
        }
    }
}

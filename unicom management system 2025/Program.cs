using System.Windows.Forms;
using unicom_management_system_2025.Repositories;

namespace unicom_management_system_2025
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DatabaseManager.Initialize(); // Important!

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new View.LoginForm());
            


        }  
    }  
}
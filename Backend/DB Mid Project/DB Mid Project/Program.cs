using DB_Mid_Project.UI;

namespace DB_Mid_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summarty>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new RemoveFacultyAdminRoles());
        }
    }
}
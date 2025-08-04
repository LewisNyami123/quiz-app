using System;
using System.Windows.Forms; // Essential for Windows Forms applications

namespace quiz_app
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] // Crucial for Windows Forms applications
        static void Main()
        {
            // These lines are standard for initializing a Windows Forms application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // ApplicationConfiguration.Initialize() is for newer .NET versions, handles DPI, etc.
            // If it gives an error (e.g., in older .NET Framework), you can comment it out.
            // Otherwise, keep it.
            ApplicationConfiguration.Initialize();

            // This is the line that launches your main form.
            // IMPORTANT: Replace 'TestConnection' with the actual name of your first form.
            // For example, if your login form is named 'LoginForm', it should be 'new LoginForm()'.
            Application.Run(new frmDashboardAdmin());
        }
    }
}
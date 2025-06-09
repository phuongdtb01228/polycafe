using GUI_PolyCafe;

namespace TB01228_PolyCafe
{
    internal static class Program
    {
        /// <summary>  
        ///  The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,  
            // see https://aka.ms/applicationconfiguration.  
            ApplicationConfiguration.Initialize(); // Ensure ApplicationConfiguration is properly referenced  
            Application.Run(new FRMWelcome());
        }
    }
}
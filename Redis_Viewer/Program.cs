namespace Redis_Viewer
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
            ApplicationConfiguration.Initialize();
            try
            {





            }   catch(Exception ex)
            {

            }
            finally
            {
                Application.Run(new Form1());
            }
            Application.Exit();
        }
    }
}
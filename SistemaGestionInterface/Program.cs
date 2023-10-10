namespace SistemaGestionInterface
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
            //Application.Run(new frmUsuarios());
            //Application.Run(new frmVentas());
            //Application.Run(new frmProductos());
            Application.Run(new frmProductosVendidos());
        }
    }
}
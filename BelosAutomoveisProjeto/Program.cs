namespace BelosAutomoveisProjeto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TesteBackend.Executar();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
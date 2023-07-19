namespace TournamentTrackerApp.WinformsUI;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        IEnumerable<> configuration = Configuration();
        ApplicationConfiguration.Initialize();
        Application.Run(new Login());
    }

    private static IEnumerable<T> Configuration()
    {
        throw new NotImplementedException();
    }
}
namespace TournamentTrackerApp.WinformsUI;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using UI.DataAccess.Refit.InterFaces;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var host = CreateHostBuilder().Build();

        //ITeamData teamData = host.Services.GetService<ITeamData>();



        ApplicationConfiguration.Initialize();

        /*Form form = new Form();
        Label label = new Label();
        label.Text = teamData.GetTeams().Result.First().Name.ToString();
        form.Controls.Add(label);
        form.ShowDialog();*/

        Application.Run(new Login());




    }


    public static IServiceProvider ServiceProvider { get; private set; }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddRefitClient<ITeamData>().ConfigureHttpClient(c =>
                    {
                        c.BaseAddress = new Uri("https://localhost:7079/api");
                    }
                    );
            });
    }


}
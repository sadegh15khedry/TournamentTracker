namespace TournamentTrackerApp.WinformsUI;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using TournamentTrackerApp.WinformsUI.Forms;
using UI.DataAccess.Refit.InterFaces;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    /// 


    [STAThread]
    static void Main()
    {
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        /*        ITeamData teamData = host.Services.GetService<ITeamData>();
                ITournamentData tournamentData = host.Services.GetService<ITournamentData>();*/



        ApplicationConfiguration.Initialize();
        /*
                Form form = new Form();
                Label label = new Label();
                label.Text = teamData.GetAll().Result.First().Name.ToString();
                form.Controls.Add(label);
                form.ShowDialog();*/

        //Application.Run(new Login());
        Application.Run(ServiceProvider.GetRequiredService<Login>());



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
                services.AddRefitClient<ITournamentData>().ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri("https://localhost:7079/api");
                }
                    );
                services.AddRefitClient<IMatchData>().ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri("https://localhost:7079/api");
                }
                    );
                services.AddRefitClient<IPlayerData>().ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri("https://localhost:7079/api");
                }
                );
                services.AddRefitClient<ISeriesData>().ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri("https://localhost:7079/api");
                }
                    );

                services.AddTransient<AddPlayer>();
                services.AddTransient<AddTeam>();
                services.AddTransient<AddTournament>();
                services.AddTransient<Login>();
                services.AddTransient<Match>();
                services.AddTransient<Signup>();
                services.AddTransient<TeamPlayers>();
                services.AddTransient<TournamentChart>();
                services.AddTransient<Tournaments>();
                services.AddTransient<TournamentTeamSelection>();
                services.AddTransient<Tournaments>();
            });
    }


}
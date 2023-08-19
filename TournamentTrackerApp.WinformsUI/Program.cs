namespace TournamentTrackerApp.WinformsUI;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using System.Threading.Tasks;
using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerApp.WinformsUI.Forms;
using UI.DataAccess.Refit.InterFaces;

static class Program
{
    [STAThread]
    static async Task Main()
    {
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        /*        FormFactory._teamData = host.Services.GetService<ITeamData>();
                FormFactory._tournamentData = host.Services.GetService<ITournamentData>();
                FormFactory._seriesData = host.Services.GetService<ISeriesData>();
                FormFactory._playerData = host.Services.GetService<IPlayerData>();
                FormFactory._matchData = host.Services.GetService<IMatchData>();*/
        FormFactory._teamData = RestService.For<ITeamData>("https://localhost:7079/api");
        FormFactory._tournamentData = RestService.For<ITournamentData>("https://localhost:7079/api");
        FormFactory._seriesData = RestService.For<ISeriesData>("https://localhost:7079/api");
        FormFactory._playerData = RestService.For<IPlayerData>("https://localhost:7079/api");
        FormFactory._matchData = RestService.For<IMatchData>("https://localhost:7079/api");

        /*        var gitHubApi = RestService.For<ITournamentData>("https://localhost:7079/api");
                var ovr = await gitHubApi.GetById(1);
                MessageBox.Show(ovr.Name);*/

        ApplicationConfiguration.Initialize();
        Application.Run(FormFactory.CreateLoginForm());



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


                services.AddTransient<AddPlayerForm>();
                services.AddTransient<AddTeamForm>();
                services.AddTransient<EditTournamentForm>();
                services.AddTransient<LoginForm>();
                services.AddTransient<MatchForm>();
                services.AddTransient<SignupForm>();
                services.AddTransient<TeamPlayersForm>();
                services.AddTransient<TournamentChartForm>();
                services.AddTransient<TournamentsForm>();
                services.AddTransient<TournamentTeamSelectionForm>();
                services.AddTransient<TournamentsForm>();
            });
    }


}
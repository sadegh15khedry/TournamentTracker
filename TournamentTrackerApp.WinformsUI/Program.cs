namespace TournamentTrackerApp.WinformsUI;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using TournamentTrackerApp.WinformsUI.Factory;
using TournamentTrackerApp.WinformsUI.Forms;
using UI.DataAccess.Refit.InterFaces;

static class Program
{
    [STAThread]
    static void Main()
    {
        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        /*        ITeamData teamData = host.Services.GetService<ITeamData>();
                ITournamentData tournamentData = host.Services.GetService<ITournamentData>();*/
        FormFactory._teamData = host.Services.GetService<ITeamData>();
        FormFactory._tournamentData = host.Services.GetService<ITournamentData>();


        ApplicationConfiguration.Initialize();
        /*
                Form form = new Form();
                Label label = new Label();
                label.Text = teamData.GetAll().Result.First().Name.ToString();
                form.Controls.Add(label);
                form.ShowDialog();*/

        //Application.Run(new Login());
        Application.Run(Factory.FormFactory.CreateLogin());

        Application.Run(ServiceProvider.GetRequiredService<LoginForm>());



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
                services.AddTransient<AddTournamentForm>();
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
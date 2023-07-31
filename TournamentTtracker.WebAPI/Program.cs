global using DataAccessLibrary;
global using DataAccessLibrary.Data;
using DataAccessLibrary.Data.Classes;
using DataAccessLibrary.Data.Interfaces;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen(s =>
{
    s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1.1",
        Title = "Tournament Management App API",
        Description = "A .NET Web API For Tournament Management App."
    });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    s.IncludeXmlComments(xmlPath);
});

builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IMatchData, MatchData>();
builder.Services.AddSingleton<IPlayerData, PlayerData>();
builder.Services.AddSingleton<ITeamData, TeamData>();
builder.Services.AddSingleton<ITournamentData, TournamentData>();
builder.Services.AddSingleton<ISeriesData, SeriesData>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

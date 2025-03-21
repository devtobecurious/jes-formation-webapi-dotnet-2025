using DTBC.Ludotek.Core.Persons.Application;
using DTBC.Ludotek.Core.Persons.Application.Queries;
using DTBC.Ludotek.Core.Persons.Domains;
using DTBC.Ludotek.Core.Persons.Infrastructure.Queries;
using DTBC.Ludotek.Core.VideoGames.Application;
using DTBC.Ludotek.Core.VideoGames.Application.Queries;
using DTBC.Ludotek.Core.VideoGames.Infrastructure.InMemory;
using DTBC.Ludotek.Core.VideoGames.Models;
using Microsoft.AspNetCore.Mvc;
using DTBC.Ludotek.Core.Web.Api.Programs;


[assembly: ApiController]

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<Person>(builder.Configuration.GetSection("DefaultPerson"));

builder.Services.AddInfrastructures()
                .AddApplications();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

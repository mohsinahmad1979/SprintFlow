// SprintFlow.Api/Program.cs
using SprintFlow.Domain.Interfaces;
using SprintFlow.Application.Services;
using SprintFlow.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// 🔧 Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔧 Register InMemory Repository
builder.Services.AddSingleton<IProjectRepository, InMemoryProjectRepository>();
builder.Services.AddScoped<ProjectService>();
builder.Services.AddSingleton<IBoardRepository, InMemoryBoardRepository>();
builder.Services.AddScoped<BoardService>();

var app = builder.Build();

// 🔧 Enable Swagger middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

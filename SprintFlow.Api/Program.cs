// SprintFlow.Api/Program.cs
using SprintFlow.Application.Interfaces;
using SprintFlow.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// 🔧 Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔧 Register InMemory Repository
builder.Services.AddSingleton<IProjectRepository, InMemoryProjectRepository>();

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

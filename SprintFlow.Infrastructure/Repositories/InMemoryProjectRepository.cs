// SprintFlow.Infrastructure/Repositories/InMemoryProjectRepository.cs
using SprintFlow.Application.Interfaces;
using SprintFlow.Domain.Entities;

namespace SprintFlow.Infrastructure.Repositories;

public class InMemoryProjectRepository : IProjectRepository
{
    private readonly List<Project> _projects = new();

    public Task<IEnumerable<Project>> GetAllAsync() => Task.FromResult(_projects.AsEnumerable());

    public Task<Project?> GetByIdAsync(Guid id) =>
        Task.FromResult(_projects.FirstOrDefault(p => p.Id == id));

    public Task AddAsync(Project project)
    {
        _projects.Add(project);
        return Task.CompletedTask;
    }
}

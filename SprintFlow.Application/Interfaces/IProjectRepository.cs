// SprintFlow.Application/Interfaces/IProjectRepository.cs
using SprintFlow.Domain.Entities;

namespace SprintFlow.Application.Interfaces;

public interface IProjectRepository
{
    Task<IEnumerable<Project>> GetAllAsync();
    Task<Project?> GetByIdAsync(Guid id);
    Task AddAsync(Project project);
}

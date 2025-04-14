using SprintFlow.Domain.Entities;
using SprintFlow.Domain.Interfaces;
using System.Collections.Generic;

namespace SprintFlow.Infrastructure.Repositories
{
    public class InMemoryProjectRepository : IProjectRepository
    {
        private readonly List<Project> _projects = new();

        public void Add(Project project)
        {
            _projects.Add(project);
        }

        public IEnumerable<Project> GetAll()
        {
            return _projects;
        }
    }
}

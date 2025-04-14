using SprintFlow.Domain.Entities;
using SprintFlow.Domain.Interfaces;
using System.Collections.Generic;

namespace SprintFlow.Application.Services
{
    public class ProjectService
    {
        private readonly IProjectRepository _repository;

        public ProjectService(IProjectRepository repository)
        {
            _repository = repository;
        }

        public void CreateProject(Project project)
        {
            // Business rules can be added here
            _repository.Add(project);
        }

        public IEnumerable<Project> GetProjects()
        {
            return _repository.GetAll();
        }
    }
}

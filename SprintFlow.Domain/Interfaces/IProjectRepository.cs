using SprintFlow.Domain.Entities;
using System.Collections.Generic;

namespace SprintFlow.Domain.Interfaces
{
    public interface IProjectRepository
    {
        void Add(Project project);
        IEnumerable<Project> GetAll();
    }
}

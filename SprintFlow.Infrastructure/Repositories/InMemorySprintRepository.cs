using SprintFlow.Domain.Entities;
using SprintFlow.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SprintFlow.Infrastructure.Repositories
{
    public class InMemorySprintRepository : ISprintRepository
    {
        private readonly List<Sprint> _sprints = new();

        public void Add(Sprint sprint)
        {
            _sprints.Add(sprint);
        }

        public IEnumerable<Sprint> GetAll()
        {
            return _sprints;
        }

        public IEnumerable<Sprint> GetByBoardId(Guid boardId)
        {
            return _sprints.Where(s => s.BoardId == boardId);
        }
    }
}

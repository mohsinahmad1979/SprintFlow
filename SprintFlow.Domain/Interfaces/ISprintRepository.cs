using SprintFlow.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SprintFlow.Domain.Interfaces
{
    public interface ISprintRepository
    {
        void Add(Sprint sprint);
        IEnumerable<Sprint> GetAll();
        IEnumerable<Sprint> GetByBoardId(Guid boardId);
    }
}

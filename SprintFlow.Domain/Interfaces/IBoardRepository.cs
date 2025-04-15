using SprintFlow.Domain.Entities;
using System.Collections.Generic;

namespace SprintFlow.Domain.Interfaces
{
    public interface IBoardRepository
    {
        void Add(Board board);
        IEnumerable<Board> GetAll();
        IEnumerable<Board> GetByProjectId(Guid projectId);
    }
}

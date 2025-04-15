using SprintFlow.Domain.Entities;
using SprintFlow.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SprintFlow.Infrastructure.Repositories
{
    public class InMemoryBoardRepository : IBoardRepository
    {
        private readonly List<Board> _boards = new();

        public void Add(Board board)
        {
            _boards.Add(board);
        }

        public IEnumerable<Board> GetAll()
        {
            return _boards;
        }

        public IEnumerable<Board> GetByProjectId(Guid projectId)
        {
            return _boards.Where(b => b.ProjectId == projectId);
        }
    }
}

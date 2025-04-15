using SprintFlow.Domain.Entities;
using SprintFlow.Domain.Interfaces;
using System.Collections.Generic;

namespace SprintFlow.Application.Services
{
    public class BoardService
    {
        private readonly IBoardRepository _boardRepository;

        public BoardService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public void CreateBoard(Board board)
        {
            _boardRepository.Add(board);
        }

        public IEnumerable<Board> GetBoards()
        {
            return _boardRepository.GetAll();
        }

        public IEnumerable<Board> GetBoardsByProject(Guid projectId)
        {
            return _boardRepository.GetByProjectId(projectId);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SprintFlow.Application.Services;
using SprintFlow.Domain.Entities;

namespace SprintFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoardController : ControllerBase
    {
        private readonly BoardService _boardService;

        public BoardController(BoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpPost]
        public IActionResult CreateBoard([FromBody] Board board)
        {
            _boardService.CreateBoard(board);
            return CreatedAtAction(nameof(GetBoards), new { id = board.Id }, board);
        }

        [HttpGet]
        public IActionResult GetBoards()
        {
            var boards = _boardService.GetBoards();
            return Ok(boards);
        }

        [HttpGet("by-project/{projectId}")]
        public IActionResult GetBoardsByProject(Guid projectId)
        {
            var boards = _boardService.GetBoardsByProject(projectId);
            return Ok(boards);
        }
    }
}

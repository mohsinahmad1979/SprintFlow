using Microsoft.AspNetCore.Mvc;
using SprintFlow.Application.Services;
using SprintFlow.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SprintFlow.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SprintController : ControllerBase
    {
        private readonly SprintService _sprintService;

        public SprintController(SprintService sprintService)
        {
            _sprintService = sprintService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Sprint sprint)
        {
            _sprintService.CreateSprint(sprint);
            return Ok(sprint);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sprint>> GetAll()
        {
            return Ok(_sprintService.GetAll());
        }

        [HttpGet("board/{boardId}")]
        public ActionResult<IEnumerable<Sprint>> GetByBoardId(Guid boardId)
        {
            return Ok(_sprintService.GetByBoardId(boardId));
        }
    }
}

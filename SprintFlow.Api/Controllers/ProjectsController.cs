using Microsoft.AspNetCore.Mvc;
using SprintFlow.Domain.Entities;
using SprintFlow.Application.Services;

namespace SprintFlow.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly ProjectService _projectService;

        public ProjectController(ProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            _projectService.CreateProject(project);
            return Ok(project);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var projects = _projectService.GetProjects();
            return Ok(projects);
        }
    }
}

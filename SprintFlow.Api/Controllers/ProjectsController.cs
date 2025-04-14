// SprintFlow.Api/Controllers/ProjectsController.cs
using Microsoft.AspNetCore.Mvc;
using SprintFlow.Application.Interfaces;
using SprintFlow.Domain.Entities;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectRepository _repo;

    public ProjectsController(IProjectRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _repo.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Project project)
    {
        await _repo.AddAsync(project);
        return CreatedAtAction(nameof(Get), new { id = project.Id }, project);
    }
}

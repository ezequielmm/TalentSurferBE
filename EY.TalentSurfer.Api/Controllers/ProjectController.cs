using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _service;

        public ProjectController(IProjectService service)
        {
            _service = service;
        }

        // GET: api/Project
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectReadDto>>> GetProjects()
        {
            var Projects = await _service.GetAllAsync();
            return Ok(Projects);
        }

        // GET: api/Project/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectReadDto>> GetProject([FromRoute] int id)
        {
            var project = await _service.GetAsync(id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        // PUT: api/Project/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutProject(int id, ProjectUpdateDto project)
        {
            if (!await _service.ExistsAsync(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, project);

            return Ok(updated);
        }

        // POST: api/Project
        [HttpPost]
        public async Task<ActionResult<ProjectReadDto>> PostProject([FromBody] ProjectCreateDto project)
        {
            var created = await _service.CreateAsync(project);

            return CreatedAtAction("GetProject", new { id = created.Id }, created);
        }

        // DELETE: api/Project/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProject([FromRoute] int id)
        {
            if (! await _service.ExistsAsync(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> ProjectExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}
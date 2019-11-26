using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Support;
using System;
using EY.TalentSurfer.Support.Api.Contracts;
using EY.TalentSurfer.Api.Base;

namespace EY.TalentSurfer.Api.Controllers
{
    public class ProjectController : TalentSurferBaseController
    {
        private readonly IProjectService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public ProjectController(IProjectService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
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

        // GET: api/Project/Page
        [HttpGet("Page", Name = "GetProjectPage")]
        public async Task<ActionResult<IEnumerable<ProjectReadDto>>> GetProjectPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var ProjectPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetProjectPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(ProjectPage);
        }
    }
}
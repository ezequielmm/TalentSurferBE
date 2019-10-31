using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Api.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public StatusController(IStatusService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
        }

        // GET: api/Status
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusReadDto>>> GetStatus()
        {
            var certainties = await _service.GetAllAsync();
            return Ok(certainties);
        }

        // GET: api/Status/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StatusReadDto>> GetStatus(int id)
        {
            var status = await _service.GetAsync(id);

            if (status == null)
            {
                return NotFound();
            }

            return Ok(status);
        }

        // PUT: api/Status/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutStatus(int id, StatusUpdateDto status)
        {
            if (!await StatusExists(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, status);

            return Ok(updated);
        }

        // POST: api/Status
        [HttpPost]
        public async Task<ActionResult<StatusReadDto>> PostStatus(StatusCreateDto status)
        {
            var created = await _service.CreateAsync(status);

            return CreatedAtAction("GetStatus", new { id = created.Id }, status);
        }

        // DELETE: api/Status/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStatus(int id)
        {
            if (!await StatusExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> StatusExists(int id)
        {
            return await _service.ExistsAsync(id);
        }

        // GET: api/Status/Page
        [HttpGet("Page", Name = "GetStatusPage")]
        public async Task<ActionResult<IEnumerable<CertaintyReadDto>>> GetStatusPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var statusPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetStatusPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(statusPage);
        }
    }
}
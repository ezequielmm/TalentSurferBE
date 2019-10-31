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
    public class SeniorityController : ControllerBase
    {
        private readonly ISeniorityService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public SeniorityController(ISeniorityService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
        }

        // GET: api/Seniority
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SeniorityReadDto>>> GetSeniority()
        {
            var certainties = await _service.GetAllAsync();
            return Ok(certainties);
        }

        // GET: api/Seniority/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SeniorityReadDto>> GetSeniority(int id)
        {
            var seniority = await _service.GetAsync(id);

            if (seniority == null)
            {
                return NotFound();
            }

            return Ok(seniority);
        }

        // PUT: api/Seniority/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutSeniority(int id, SeniorityUpdateDto seniority)
        {
            if (!await SeniorityExists(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, seniority);

            return Ok(updated);
        }

        // POST: api/Seniority
        [HttpPost]
        public async Task<ActionResult<SeniorityReadDto>> PostSeniority(SeniorityCreateDto seniority)
        {
            var created = await _service.CreateAsync(seniority);

            return CreatedAtAction("GetSeniority", new { id = created.Id }, seniority);
        }

        // DELETE: api/Seniority/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSeniority(int id)
        {
            if (!await SeniorityExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> SeniorityExists(int id)
        {
            return await _service.ExistsAsync(id);
        }

        // GET: api/Seniority/Page
        [HttpGet("Page", Name = "GetSeniorityPage")]
        public async Task<ActionResult<IEnumerable<CertaintyReadDto>>> GetSeniorityPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var seriotiesPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetSeniorityPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(seriotiesPage);
        }
    }
}
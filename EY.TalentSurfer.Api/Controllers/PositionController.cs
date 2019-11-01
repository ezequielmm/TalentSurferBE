using EY.TalentSurfer.Api.Base;
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
    public class PositionController : TalentSurferBaseController
    {
        private readonly IPositionService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public PositionController(IPositionService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
        }

        // GET: api/Position
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PositionReadDto>>> GetPositions()
        {
            var certainties = await _service.GetAllAsync();
            return Ok(certainties);
        }

        // GET: api/Position/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PositionReadDto>> GetPosition(int id)
        {
            var position = await _service.GetAsync(id);

            if (position == null)
            {
                return NotFound();
            }

            return Ok(position);
        }

        // PUT: api/Position/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPosition(int id, PositionUpdateDto position)
        {
            if (!await PositionExists(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, position);

            return Ok(updated);
        }

        // POST: api/Position
        [HttpPost]
        public async Task<ActionResult<PositionReadDto>> PostPosition(PositionCreateDto position)
        {
            var created = await _service.CreateAsync(position);

            return CreatedAtAction("GetPosition", new { id = created.Id }, position);
        }

        // DELETE: api/Position/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePosition(int id)
        {
            if (!await PositionExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> PositionExists(int id)
        {
            return await _service.ExistsAsync(id);
        }

        // GET: api/Position/Page
        [HttpGet("Page", Name = "GetPositionPage")]
        public async Task<ActionResult<IEnumerable<CertaintyReadDto>>> GetPositionPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var positionsPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetPositionPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(positionsPage);
        }
    }
}
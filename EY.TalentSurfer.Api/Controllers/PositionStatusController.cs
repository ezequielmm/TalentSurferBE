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
    public class PositionStatusController : TalentSurferBaseController
    {
        private readonly IPositionStatusService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public PositionStatusController(IPositionStatusService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
        }

        // GET: api/PositionStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PositionStatusReadDto>>> GetPositionStatus()
        {
            var certainties = await _service.GetAllAsync();
            return Ok(certainties);
        }

        // GET: api/PositionStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PositionStatusReadDto>> GetPositionStatus(int id)
        {
            var positionStatus = await _service.GetAsync(id);

            if (positionStatus == null)
            {
                return NotFound();
            }

            return Ok(positionStatus);
        }

        // PUT: api/PositionStatus/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPositionStatus(int id, PositionStatusUpdateDto positionStatus)
        {
            if (!await PositionStatusExists(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, positionStatus);

            return Ok(updated);
        }

        // POST: api/PositionStatus
        [HttpPost]
        public async Task<ActionResult<PositionStatusReadDto>> PostPositionStatus(PositionStatusCreateDto positionStatus)
        {
            var created = await _service.CreateAsync(positionStatus);

            return CreatedAtAction("GetPositionStatus", new { id = created.Id }, positionStatus);
        }

        // DELETE: api/PositionStatus/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePositionStatus(int id)
        {
            if (!await PositionStatusExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> PositionStatusExists(int id)
        {
            return await _service.ExistsAsync(id);
        }

        // GET: api/PositionStatus/Page
        [HttpGet("Page", Name = "GetPositionStatusPage")]
        public async Task<ActionResult<IEnumerable<CertaintyReadDto>>> GetPositionStatusPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var positionStatusPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetPositionStatusPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(positionStatusPage);
        }
    }
}
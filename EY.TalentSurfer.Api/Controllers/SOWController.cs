using EY.TalentSurfer.Dto.SOW;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Api.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EY.TalentSurfer.Api.Base;

namespace EY.TalentSurfer.Api.Controllers
{
    public class SowController : TalentSurferBaseController
    {
        private readonly ISowService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public SowController(ISowService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
        }

        // GET: api/SOW
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SowReadDto>>> GetSOW()
        {
            var sow = await _service.GetAllAsync();
            return Ok(sow);
        }

        // GET: api/SOW/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SowReadDto>> GetSOW(int id)
        {
            var status = await _service.GetAsync(id);

            if (status == null)
            {
                return NotFound();
            }

            return Ok(status);
        }

        // PUT: api/SOW/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutSOW(int id, SowUpdateDto sow)
        {
            if (!await SOWExists(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, sow);

            return Ok(updated);
        }

        // POST: api/SOW
        [HttpPost]
        public async Task<ActionResult<SowReadDto>> PostSOW(SowCreateDto sow)
        {
            var created = await _service.CreateAsync(sow);

            return CreatedAtAction("GetSOW", new { id = created.Id }, sow);
        }

        // DELETE: api/SOW/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSOW(int id)
        {
            if (!await SOWExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> SOWExists(int id)
        {
            return await _service.ExistsAsync(id);
        }

        // GET: api/Sow/Page
        [HttpGet("Page", Name = "GetSowPage")]
        public async Task<ActionResult<IEnumerable<SowReadDto>>> GetSowPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var SowsPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetSowPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(SowsPage);
        }
    }
}
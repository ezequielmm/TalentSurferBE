using EY.TalentSurfer.Api.Base;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Api.Contracts;
using EY.TalentSurfer.Support;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace EY.TalentSurfer.Api.Controllers
{
    public class CertaintyController : TalentSurferBaseController
    {
        private readonly ICertaintyService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public CertaintyController(ICertaintyService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
        }

        // GET: api/Certainty
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CertaintyReadDto>>> GetCertainty()
        {
            var certainties = await _service.GetAllAsync();
            return Ok(certainties);
        }

        // GET: api/Certainty/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CertaintyReadDto>> GetCertainty(int id)
        {
            var certainty = await _service.GetAsync(id);

            if (certainty == null)
            {
                return NotFound();
            }

            return Ok(certainty);
        }

        // PUT: api/Certainty/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutCertainty(int id, CertaintyUpdateDto certainty)
        {
            if (!await CertaintyExists(id)) return NotFound();

            if (await _service.CheckIfValueExists(id, p => p.Description == certainty.Description))
            {
                ModelState.AddModelError("Duplication", "Certainty description already exists");
                return Conflict();
            }

            if (await _service.CheckIfValueExists(id, p => p.Value == certainty.Value))
            {
                ModelState.AddModelError("Duplication", "Certainty value already exists");
                return Conflict();
            }

            var updated = await _service.UpdateAsync(id, certainty);

            return Ok(updated);
        }

        // POST: api/Certainty
        [HttpPost]
        public async Task<ActionResult<CertaintyReadDto>> PostCertainty(CertaintyCreateDto certainty)
        {
            if (await _service.CheckIfValueExists(null, p => p.Description == certainty.Description))
            {
                ModelState.AddModelError("Duplication", "Certainty description already exists");
                return Conflict(ModelState);
            }

            if (await _service.CheckIfValueExists(null, p => p.Value == certainty.Value))
            {
                ModelState.AddModelError("Duplication", "Certainty value already exists");
                return Conflict(ModelState);
            }

            var created = await _service.CreateAsync(certainty);


            return CreatedAtAction("GetCertainty", new { id = created.Id }, certainty);
        }

        // DELETE: api/Certainty/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCertainty(int id)
        {
            if (!await CertaintyExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> CertaintyExists(int id)
        {
            return await _service.ExistsAsync(id);
        }

        // GET: api/Certainty/Page
        [HttpGet("Page", Name = "GetCertaintyPage")]
        public async Task<ActionResult<IEnumerable<CertaintyReadDto>>> GetCertaintyPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var certaintiesPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetCertaintyPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(certaintiesPage);
        }
    }
}
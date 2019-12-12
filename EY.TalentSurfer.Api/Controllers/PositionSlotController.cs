using EY.TalentSurfer.Api.Base;
using EY.TalentSurfer.Dto.PositionSlot;
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
    public class PositionSlotController : TalentSurferBaseController
    {
        private readonly IPositionSlotService _service;
        private readonly IPageLinkBuilder _linkBuilder;
        public PositionSlotController(IPositionSlotService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
        }
        
        // POST: api/PositionSlot
        [HttpPost]
        public async Task<ActionResult<PositionSlotReadDto>> PostPositionSlot(PositionSlotCreateDto positionSlot)
        {
            var created = await _service.CreateAsync(positionSlot);
            return CreatedAtAction("GetPositionSlot", new { id = created.Id }, created);
        }
        
        // GET: api/PositionSlot
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PositionSlotReadDto>>> GetPositionsSlot()
        {
            var positionSlot = await _service.GetAllAsync();
            return Ok(positionSlot);
        }

        // GET: api/PositionSlot/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PositionSlotReadDto>> GetPositionSlot([FromRoute] int id)
        {
            var positionSlot = await _service.GetAsync(id);

            if (positionSlot == null)
            {
                return NotFound();
            }

            return Ok(positionSlot);
        }
        
        // PUT: api/PositionSlot/5
        [HttpPut("{id}")]  
        public async Task<ActionResult> PutPositionSlot(int id,[FromBody] PositionSlotUpdateDto positionSlot)
        {
            if (!await PositionSlotExists(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, positionSlot);

            return Ok(updated);
        }
        private async Task<bool> PositionSlotExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
        [HttpGet("Page", Name = "GetPositionSlotPage")]
        public async Task<ActionResult<IEnumerable<PositionSlotReadDto>>> GetPositionSlotPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var positionSlotsPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetPositionSlotPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(positionSlotsPage);
        }
    }
}
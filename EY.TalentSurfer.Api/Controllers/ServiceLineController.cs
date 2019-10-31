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
    public class ServiceLineController : ControllerBase
    {
        private readonly IServiceLineService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public ServiceLineController(IServiceLineService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
        }

        // GET: api/ServiceLine
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceLineReadDto>>> GetServiceLines()
        {
            var ServiceLines = await _service.GetAllAsync();
            return Ok(ServiceLines);
        }

        // GET: api/ServiceLine/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceLineReadDto>> GetServiceLine(int id)
        {
            var ServiceLine = await _service.GetAsync(id);

            if (ServiceLine == null)
            {
                return NotFound();
            }

            return Ok(ServiceLine);
        }

        // PUT: api/ServiceLine/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutServiceLine(int id, ServiceLineUpdateDto ServiceLine)
        {
            if (!await ServiceLineExists(id)) return NotFound();

            await _service.UpdateAsync(id, ServiceLine);

            return NoContent();
        }

        // POST: api/ServiceLine
        [HttpPost]
        public async Task<ActionResult<ServiceLineReadDto>> PostServiceLine(ServiceLineCreateDto ServiceLine)
        {
            var created = await _service.CreateAsync(ServiceLine);

            return CreatedAtAction("GetServiceLine", new { id = created.Id }, ServiceLine);
        }

        // DELETE: api/ServiceLine/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteServiceLine(int id)
        {           
            if (!await ServiceLineExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> ServiceLineExists(int id)
        {
            return await _service.ExistsAsync(id);
        }

        // GET: api/ServiceLine/Page
        [HttpGet("Page", Name = "GetServiceLinePage")]
        public async Task<ActionResult<IEnumerable<CertaintyReadDto>>> GetServiceLinePage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var serviceLinesPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetServiceLinePage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(serviceLinesPage);
        }
    }
}
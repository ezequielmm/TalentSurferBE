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
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public LocationController(ILocationService service, IPageLinkBuilder linkBuilder)
        {
            _service = service;
            _linkBuilder = linkBuilder;
        }

        // GET: api/Location
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationReadDto>>> GetLocations()
        {
            var locations = await _service.GetAllAsync();
            return Ok(locations);
        }

        // GET: api/Location/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationReadDto>> GetLocation([FromRoute] int id)
        {
            var location = await _service.GetAsync(id);

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }

        // PUT: api/Location/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutLocation(int id, LocationUpdateDto location)
        {
            if (!await _service.ExistsAsync(id)) return NotFound();

            var updated = await _service.UpdateAsync(id, location);

            return Ok(updated);
        }

        // POST: api/Location
        [HttpPost]
        public async Task<ActionResult<LocationReadDto>> PostLocation([FromBody] LocationCreateDto location)
        {
            var created = await _service.CreateAsync(location);

            return CreatedAtAction("GetLocation", new { id = created.Id }, created);
        }

        // DELETE: api/Location/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteLocation([FromRoute] int id)
        {
            if (!await _service.ExistsAsync(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> LocationExists(int id)
        {
            return await _service.ExistsAsync(id);
        }

        // GET: api/Location/Page
        [HttpGet("Page", Name = "GetLocationPage")]
        public async Task<ActionResult<IEnumerable<LocationReadDto>>> GetLocationPage(int pageNum = 1, int pageSize = 10, string orderColumn = "Id", bool ascendent = true)
        {
            var existingPages = (int)Math.Ceiling((double)await _service.CountAsync() / pageSize);
            if (pageNum > existingPages) return BadRequest(string.Format(Messages.PagesOutOfRange, existingPages, pageSize));

            var locationPage = await _service.GetPage(pageNum, pageSize, orderColumn, ascendent);

            foreach (var link in _linkBuilder.Build(Url, nameof(GetLocationPage), pageNum, pageSize, existingPages))
            {
                Response.Headers.Add(link.Key, link.Value);
            }

            return Ok(locationPage);
        }
    }
}
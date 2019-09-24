using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Dto;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _service;

        public LocationController(ILocationService service)
        {
            _service = service;
        }

        // GET: api/Location
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationReadDto>>> GetLocations()
        {
            var locations = await _service.GetAllAsync<LocationReadDto>();
            return Ok(locations);
        }

        // GET: api/Location/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationReadDto>> GetLocation([FromRoute] int id)
        {
            var location = await _service.GetAsync<LocationReadDto>(id);

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

            await _service.UpdateAsync(id, location);

            return NoContent();
        }

        // POST: api/Location
        [HttpPost]
        public async Task<ActionResult<LocationReadDto>> PostLocation([FromBody] LocationCreateDto location)
        {
            var created = await _service.CreateAsync<LocationReadDto>(location);

            return CreatedAtAction("GetLocation", new { id = created.Id }, created);
        }

        // DELETE: api/Location/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteLocation([FromRoute] int id)
        {
            if (! await _service.ExistsAsync(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> LocationExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}
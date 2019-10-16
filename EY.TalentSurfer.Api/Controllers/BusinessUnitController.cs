using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessUnitController : ControllerBase
    {
        // TODO change repo to service
        private readonly IBusinessUnitService _service;

        public BusinessUnitController(IBusinessUnitService service)
        {
            _service = service;
        }

        // GET: api/BusinessUnit
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusinessUnitReadDto>>> GetBusinessUnits()
        {
            var businessUnits = await _service.GetAllAsync<BusinessUnitReadDto>();
            return Ok(businessUnits);
        }

        // GET: api/BusinessUnit/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BusinessUnitReadDto>> GetBusinessUnit(int id)
        {
            var businessUnit = await _service.GetAsync<BusinessUnitReadDto>(id);

            if (businessUnit == null)
            {
                return NotFound();
            }

            return Ok(businessUnit);
        }

        // PUT: api/BusinessUnit/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutBusinessUnit(int id, BusinessUnitUpdateDto businessUnit)
        {
            if (!await BusinessUnitExists(id)) return NotFound();

            await _service.UpdateAsync(id, businessUnit);

            return NoContent();
        }

        // POST: api/BusinessUnit
        [HttpPost]
        public async Task<ActionResult<BusinessUnitReadDto>> PostBusinessUnit(BusinessUnitCreateDto businessUnit)
        {
            var created = await _service.CreateAsync<BusinessUnitReadDto>(businessUnit);

            return CreatedAtAction("GetBusinessUnit", new { id = created.Id }, businessUnit);
        }

        // DELETE: api/BusinessUnit/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBusinessUnit(int id)
        {           
            if (!await BusinessUnitExists(id)) return NotFound();

            await _service.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> BusinessUnitExists(int id)
        {
            return await _service.ExistsAsync(id);
        }
    }
}
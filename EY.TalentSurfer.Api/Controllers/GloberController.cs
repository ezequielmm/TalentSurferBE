using System.Collections.Generic;
using System.Threading.Tasks;
using EY.TalentSurfer.Api.Base;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EY.TalentSurfer.Api.Controllers
{
    public class GloberController : TalentSurferBaseController
    {
        private readonly IGloberService _service;
        public GloberController(IGloberService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GloberReadDto>>> GetGloberDetails(string key,int offset,int limit)
        {
            var globantDetails = await _service.GetGloberDetails(key,offset,limit);
            return Ok(globantDetails);
        }
    }
}
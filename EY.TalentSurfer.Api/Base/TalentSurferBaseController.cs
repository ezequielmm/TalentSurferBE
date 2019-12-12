using EY.TalentSurfer.Support.Api.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace EY.TalentSurfer.Api.Base
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Authorize(Roles = "User,Admin")]
    public class TalentSurferBaseController : ControllerBase
    {

    }
}

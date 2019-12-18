using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using System.Collections.Generic;
using AutoMapper;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using EY.TalentSurfer.Support.Helper;

namespace EY.TalentSurfer.Services
{
    public class GloberService : IGloberService
    {
        protected readonly IMapper _mapper;
        private readonly IConfiguration _Configuration;
        public GloberService(IMapper mapper, IConfiguration Configuration)
        {
            _mapper = mapper;
            _Configuration = Configuration;
        }
        public async Task<GloberReadDto> GetGloberDetails(string key, int offset, int limit)
        {
            string baseurl = _Configuration.GetValue<string>("GlowIntegration:baseUrl");
            string searchGlobers = _Configuration.GetValue<string>("GlowIntegration:searchGlobers");
            string url = baseurl + searchGlobers + "?key=" + key + "&offset=" + offset + "&limit=" + limit;
            return await WebApiHelper.Get<GloberReadDto>(url, null);
        }
    }
}

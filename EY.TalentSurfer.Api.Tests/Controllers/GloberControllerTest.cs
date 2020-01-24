using EY.TalentSurfer.Api.Controllers;
using EY.TalentSurfer.Services.Contracts;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Api.Tests.Controllers
{
   public class GloberControllerTest
    {
        private readonly IGloberService _service;

        public GloberControllerTest()
        {
            _service = Mock.Of<IGloberService>();

            Target = new GloberController(_service);
        }
        private GloberController Target { get; }

        public class Method_GetGlobers : GloberControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge
                var key = "";
                var limit = 0;
                var offset = 0;

                // Act
                var result = await Target.GetGloberDetails(key,limit,offset);

                // Assert
                Mock.Get(_service).Verify(s => s.GetGloberDetails(key, limit, offset), Times.Once);
            }
        }
    }
}

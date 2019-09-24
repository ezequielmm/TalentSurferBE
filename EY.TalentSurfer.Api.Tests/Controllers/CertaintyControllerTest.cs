using EY.TalentSurfer.Api.Controllers;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Api.Tests.Controllers
{
    public class CertaintyControllerTest
    {
        private readonly ICertaintyService _service;

        public CertaintyControllerTest()
        {
            _service = Mock.Of<ICertaintyService>();

            Target = new CertaintyController(_service);
        }

        private CertaintyController Target { get; }

        public class Method_GetCertaintys : CertaintyControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetCertainty();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync<CertaintyReadDto>(), Times.Once);
            }
        }

        public class Method_GetCertainty : CertaintyControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetCertainty(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync<CertaintyReadDto>(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync<CertaintyReadDto>(id)).ReturnsAsync((CertaintyReadDto)null);

                // Act
                var result = await Target.GetCertainty(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync<CertaintyReadDto>(id)).ReturnsAsync(new CertaintyReadDto());

                // Act
                var result = await Target.GetCertainty(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutCertainty : CertaintyControllerTest
        {
            public Method_PutCertainty()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new CertaintyUpdateDto();

                // Act
                var result = await Target.PutCertainty(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new CertaintyUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutCertainty(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                var updateDto = new CertaintyUpdateDto();

                // Act
                var result = await Target.PutCertainty(id, updateDto);

                // Assert
                Assert.IsType<NoContentResult>(result);
            }
        }

        public class Method_PostCertainty : CertaintyControllerTest
        {
            public Method_PostCertainty()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync<CertaintyReadDto>(It.IsAny<CertaintyCreateDto>())).ReturnsAsync(new CertaintyReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new CertaintyCreateDto();

                // Act
                var result = await Target.PostCertainty(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync<CertaintyReadDto>(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new CertaintyCreateDto();

                // Act
                var result = await Target.PostCertainty(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }

        public class Method_DeleteCertainty : CertaintyControllerTest
        {
            public Method_DeleteCertainty()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteCertainty(id);

                // Assert
                Mock.Get(_service).Verify(s => s.DeleteAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_NotContent()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteCertainty(id);

                // Assert
                Assert.IsType<NoContentResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.DeleteCertainty(id);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}

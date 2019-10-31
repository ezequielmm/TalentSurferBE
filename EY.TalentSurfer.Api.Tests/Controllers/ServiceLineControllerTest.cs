using EY.TalentSurfer.Api.Controllers;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Api.Contracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Api.Tests.Controllers
{
    public class ServiceLineControllerTest
    {
        private readonly IServiceLineService _service;
        private readonly IPageLinkBuilder _linkbuilder;

        public ServiceLineControllerTest()
        {
            _service = Mock.Of<IServiceLineService>();
            _linkbuilder = Mock.Of<IPageLinkBuilder>();

            Target = new ServiceLineController(_service, _linkbuilder);
        }

        private ServiceLineController Target { get; }

        public class Method_GetServiceLines : ServiceLineControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetServiceLines();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync(), Times.Once);
            }
        }

        public class Method_GetServiceLine : ServiceLineControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetServiceLine(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync((ServiceLineReadDto)null);

                // Act
                var result = await Target.GetServiceLine(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync(new ServiceLineReadDto());

                // Act
                var result = await Target.GetServiceLine(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutServiceLine : ServiceLineControllerTest
        {
            public Method_PutServiceLine()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new ServiceLineUpdateDto();

                // Act
                var result = await Target.PutServiceLine(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new ServiceLineUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutServiceLine(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);
                var updateDto = new ServiceLineUpdateDto();

                // Act
                var result = await Target.PutServiceLine(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }

        public class Method_PostServiceLine : ServiceLineControllerTest
        {
            public Method_PostServiceLine()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync(It.IsAny<ServiceLineCreateDto>())).ReturnsAsync(new ServiceLineReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new ServiceLineCreateDto();

                // Act
                var result = await Target.PostServiceLine(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new ServiceLineCreateDto();

                // Act
                var result = await Target.PostServiceLine(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }

        public class Method_DeleteServiceLine : ServiceLineControllerTest
        {
            public Method_DeleteServiceLine()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteServiceLine(id);

                // Assert
                Mock.Get(_service).Verify(s => s.DeleteAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_NotContent()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteServiceLine(id);

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
                var result = await Target.DeleteServiceLine(id);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}

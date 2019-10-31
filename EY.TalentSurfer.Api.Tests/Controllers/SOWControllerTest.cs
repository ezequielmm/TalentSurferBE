using EY.TalentSurfer.Api.Controllers;
using EY.TalentSurfer.Dto.SOW;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Api.Contracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Api.Tests.Controllers
{
    public class SowControllerTest
    {
        private readonly ISowService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public SowControllerTest()
        {
            _service = Mock.Of<ISowService>();
            _linkBuilder = Mock.Of<IPageLinkBuilder>();

            Target = new SowController(_service, _linkBuilder);
        }

        private SowController Target { get; }

        public class Method_GetSOWs : SowControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetSOW();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync(), Times.Once);
            }
        }

        public class Method_GetSOW : SowControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetSOW(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync((SowReadDto)null);

                // Act
                var result = await Target.GetSOW(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync(new SowReadDto());

                // Act
                var result = await Target.GetSOW(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutSOW : SowControllerTest
        {
            public Method_PutSOW()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new SowUpdateDto();

                // Act
                var result = await Target.PutSOW(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new SowUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutSOW(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                var updateDto = new SowUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutSOW(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }

        public class Method_PostSOW : SowControllerTest
        {
            public Method_PostSOW()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync(It.IsAny<SowCreateDto>())).ReturnsAsync(new SowReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new SowCreateDto();

                // Act
                var result = await Target.PostSOW(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new SowCreateDto();

                // Act
                var result = await Target.PostSOW(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }

        public class Method_DeleteSOW : SowControllerTest
        {
            public Method_DeleteSOW()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteSOW(id);

                // Assert
                Mock.Get(_service).Verify(s => s.DeleteAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_NotContent()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteSOW(id);

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
                var result = await Target.DeleteSOW(id);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}

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
    public class PositionStatusControllerTest
    {
        private readonly IPositionStatusService _service;
        private readonly IPageLinkBuilder _linkbuilder;

        public PositionStatusControllerTest()
        {
            _service = Mock.Of<IPositionStatusService>();
            _linkbuilder = Mock.Of<IPageLinkBuilder>();

            Target = new PositionStatusController(_service, _linkbuilder);
        }

        private PositionStatusController Target { get; }

        public class Method_GetPositionStatuss : PositionStatusControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetPositionStatus();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync(), Times.Once);
            }
        }

        public class Method_GetPositionStatus : PositionStatusControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetPositionStatus(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync((PositionStatusReadDto)null);

                // Act
                var result = await Target.GetPositionStatus(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync(new PositionStatusReadDto());

                // Act
                var result = await Target.GetPositionStatus(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutPositionStatus : PositionStatusControllerTest
        {
            public Method_PutPositionStatus()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new PositionStatusUpdateDto();

                // Act
                var result = await Target.PutPositionStatus(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new PositionStatusUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutPositionStatus(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                var updateDto = new PositionStatusUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutPositionStatus(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }

        public class Method_PostPositionStatus : PositionStatusControllerTest
        {
            public Method_PostPositionStatus()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync(It.IsAny<PositionStatusCreateDto>())).ReturnsAsync(new PositionStatusReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new PositionStatusCreateDto();

                // Act
                var result = await Target.PostPositionStatus(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new PositionStatusCreateDto();

                // Act
                var result = await Target.PostPositionStatus(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }

        public class Method_DeletePositionStatus : PositionStatusControllerTest
        {
            public Method_DeletePositionStatus()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeletePositionStatus(id);

                // Assert
                Mock.Get(_service).Verify(s => s.DeleteAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_NotContent()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeletePositionStatus(id);

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
                var result = await Target.DeletePositionStatus(id);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}

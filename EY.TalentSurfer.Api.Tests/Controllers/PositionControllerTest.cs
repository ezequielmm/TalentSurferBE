using EY.TalentSurfer.Api.Controllers;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Api.Tests.Controllers
{
    public class PositionControllerTest
    {
        private readonly IPositionService _service;

        public PositionControllerTest()
        {
            _service = Mock.Of<IPositionService>();

            Target = new PositionController(_service);
        }

        private PositionController Target { get; }

        public class Method_GetPositions : PositionControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetPositions();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync<PositionReadDto>(), Times.Once);
            }
        }

        public class Method_GetPosition : PositionControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetPosition(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync<PositionReadDto>(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync<PositionReadDto>(id)).ReturnsAsync((PositionReadDto)null);

                // Act
                var result = await Target.GetPosition(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync<PositionReadDto>(id)).ReturnsAsync(new PositionReadDto());

                // Act
                var result = await Target.GetPosition(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutPosition : PositionControllerTest
        {
            public Method_PutPosition()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new PositionUpdateDto();

                // Act
                var result = await Target.PutPosition(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new PositionUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutPosition(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                var updateDto = new PositionUpdateDto();

                // Act
                var result = await Target.PutPosition(id, updateDto);

                // Assert
                Assert.IsType<NoContentResult>(result);
            }
        }

        public class Method_PostPosition : PositionControllerTest
        {
            public Method_PostPosition()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync<PositionReadDto>(It.IsAny<PositionCreateDto>())).ReturnsAsync(new PositionReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new PositionCreateDto();

                // Act
                var result = await Target.PostPosition(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync<PositionReadDto>(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new PositionCreateDto();

                // Act
                var result = await Target.PostPosition(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }

        public class Method_DeletePosition : PositionControllerTest
        {
            public Method_DeletePosition()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeletePosition(id);

                // Assert
                Mock.Get(_service).Verify(s => s.DeleteAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_NotContent()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeletePosition(id);

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
                var result = await Target.DeletePosition(id);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}

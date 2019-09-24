using EY.TalentSurfer.Api.Controllers;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Api.Tests.Controllers
{
    public class LocationControllerTest
    {
        private readonly ILocationService _service;

        public LocationControllerTest()
        {
            _service = Mock.Of<ILocationService>();

            Target = new LocationController(_service);
        }

        private LocationController Target { get; }

        public class Method_GetLocations : LocationControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetLocations();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync<LocationReadDto>(), Times.Once);
            }
        }

        public class Method_GetLocation : LocationControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetLocation(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync<LocationReadDto>(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync<LocationReadDto>(id)).ReturnsAsync((LocationReadDto)null);

                // Act
                var result = await Target.GetLocation(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync<LocationReadDto>(id)).ReturnsAsync(new LocationReadDto());

                // Act
                var result = await Target.GetLocation(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutLocation : LocationControllerTest
        {
            public Method_PutLocation()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new LocationUpdateDto();

                // Act
                var result = await Target.PutLocation(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new LocationUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutLocation(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                var updateDto = new LocationUpdateDto();

                // Act
                var result = await Target.PutLocation(id, updateDto);

                // Assert
                Assert.IsType<NoContentResult>(result);
            }
        }

        public class Method_PostLocation : LocationControllerTest
        {
            public Method_PostLocation()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync<LocationReadDto>(It.IsAny<LocationCreateDto>())).ReturnsAsync(new LocationReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new LocationCreateDto();

                // Act
                var result = await Target.PostLocation(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync<LocationReadDto>(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new LocationCreateDto();

                // Act
                var result = await Target.PostLocation(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }

        public class Method_DeleteLocation : LocationControllerTest
        {
            public Method_DeleteLocation()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteLocation(id);

                // Assert
                Mock.Get(_service).Verify(s => s.DeleteAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_NotContent()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteLocation(id);

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
                var result = await Target.DeleteLocation(id);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}

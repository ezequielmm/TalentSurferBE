using EY.TalentSurfer.Api.Controllers;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Api.Tests.Controllers
{
    public class BusinessUnitControllerTest
    {
        private readonly IBusinessUnitService _service;

        public BusinessUnitControllerTest()
        {
            _service = Mock.Of<IBusinessUnitService>();

            Target = new BusinessUnitController(_service);
        }

        private BusinessUnitController Target { get; }

        public class Method_GetBusinessUnits : BusinessUnitControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetBusinessUnits();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync<BusinessUnitReadDto>(), Times.Once);
            }
        }

        public class Method_GetBusinessUnit : BusinessUnitControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetBusinessUnit(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync<BusinessUnitReadDto>(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync<BusinessUnitReadDto>(id)).ReturnsAsync((BusinessUnitReadDto)null);

                // Act
                var result = await Target.GetBusinessUnit(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync<BusinessUnitReadDto>(id)).ReturnsAsync(new BusinessUnitReadDto());

                // Act
                var result = await Target.GetBusinessUnit(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutBusinessUnit : BusinessUnitControllerTest
        {
            public Method_PutBusinessUnit()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new BusinessUnitUpdateDto();

                // Act
                var result = await Target.PutBusinessUnit(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new BusinessUnitUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutBusinessUnit(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                var updateDto = new BusinessUnitUpdateDto();

                // Act
                var result = await Target.PutBusinessUnit(id, updateDto);

                // Assert
                Assert.IsType<NoContentResult>(result);
            }
        }

        public class Method_PostBusinessUnit : BusinessUnitControllerTest
        {
            public Method_PostBusinessUnit()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync<BusinessUnitReadDto>(It.IsAny<BusinessUnitCreateDto>())).ReturnsAsync(new BusinessUnitReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new BusinessUnitCreateDto();

                // Act
                var result = await Target.PostBusinessUnit(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync<BusinessUnitReadDto>(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new BusinessUnitCreateDto();

                // Act
                var result = await Target.PostBusinessUnit(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }

        public class Method_DeleteBusinessUnit : BusinessUnitControllerTest
        {
            public Method_DeleteBusinessUnit()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteBusinessUnit(id);

                // Assert
                Mock.Get(_service).Verify(s => s.DeleteAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_NotContent()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteBusinessUnit(id);

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
                var result = await Target.DeleteBusinessUnit(id);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}

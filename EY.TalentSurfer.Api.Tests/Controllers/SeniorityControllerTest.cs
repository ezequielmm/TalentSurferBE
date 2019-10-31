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
    public class SeniorityControllerTest
    {
        private readonly ISeniorityService _service;
        private readonly IPageLinkBuilder _linkbuilder;

        public SeniorityControllerTest()
        {
            _service = Mock.Of<ISeniorityService>();
            _linkbuilder = Mock.Of<IPageLinkBuilder>();

            Target = new SeniorityController(_service, _linkbuilder);
        }

        private SeniorityController Target { get; }

        public class Method_GetSenioritys : SeniorityControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetSeniority();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync(), Times.Once);
            }
        }

        public class Method_GetSeniority : SeniorityControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetSeniority(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync((SeniorityReadDto)null);

                // Act
                var result = await Target.GetSeniority(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync(new SeniorityReadDto());

                // Act
                var result = await Target.GetSeniority(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutSeniority : SeniorityControllerTest
        {
            public Method_PutSeniority()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new SeniorityUpdateDto();

                // Act
                var result = await Target.PutSeniority(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new SeniorityUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutSeniority(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                var updateDto = new SeniorityUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutSeniority(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }

        public class Method_PostSeniority : SeniorityControllerTest
        {
            public Method_PostSeniority()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync(It.IsAny<SeniorityCreateDto>())).ReturnsAsync(new SeniorityReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new SeniorityCreateDto();

                // Act
                var result = await Target.PostSeniority(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new SeniorityCreateDto();

                // Act
                var result = await Target.PostSeniority(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }

        public class Method_DeleteSeniority : SeniorityControllerTest
        {
            public Method_DeleteSeniority()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteSeniority(id);

                // Assert
                Mock.Get(_service).Verify(s => s.DeleteAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_NotContent()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteSeniority(id);

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
                var result = await Target.DeleteSeniority(id);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}

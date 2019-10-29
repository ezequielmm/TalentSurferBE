using EY.TalentSurfer.Api.Controllers;
using EY.TalentSurfer.Dto;
using EY.TalentSurfer.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Api.Tests.Controllers
{
    public class ProjectControllerTest
    {
        private readonly IProjectService _service;

        public ProjectControllerTest()
        {
            _service = Mock.Of<IProjectService>();

            Target = new ProjectController(_service);
        }

        private ProjectController Target { get; }

        public class Method_GetProjects : ProjectControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetProjects();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync(), Times.Once);
            }
        }

        public class Method_GetProject : ProjectControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetProject(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync((ProjectReadDto)null);

                // Act
                var result = await Target.GetProject(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync(new ProjectReadDto());

                // Act
                var result = await Target.GetProject(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutProject : ProjectControllerTest
        {
            public Method_PutProject()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new ProjectUpdateDto();

                // Act
                var result = await Target.PutProject(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new ProjectUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutProject(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                var updateDto = new ProjectUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutProject(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }

        public class Method_PostProject : ProjectControllerTest
        {
            public Method_PostProject()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync(It.IsAny<ProjectCreateDto>())).ReturnsAsync(new ProjectReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new ProjectCreateDto();

                // Act
                var result = await Target.PostProject(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new ProjectCreateDto();

                // Act
                var result = await Target.PostProject(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }

        public class Method_DeleteProject : ProjectControllerTest
        {
            public Method_DeleteProject()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteProject(id);

                // Assert
                Mock.Get(_service).Verify(s => s.DeleteAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_NotContent()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.DeleteProject(id);

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
                var result = await Target.DeleteProject(id);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }
    }
}

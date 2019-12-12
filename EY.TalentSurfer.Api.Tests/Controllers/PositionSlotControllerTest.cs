using EY.TalentSurfer.Api.Controllers;
using EY.TalentSurfer.Dto.PositionSlot;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support.Api.Contracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Api.Tests.Controllers
{
    public class PositionSlotControllerTest
    {
        private readonly IPositionSlotService _service;
        private readonly IPageLinkBuilder _linkBuilder;

        public PositionSlotControllerTest()
        {
            _service = Mock.Of<IPositionSlotService>();
            _linkBuilder = Mock.Of<IPageLinkBuilder>();

            Target = new PositionSlotController(_service, _linkBuilder);
        }
        private PositionSlotController Target { get; }
        public class Method_GetPositionsSlot : PositionSlotControllerTest
        {
            [Fact]
            public async Task Calls_GetAllAsync_from_service()
            {
                // Arrenge

                // Act
                var result = await Target.GetPositionsSlot();

                // Assert
                Mock.Get(_service).Verify(s => s.GetAllAsync(), Times.Once);
            }
        }

        public class Method_GetPositionSlot : PositionSlotControllerTest
        {
            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;

                // Act
                var result = await Target.GetPositionSlot(id);

                // Assert
                Mock.Get(_service).Verify(s => s.GetAsync(id), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync((PositionSlotReadDto)null);

                // Act
                var result = await Target.GetPositionSlot(id);

                // Assert
                Assert.IsType<NotFoundResult>(result.Result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                Mock.Get(_service).Setup(s => s.GetAsync(id)).ReturnsAsync(new PositionSlotReadDto());

                // Act
                var result = await Target.GetPositionSlot(id);

                // Assert
                Assert.IsType<OkObjectResult>(result.Result);
            }
        }

        public class Method_PutPositionSlot : PositionSlotControllerTest
        {
            public Method_PutPositionSlot()
            {
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(true);
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var id = 1;
                var updateDto = new PositionSlotUpdateDto();

                // Act
                var result = await Target.PutPositionSlot(id, updateDto);

                // Assert
                Mock.Get(_service).Verify(s => s.UpdateAsync(id, updateDto), Times.Once);
            }

            [Fact]
            public async Task If_found_returns_OkObjectResult()
            {
                // Arrenge
                var id = 1;
                var updateDto = new PositionSlotUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutPositionSlot(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var id = 1;
                var updateDto = new PositionSlotUpdateDto();
                Mock.Get(_service).Setup(s => s.ExistsAsync(It.IsAny<int>())).ReturnsAsync(false);

                // Act
                var result = await Target.PutPositionSlot(id, updateDto);

                // Assert
                Assert.IsType<NotFoundResult>(result);
            }
        }

        public class Method_PostPositionSlot : PositionSlotControllerTest
        {
            public Method_PostPositionSlot()
            {
                Mock.Get(_service).Setup(s => s.CreateAsync(It.IsAny<PositionSlotCreateDto>())).ReturnsAsync(new PositionSlotReadDto());
            }

            [Fact]
            public async Task Calls_GetAsync_from_service()
            {
                // Arrenge
                var createDto = new PositionSlotCreateDto();

                // Act
                var result = await Target.PostPositionSlot(createDto);

                // Assert
                Mock.Get(_service).Verify(s => s.CreateAsync(createDto), Times.Once);
            }

            [Fact]
            public async Task If_not_found_returns_NotFound()
            {
                // Arrenge
                var createDto = new PositionSlotCreateDto();

                // Act
                var result = await Target.PostPositionSlot(createDto);

                // Assert
                Assert.IsType<CreatedAtActionResult>(result.Result);
            }
        }
    }
}

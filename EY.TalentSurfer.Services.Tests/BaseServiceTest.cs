using AutoMapper;
using EY.TalentSurfer.Support.Persistence;
using EY.TalentSurfer.Support.Services.Contracts;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Services.Tests
{
    internal class BaseServiceProxy : BaseService<Entity, ICreateDto, IReadDto, IUpdateDto>
    {
        internal BaseServiceProxy(IRepository<Entity> repository, IMapper mapper) : base(repository, mapper)
        {

        }

        internal IMapper Mapper => this._mapper;
    }

    public class BaseServiceTest
    {
        private readonly IRepository<Entity> _repository;
        private readonly IMapper _mapper;
        public BaseServiceTest()
        {
            _repository = Mock.Of<IRepository<Entity>>();
            _mapper = Mock.Of<IMapper>();
            Target = new BaseServiceProxy(_repository, _mapper);
        }
        private BaseService<Entity, ICreateDto, IReadDto, IUpdateDto> Target { get; }

        public class Method_GetAsync : BaseServiceTest
        {
            [Fact]
            public async Task Calls_FindAsync_From_repository()
            {
                // Arrenge
                var id = default(int);

                // Act
                var result = await Target.GetAsync(id);

                // Assert
                Mock.Get(_repository).Verify(r => r.FindAsync(id), Times.Once);
            }

            [Fact]
            public async Task Calls_Map_From_Maper_For_E_to_RD()
            {
                //Arrange
                Entity entity = Mock.Of<Entity>();
                Mock.Get(_repository)
                    .Setup(rb => rb.FindAsync(It.IsAny<int>()))
                    .Returns(Task.FromResult(entity));

                //Act
                var response = await Target.GetAsync(It.IsAny<int>());

                //Assert
                Mock.Get(_mapper).Verify(m => m.Map<IReadDto>(entity), Times.Once);

            }
        }
        public class Method_GetAllAsync : BaseServiceTest
        {
            [Fact]
            public async Task Should_call_FindAllAsync_from_repository()
            {
                // Arrenge

                // Act
                var response = await Target.GetAllAsync();

                // Assert
                Mock.Get(_repository).Verify(r => r.ToListAsync(), Times.Once);
            }

            [Fact]
            public async Task Should_call_Map_from_IMapper()
            {
                // Arrenge
                IEnumerable<Entity> list = new List<Entity> { };
                Mock.Get(_repository).Setup(r => r.ToListAsync()).Returns(Task.FromResult(list));

                // Act
                var response = await Target.GetAllAsync();

                // Assert
                Mock.Get(_mapper).Verify(m => m.Map<IEnumerable<IReadDto>>(list), Times.Once);
            }
        }
        public class Method_UpdateAsync : BaseServiceTest
        {
            public IUpdateDto Item { get; set; }
            public int Id { get; set; }
            public Method_UpdateAsync()
            {
                Item = Mock.Of<IUpdateDto>();
                Id = default(int);
            }

            [Fact]
            public async Task Calls_FindAsync_From_repository()
            {
                //Arrange

                //Act
                await Target.UpdateAsync(Id, Item);

                //Assert
                Mock.Get(_repository).Verify(rb => rb.FindAsync(Id), Times.Once);
            }

            [Fact]
            public async Task Calls_Map_From_Maper_For_E_to_UD()
            {
                //Arrange
                var entity = Mock.Of<Entity>();
                Mock.Get(_repository).Setup(rb => rb.FindAsync(Id)).Returns(Task.FromResult(entity));

                //Act
                await Target.UpdateAsync(Id, Item);

                //Assert
                Mock.Get(_mapper).Verify(m => m.Map(Item, entity), Times.Once);
            }

            [Fact]
            public async Task Calls_UpdateAsync_From_repository()
            {
                //Arrange
                var entity = Mock.Of<Entity>();
                Mock.Get(_repository).Setup(rb => rb.FindAsync(Id)).Returns(Task.FromResult(entity));

                //Act
                await Target.UpdateAsync(Id, Item);

                //Assert
                Mock.Get(_repository).Verify(ub => ub.UpdateAsync(entity), Times.Once);
            }
        }

        public class Method_CreateAsync : BaseServiceTest
        {
            [Fact]
            public async Task Calls_InsertAsync_From_repository()
            {
                //Arrange
                var item = Mock.Of<ICreateDto>();

                //Act
                var response = await Target.CreateAsync(item);

                //Assert
                Mock.Get(_repository).Verify(cb => cb.InsertAsync(It.IsAny<Entity>()), Times.Once);
            }

            [Fact]
            public async Task Calls_Map_From_Maper_For_CD_to_E()
            {
                //Arrange
                var item = Mock.Of<ICreateDto>();

                //Act
                var response = await Target.CreateAsync(item);

                //Assert
                Mock.Get(_mapper).Verify(m => m.Map<Entity>(item), Times.Once);
            }

            [Fact]
            public async Task Calls_Map_From_Maper_For_E_to_RD()
            {
                //Arrange
                var item = Mock.Of<ICreateDto>();

                //Act
                var response = await Target.CreateAsync(item);

                //Assert
                Mock.Get(_mapper).Verify(m => m.Map<IReadDto>(It.IsAny<Entity>()), Times.Once);
            }

            [Fact]
            public async Task Response_Is_Same_As_Mapper_Response()
            {
                //Arrange
                var item = Mock.Of<ICreateDto>();
                var readDto = Mock.Of<IReadDto>();
                Mock.Get(this._mapper).Setup(m => m.Map<IReadDto>(It.IsAny<Entity>())).Returns(readDto);

                //Act
                var response = await Target.CreateAsync(item);

                //Assert
                Assert.Same(readDto, response);
            }
        }

        public class Methos_DeleteAsync : BaseServiceTest
        {
            [Fact]
            public async Task Calls_FindAsync_From_repository()
            {
                //Arrange

                //Act
                await Target.DeleteAsync(It.IsAny<int>());

                //Assert
                Mock.Get(_repository).Verify(cb => cb.FindAsync(It.IsAny<int>()), Times.Once);
            }

            [Fact]
            public async Task Calls_DeleteAsync_With_Same_Id()
            {
                //Arrange
                var id = default(int);

                //Act
                await Target.DeleteAsync(id);

                //Assert
                Mock.Get(_repository).Verify(cb => cb.DeleteAsync(It.IsAny<Entity>()), Times.Once);
            }
        }
        public class Method_ExistsAsync : BaseServiceTest
        {
            [Fact]
            public async Task Calls_ExistsAsync_From_repository()
            {
                // Arrenge
                var id = 2;

                // Act
                var result = await Target.ExistsAsync(id);

                // Assert
                Mock.Get(_repository).Verify(r => r.ExistsAsync(id), Times.Once);
            }

            [Fact]
            public async Task Response_Is_Bool()
            {
                //Arrange

                //Act
                var response = await Target.ExistsAsync(It.IsAny<int>());

                //Assert
                Assert.IsType<bool>(response);
            }

            [Fact]
            public async Task Response_Is_Same_As_repository()
            {
                //Arrange
                var expectedResponse = false;
                Mock.Get(_repository).Setup(rb => rb.ExistsAsync(It.IsAny<int>())).Returns(Task.FromResult(expectedResponse));

                //Act
                var response = await Target.ExistsAsync(It.IsAny<int>());

                //Assert
                Assert.Equal(expectedResponse, response);
            }
        }
    }


}

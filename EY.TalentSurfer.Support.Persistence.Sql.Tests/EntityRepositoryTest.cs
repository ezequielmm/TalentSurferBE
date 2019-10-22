using EY.TalentSurfer.Domain;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Support.Persistence.Sql.Tests
{
    public class EntityRepositoryTest
    {
        private IEnumerable<InternalEntity> _queryData;
        private IDateTimeProvider _dateTimeProvider;
        private IUserProvider _userProvider;

        private Mock<TalentSurferContext> _dbContextMock;
        private Mock<DbSet<InternalEntity>> _queryMock;

        private EntityRepository<InternalEntity> Target { get; set; }
        public class InternalEntity : Entity
        {

        }
        public EntityRepositoryTest()
        {
            _queryData = new InternalEntity[]
            {
                new InternalEntity() { Id = 555 },
                new InternalEntity() { Id = 4859 },
                new InternalEntity() { Id = 1984 },
                new InternalEntity() { Id = 47 },
                new InternalEntity() { Id = 8 },
                new InternalEntity() { Id = 2 }
            };

            _dateTimeProvider = Mock.Of<IDateTimeProvider>();
            _userProvider = Mock.Of<IUserProvider>();

            _queryMock = MockDbSet.CreateMock(_queryData);
            _dbContextMock = new Mock<TalentSurferContext>(new DbContextOptionsBuilder<TalentSurferContext>().UseInMemoryDatabase("Database").Options, _userProvider, _dateTimeProvider);

            _dbContextMock.Setup(dc => dc.Set<InternalEntity>()).Returns(_queryMock.Object);

            Target = new EntityRepository<InternalEntity>(_dbContextMock.Object);
        }
        public class Method_ToListAsync : EntityRepositoryTest
        {
            [Fact]
            public async Task Calls_ToListAsync_From_Query()
            {
                //Arrange

                //Act
                var result = await Target.ToListAsync();

                //Assert
                Assert.Equal(_queryData, result);
            }
        }
        public class Method_InsertAsync : EntityRepositoryTest
        {
            [Fact]
            public async Task SingleOrDefaultAsync_Should_return_a_value()
            {
                //Arrange
                InternalEntity SearchedEntity = new InternalEntity() { Id = 555 };

                //Act
                var result = await Target.SingleOrDefaultAsync(e => e.Id == SearchedEntity.Id);

                //Assert
                Assert.Equal(SearchedEntity.Id, result.Id);
            }

        }
        public class Method_InsertAsync_With_Single_Entity : EntityRepositoryTest
        {
            [Fact]
            public async Task Calls_AddAsync_Once()
            {
                //Arrange
                InternalEntity InsertedEntity = new InternalEntity() { Id = 555 };

                //Act
                await Target.InsertAsync(InsertedEntity);

                //Assert

                _dbContextMock.Verify(dc => dc.AddAsync(InsertedEntity, default(CancellationToken)), Times.Once);
            }

            [Fact]
            public async Task Calls_SaveChangesAsync_Once()
            {
                //Arrange
                InternalEntity InsertedEntity = new InternalEntity() { Id = 555 };

                //Act
                await Target.InsertAsync(InsertedEntity);

                //Assert

                _dbContextMock.Verify(dc => dc.SaveChangesAsync(true, default(CancellationToken)), Times.Once);
            }

        }

        public class Method_InsertAsync_With_List_Of_Entities : EntityRepositoryTest
        {
            [Fact]
            public async Task Calls_AddAsync_Once()
            {
                //Arrange

                //Act
                await Target.InsertAsync(_queryData);

                //Assert

                _dbContextMock.Verify(dc => dc.AddAsync(_queryData, default(CancellationToken)), Times.Once);
            }

            [Fact]
            public async Task Calls_SaveChangesAsync_Once()
            {
                //Arrange

                //Act
                await Target.InsertAsync(_queryData);

                //Assert

                _dbContextMock.Verify(dc => dc.SaveChangesAsync(true, default(CancellationToken)), Times.Once);
            }
        }
        public class Method_UpdateAsync_With_Single_Entity : EntityRepositoryTest
        {
            [Fact]
            public async Task Calls_Update_Once()
            {
                //Arrange
                InternalEntity UpdatedEntity = new InternalEntity() { Id = 555 };

                //Act
                await Target.UpdateAsync(UpdatedEntity);

                //Assert

                _dbContextMock.Verify(dc => dc.Update(UpdatedEntity), Times.Once);
            }

            [Fact]
            public async Task Calls_SaveChangesAsync_Once()
            {
                //Arrange
                InternalEntity UpdatedEntity = new InternalEntity() { Id = 555 };

                //Act
                await Target.InsertAsync(UpdatedEntity);

                //Assert

                _dbContextMock.Verify(dc => dc.SaveChangesAsync(true, default(CancellationToken)), Times.Once);
            }
        }
        public class Method_UpdateAsync_With_List_Of_Entities : EntityRepositoryTest
        {
            [Fact]
            public async Task Calls_Update_Once()
            {
                //Arrange

                //Act
                await Target.UpdateAsync(_queryData);

                //Assert

                _dbContextMock.Verify(dc => dc.UpdateRange(_queryData), Times.Once);
            }

            [Fact]
            public async Task Calls_SaveChangesAsync_Once()
            {
                //Arrange

                //Act
                await Target.InsertAsync(_queryData);

                //Assert

                _dbContextMock.Verify(dc => dc.SaveChangesAsync(true, default(CancellationToken)), Times.Once);
            }
        }

        public class Method_DeleteAsync : EntityRepositoryTest
        {
            [Fact]
            public async Task Calls_Updatec_Once()
            {
                //Arrange
                InternalEntity DeletedEntity = new InternalEntity() { Id = 555 };

                //Act
                await Target.DeleteAsync(DeletedEntity);

                //Assert

                _dbContextMock.Verify(dc => dc.Remove(DeletedEntity), Times.Once);
            }

            [Fact]
            public async Task Calls_SaveChangesAsync_Once()
            {
                //Arrange
                InternalEntity DeletedEntity = new InternalEntity() { Id = 555 };

                //Act
                await Target.DeleteAsync(DeletedEntity);

                //Assert
                _dbContextMock.Verify(dc => dc.SaveChangesAsync(default(CancellationToken)), Times.Once);
            }
        }
        public class Method_ExistsAsync: EntityRepositoryTest
        {
            public async Task Calls_ExistsAsync_Once()
            {
                //Arrange
                InternalEntity SearchedEntity = new InternalEntity() { Id = 555 };

                //Act
                var result = await Target.SingleOrDefaultAsync(e => e.Id == SearchedEntity.Id);

                //Assert
                Assert.Equal(SearchedEntity.Id , result.Id);
            }
        }
    }
}

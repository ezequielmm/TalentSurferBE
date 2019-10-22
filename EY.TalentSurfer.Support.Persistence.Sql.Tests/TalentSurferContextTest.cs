using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Moq;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace EY.TalentSurfer.Support.Persistence.Sql.Tests
{
    public class TalentSurferContextTest
    {
        private IDateTimeProvider _dateTimeProvider;
        private IUserProvider _userProvider;
        private TalentSurferContext Target { get; set; }

        public TalentSurferContextTest()
        {

            _dateTimeProvider = Mock.Of<IDateTimeProvider>();
            _userProvider = Mock.Of<IUserProvider>();

            Target = new TalentSurferContextProxy(new DbContextOptionsBuilder<TalentSurferContext>().UseInMemoryDatabase("Database").Options, _userProvider, _dateTimeProvider);
        }

        public class Method_AuditEntries : TalentSurferContextTest
        {
            public Method_AuditEntries()
            {
            }

            [Fact]
            public async Task CreatedBy_Property_Should_Be_Assigned_With_An_Email_When_Added()
            {
                //Arrange
                var entity = new TalentSurferContextInternalAuditableEntity() { Id = 1 };
                this.Target.Add(entity);

                string email = "test@nomail.com";
                Mock.Get(_userProvider).Setup(up => up.Email).Returns(email);
                Mock.Get(_userProvider).Setup(up => up.AppId).Returns("1");

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Assert.Equal(email, entity.CreatedBy);
            }

            [Fact]
            public async Task CreatedBy_Property_Should_Be_Assigned_With_An_AppId_When_Added_If_Email_Is_Null()
            {
                //Arrange
                var entity = new TalentSurferContextInternalAuditableEntity() { Id = 2 };
                this.Target.Add(entity);

                string appId = "1";
                Mock.Get(_userProvider).Setup(up => up.Email).Returns(default(string));
                Mock.Get(_userProvider).Setup(up => up.AppId).Returns(appId);

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Assert.Equal(appId, entity.CreatedBy);
            }

            [Fact]
            public async Task CreatedOn_Property_Should_Be_Assigned_With_DateProvider_Now_Value()
            {
                //Arrange
                var entity = new TalentSurferContextInternalAuditableEntity() { Id = 3 };
                this.Target.Add(entity);

                DateTime randomDate = new DateTime(1987, 3, 10, 19, 23, 56);
                Mock.Get(_dateTimeProvider).Setup(up => up.Now).Returns(randomDate);

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Assert.Equal(randomDate, entity.CreatedOn);
            }

            [Fact]
            public async Task ModifiedBy_Property_Should_Be_Assigned_With_An_Email_When_Modified()
            {
                //Arrange
                var entity = new TalentSurferContextInternalAuditableEntity() { Id = 4, Name = "John" };
                this.Target.Add(entity);
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                entity.Name = "Gustavo";
                this.Target.Update(entity);

                string email = "test@nomail.com";
                Mock.Get(_userProvider).Setup(up => up.Email).Returns(email);
                Mock.Get(_userProvider).Setup(up => up.AppId).Returns("1");

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Assert.Equal(email, entity.ModifiedBy);
            }

            [Fact]
            public async Task ModifyBy_Property_Should_Be_Assigned_With_An_AppId_When_Added_If_Email_Is_Null()
            {
                //Arrange
                var entity = new TalentSurferContextInternalAuditableEntity() { Id = 5, Name = "John" };
                this.Target.Add(entity);
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                entity.Name = "Gustavo";
                this.Target.Update(entity);

                string appId = "1";
                Mock.Get(_userProvider).Setup(up => up.Email).Returns(default(string));
                Mock.Get(_userProvider).Setup(up => up.AppId).Returns(appId);

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Assert.Equal(appId, entity.ModifiedBy);
            }

            [Fact]
            public async Task ModifiedOn_Property_Should_Be_Assigned_With_DateProvider_Now_Value()
            {
                //Arrange
                var entity = new TalentSurferContextInternalAuditableEntity() { Id = 8, Name = "John" };
                this.Target.Add(entity);
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                entity.Name = "Gustavo";
                this.Target.Update(entity);

                DateTime randomDate = new DateTime(1987, 3, 10, 19, 23, 56);
                Mock.Get(_dateTimeProvider).Setup(dtp => dtp.Now).Returns(randomDate);

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Assert.Equal(randomDate, entity.ModifiedOn);
            }

            [Fact]
            public async Task CreatedBy_Property_Should_Be_False_When_Modified()
            {
                //Arrange
                var entity = new TalentSurferContextInternalAuditableEntity() { Id = 6, Name = "John" };
                this.Target.Add(entity);
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                entity.Name = "Gustavo";
                this.Target.Update(entity);
                Target.Entry(entity).Property(e => e.CreatedBy).IsModified = true;

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Assert.False(Target.Entry(entity).Property(e => e.CreatedBy).IsModified);
            }

            [Fact]
            public async Task CreatedOn_Property_Should_Be_False_When_Modified()
            {
                //Arrange
                var entity = new TalentSurferContextInternalAuditableEntity() { Id = 7, Name = "John" };
                this.Target.Add(entity);
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                entity.Name = "Gustavo";
                this.Target.Update(entity);
                Target.Entry(entity).Property(e => e.CreatedOn).IsModified = true;

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Assert.False(Target.Entry(entity).Property(e => e.CreatedOn).IsModified);
            }
            [Fact]
            public async Task Non_IAuditable_Entities_Should_Not_Be_Modified_On_Add()
            {
                //Arrange
                var entity = new TalentSurferContextInternalEntity() { Id = 2, CreatedBy = "Admin User" };
                this.Target.Add(entity);

                Mock.Get(_userProvider).Setup(up => up.Email).Returns("test@nomail.com");

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Mock.Get(_userProvider).Verify(up => up.Email, Times.Never());
            }

            [Fact]
            public async Task Non_IAuditable_Entities_Should_Not_Be_Modified_On_Modify()
            {
                //Arrange
                var entity = new TalentSurferContextInternalEntity() { Id = 4, Name = "John", ModifiedBy = "Admin User" };
                this.Target.Add(entity);
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                entity.Name = "Gustavo";
                this.Target.Update(entity);
                Target.Entry(entity).Property(e => e.CreatedOn).IsModified = true;

                Mock.Get(_userProvider).Setup(up => up.Email).Returns("test@nomail.com");

                //Act
                await Target.SaveChangesAsync(default(bool), default(CancellationToken));

                //Assert
                Mock.Get(_userProvider).Verify(up => up.Email, Times.Never());
            }
            
        }
    }

    internal class TalentSurferContextInternalEntity : Entity
    {
        public string Name { get; set; }

        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
    }

    internal class TalentSurferContextInternalAuditableEntity : Entity, IAuditableEntity
    {
        public string Name { get; set; }

        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset ModifiedOn { get; set; }
    }

    internal class TalentSurferContextProxy : TalentSurferContext
    {
        public TalentSurferContextProxy(DbContextOptions<TalentSurferContext> options, IUserProvider userProvider, IDateTimeProvider dateTimeProvider)
            : base(options, userProvider, dateTimeProvider)
        {
        }

        public DbSet<TalentSurferContextInternalEntity> TalentSurferContextInternalEntity { get; set; }

        public DbSet<TalentSurferContextInternalAuditableEntity> TalentSurferContextInternalAuditableEntity { get; set; }
    }
   
}

using AutoMapper;
using AutoMapper.EquivalencyExpression;
using EY.TalentSurfer.Services;
using EY.TalentSurfer.Services.Configs;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Api;
using EY.TalentSurfer.Support.Persistence;
using EY.TalentSurfer.Support.Persistence.Sql;
using Microsoft.Extensions.DependencyInjection;

namespace EY.TalentSurfer.Api.Setup
{
    public static class ServiceCollectionSetup
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IServiceLineService, ServiceLineService>()
                .AddScoped<ICertaintyService, CertaintyService>()
                .AddScoped<IPositionService, PositionService>()
                .AddScoped<IPositionStatusService, PositionStatusService>()
                .AddScoped<IStatusService, StatusService>()
                .AddScoped<ISeniorityService, SeniorityService>()
                .AddScoped<ILocationService, LocationService>()
                .AddScoped<IOpportunityService, OpportunityService>();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IRepository<>), typeof(EntityRepository<>))
                .AddScoped<IOpportunityRepository, OpportunityRepository>();
        }

        public static IServiceCollection AddProviders(this IServiceCollection services)
        {
            return services
                .AddSingleton<IUserProvider, HttpContextUserProvider>()
                .AddSingleton<IDateTimeProvider, DateTimeProvider>();
        }

        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
                mc.AddCollectionMappers();
            });
            var mapper = mappingConfig.CreateMapper();
            return services.AddSingleton(mapper);
        }
    }
}

using AutoMapper;
using AutoMapper.EquivalencyExpression;
using EY.TalentSurfer.Services;
using EY.TalentSurfer.Services.Configs;
using EY.TalentSurfer.Services.Contracts;
using EY.TalentSurfer.Support;
using EY.TalentSurfer.Support.Api;
using EY.TalentSurfer.Support.Api.Contracts;
using EY.TalentSurfer.Support.Persistence;
using EY.TalentSurfer.Support.Persistence.Sql;
using EY.TalentSurfer.Support.Persistence.Sql.PositionsSlot;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

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
                .AddScoped<IOpportunityService, OpportunityService>()
                .AddScoped<IProjectService, ProjectService>()
                .AddScoped<IPositionEYService, PositionEYService>()
                .AddScoped<ISowService, SowService>()
                .AddScoped<IRoleService, RoleService>()
                .AddScoped<IPositionSlotService, PositionSlotService>()
                .AddScoped<IUserService, UserService>();

        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IRepository<>), typeof(EntityRepository<>))
                .AddScoped<IOpportunityRepository, OpportunityRepository>()
                .AddScoped<IRoleRepository, RoleRepository>()
                .AddScoped<IPositionSlotRepository, PositionSlotRepository>();
        }

        public static IServiceCollection AddProviders(this IServiceCollection services)
        {
            return services
                .AddSingleton<IUserProvider, HttpContextUserProvider>()
                .AddSingleton<IDateTimeProvider, DateTimeProvider>()
                .AddSingleton<IPageLinkBuilder, PageLinkBuilder>();
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

        public static AuthenticationBuilder ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var key = Encoding.UTF8.GetBytes(configuration.GetValue<string>("Authentication:Secret"));

            return services.AddAuthentication(options =>
                {
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = false;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ClockSkew = TimeSpan.Zero
                    };
                })
                .AddGoogle(options =>
                {
                    options.CallbackPath = "/signin-google";
                    options.ClientId = configuration.GetValue<string>("Authentication:ClientId");
                    options.ClientSecret = configuration.GetValue<string>("Authentication:ClientSecret");
                    options.Events = new OAuthEvents
                    {
                        OnRemoteFailure = context =>
                        {
                            context.HandleResponse();
                            var error = context.Failure.Message;
                            return Task.FromResult(0);
                        }
                    };
                    options.Events.OnCreatingTicket = (context) =>
                    {
                        if (context.User.GetValue("picture") != null)
                            context.Identity.AddClaim(new Claim("image", context.User.GetValue("picture").ToString()));
                        return Task.CompletedTask;
                    };
                });
        }
    }
}

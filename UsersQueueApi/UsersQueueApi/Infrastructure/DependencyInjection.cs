using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using UsersQueueApi.Application.Common.Interfaces;
using UsersQueueApi.Application.Common.Interfaces.Endpoints;
using UsersQueueApi.Application.Common.Interfaces.Services;
using UsersQueueApi.Application.Common.Utils;
using UsersQueueApi.Infrastructure.Endpoints;
using UsersQueueApi.Infrastructure.Persistence;
using UsersQueueApi.Infrastructure.Services;

namespace UsersQueueApi.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = VariablesUtil.GetConnectionString(configuration);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connection,
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IGrpcEndpoint, GrpcEndpoint>();

            return services;
        }
    }
}

using CleanArc.Application.Interfaces;
using CleanArc.Application.Services;
using CleanArc.Data.Repository;
using CleanArc.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.IoC;

public static class DependencyContainer
{
    public static void RegisterServices(this IServiceCollection services)
    {
        // Application layer 
        services.AddScoped<ICourseService, CourseService>();

        // Data Layer
        services.AddScoped<ICourseRepository, CourseRepository>();
    }
}

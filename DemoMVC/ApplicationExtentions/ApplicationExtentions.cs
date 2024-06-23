using Demo.BLL.Interfaces;
using Demo.BLL.Repositories;
using Demo.PL.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.PL.ApplicationExtentions
{
    public static class ApplicationExtentions
    {
        public static IServiceCollection AddToContainer( this IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }

       
    }
}

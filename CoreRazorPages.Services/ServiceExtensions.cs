using CoreRazorPages.Repository;
using CoreRazorPages.Services.Implementation;
using CoreRazorPages.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreRazorPages.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            return  services.AddScoped(typeof(IRepository<>), typeof(Repository<>))
                            .AddScoped<IEmployee, EmployeeService>()
                            .AddScoped<IDepartmentService, DepartmentService>();
        }
    }
}

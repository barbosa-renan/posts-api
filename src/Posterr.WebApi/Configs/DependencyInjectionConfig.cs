using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Posterr.WebApi.Configs
{
    public static class DependencyInjectionConfig
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}

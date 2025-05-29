using GerenciadorTarefas.Application.DependencyInjection;
using GerenciadorTarefas.Data.DependencyInjection;

namespace GerenciadorTarefas.API
{
    public static class ServiceCollectionConfig
    {
        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddData(configuration);
            services.AddApplication();
        }
    }
}

using GerenciadorTarefas.Application.Services;
using GerenciadorTarefas.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorTarefas.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ITarefaCadastroService, TarefaCadastroService>();
            services.AddScoped<ITarefaConsultaService, TarefaConsultaService>();
            services.AddScoped<ITarefaEditarService, TarefaEditarService>();
            services.AddScoped<ITarefaDeletarService, TarefaDeletarService>();

            return services;
        }
    }
}

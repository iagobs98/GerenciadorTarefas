using GerenciadorTarefas.Data.Context;
using GerenciadorTarefas.Data.Repository;
using GerenciadorTarefas.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorTarefas.Data.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GerenciadorTarefasContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<ITarefaCadastroRepository, TarefaCadastroRepository>();
            services.AddScoped<ITarefaConsultaRepository, TarefaConsultaRepository>();
            services.AddScoped<ITarefaEditarRepository, TarefaEditarRepository>();
            services.AddScoped<ITarefaDeletarRepository, TarefaDeletarRepository>();

            return services;
        }
    }
}

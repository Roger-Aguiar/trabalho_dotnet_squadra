using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Calcados.Models;
using Calcados.Services;
using Calcados.UseCase;
using Calcados.Repositórios;
using Calcados.Adapters;
using Calcados.Bordas.Adapter;

namespace Calcados
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CalcadoContext>(option => option.UseNpgsql(Configuration.GetConnectionString("CalcadoDatabase")));

            services.AddScoped<ICalcadoService, CalcadoService>();

            services.AddScoped<IAdicionarCalcadosUseCase, AdicionarCalcadoUseCase>();
            services.AddScoped<IAtualizarCalcadosUseCase, AtualizarCalcadoUseCase>();
            services.AddScoped<IDeletarCalcadosUseCase, DeletarCalcadoUseCase>();
            services.AddScoped<IRetornarCalcadosPorIdUseCase, RetornarCalcadoPorIdUseCase>();
            services.AddScoped<IRetornarCalcadosUseCase, RetornarCalcadoUseCase>();

            services.AddScoped<IRepositorioCalcados, RepositorioCalcados>();

            services.AddScoped<IAdicionarCalcadoAdapter, AdicionarCalcadoAdapter>();
            services.AddScoped<IUpdateCalcadosAdapter, UpdateCalcadosAdapter>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

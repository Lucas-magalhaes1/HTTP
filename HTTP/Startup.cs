using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleHttpApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Configura o serviço de MVC
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            // Middleware para tratamento de erros
            app.UseStatusCodePages(async context =>
            {
                var response = context.HttpContext.Response;

                switch (response.StatusCode)
                {
                    case 401:
                    case 403:
                        await response.WriteAsync("Acesso negado.");
                        break;
                    case 404:
                        await response.WriteAsync("Página não encontrada.");
                        break;
                    case 500:
                        await response.WriteAsync("Erro interno do servidor.");
                        break;
                }
            });

            // Configura a rota padrão
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

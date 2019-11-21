using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackJackApi.Core.Dal.Interfaces;
using BlackJackApi.Core.Services;
using BlackJackApi.Core.Services.Interfaces;
using BlackJackApi.Dal.Context;
using BlackJackApi.Dal.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BlackJackApi
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
            services.AddControllers().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc()
                .AddMvcOptions(o => o.OutputFormatters.Add(
                    new XmlDataContractSerializerOutputFormatter()));

            services.AddCors(o => o.AddPolicy("AllowAnyOriginPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));

            var connectionString = Configuration["ConnectionStrings:BlackJackDBConnectionString"];
            services.AddDbContext<BlackJackContext>(o => o.UseSqlServer(connectionString));

            services.AddTransient<ICardRepository, CardRepository>();
            services.AddTransient<IDealerRepository, DealerRepository>();
            services.AddTransient<IDeckRepository, DeckRepository>();
            services.AddTransient<IGameRepository, GameRepository>();
            services.AddTransient<IPlayerRepository, PlayerRepository>();

            services.AddTransient<ICardService, CardService>();
            services.AddTransient<IDealerService, DealerService>();
            services.AddTransient<IDeckService, DeckService>();
            services.AddTransient<IGameService, GameService>();
            services.AddTransient<IPlayerService, PlayerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStatusCodePages();

            app.UseCors("AllowAnyOriginPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

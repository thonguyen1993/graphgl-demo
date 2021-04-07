using GraphQL.Sample.Api.GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQLAPIDemo.GraphQL.Resository;
using GraphQLAPIDemo.Services;
using GraphQLAPIExample.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace GraphQL.Sample.Api
{
    public class Startup
    {
        private IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<MongoDbSettings>(
                Configuration.GetSection("WordDatabaseSetting"));

            

            services.AddSingleton<IMongoDbSettings>(sp =>
                sp.GetRequiredService<IOptions<MongoDbSettings>>().Value);

            services.AddScoped<IMongoContext, MongoContext>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICarService, CarService2>();


            services.AddScoped<CarService2>();

            services.AddScoped<Schema>();

            services.AddGraphQL()
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddDataLoader()
                .AddSystemTextJson();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseGraphQL<Schema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());

            
        }

        private static void EnableRetryOnFailure(SqlServerDbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.EnableRetryOnFailure(10, TimeSpan.FromSeconds(30), null);
    }
}
using Louer.Infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace Louer.WebApi
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
            //services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
            services.AddControllers();

            //services.AddTransient<MySqlConnection>(_ => new MySqlConnection(Configuration["ConnectionStrings:DefaultConnection"]));

            //services.AddCors();

            //services.AddDbContext<LouerContexto>(options => options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddMvc();

            // Register the Swagger generator, defining 1 or more Swagger documents

            services.AddSwaggerGen();
            // Register the Swagger generator, defining 1 or more Swagger documents
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo
            //    {
            //        Version = "v1",
            //        Title = "ToDo API",
            //        Description = "A simple example ASP.NET Core Web API",
            //        TermsOfService = new Uri("https://example.com/terms"),
            //        Contact = new OpenApiContact
            //        {
            //            Name = "Shayne Boyer",
            //            Email = string.Empty,
            //            Url = new Uri("https://twitter.com/spboyer"),
            //        },
            //        License = new OpenApiLicense
            //        {
            //            Name = "Use under LICX",
            //            Url = new Uri("https://example.com/license"),
            //        }
            //    });
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.

            //app.UseSwagger();
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            /*
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
            */
        }
    }
}

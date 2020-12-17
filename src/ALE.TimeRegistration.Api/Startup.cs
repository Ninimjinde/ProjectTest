using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Core.Interfaces.Repositories;
using ALE.TimeRegistration.Core.Interfaces.Services;
using ALE.TimeRegistration.Core.Services;
using ALE.TimeRegistration.Infrastructure.Data;
using ALE.TimeRegistration.Infrastructure.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;

namespace ALE.TimeRegistration.Api
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
            services.AddDbContext<ApplicationDbContext>(options =>
                                                        options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));

            services.AddIdentity<User, IdentityRole>(options =>
                {
                    options.SignIn.RequireConfirmedEmail = true;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(jwtOptions =>
            {
                jwtOptions.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateActor = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidIssuer = Configuration["JWTConfiguration:Issuer"],
                    ValidAudience = Configuration["JWTConfiguration: Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTConfiguration: SigninKey"]))
                };
            });

            services.AddControllers();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IRepository<Message>, EfRepository<Message>>();
            services.AddScoped<IRepository<Picture>, EfRepository<Picture>>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITaskService, TaskService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TimeRegistration API", Version = "v1" });
            });

            services.AddCors();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
            app.UseAuthentication();

            app.UseCors(builder => builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TimeRegistration API");
                c.RoutePrefix = string.Empty;
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

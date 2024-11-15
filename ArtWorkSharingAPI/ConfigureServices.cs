using ArtWorkSharingAPI.Services;
using AWS_BusinessObjects.Common.Interfaces;
using AWS_Repository.Identity;
using AWS_BusinessObjects.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using AWS_Repository.Interface;
using AWS_Repository.Repositories;
using AWS_Services.Interface;
using AWS_Services.Services;
using AWS_DAO;
using AWS_BusinessObjects.Entities;

namespace Microsoft.Extensions.DependencyInjection;
public static class ConfigureServices
{
    public static IServiceCollection AddAPIServices(this IServiceCollection services)
    {
        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddScoped<ICurrentUserService, CurrentUserService>();

        services.AddHttpContextAccessor();

        //services.AddHealthChecks()
        //    .AddDbContextCheck<ApplicationDbContext>();

        //services.AddControllersWithViews();

        //services.AddRazorPages();


        //----------DI------------------
        // Service
        services.AddScoped<IArtWorkService, ArtWorkService>();
        services.AddScoped<IInteractService, InteractService>();
        services.AddScoped<IOrderService,OrderService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IWishListService, WishListService>();

        //services.AddScoped<IAdminAccountRepository, AdminAccountRepository>();
        // Repository
        services.AddScoped<IAccountRepository, AccountRepository>();

        services.AddScoped<IArtWorkRepository, ArtWorkRepository>();        
        services.AddScoped<IInteractRepository,InteractRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IWishListRepository, WishListRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        // DAO
        services.AddScoped<ArtWorkDAO>();
        services.AddScoped<InteractDAO>();
        services.AddScoped<OrderDAO>();
        services.AddScoped<WishListDAO>();
        services.AddScoped<CategoryDAO>();


        // Customise default API behaviour
        services.Configure<ApiBehaviorOptions>(options =>
            options.SuppressModelStateInvalidFilter = true);

        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo { Title = "Art Work Sharing API", Version = "v1" });
            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
        });
        return services;
    }
}

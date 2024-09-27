using apiCaptar.Config;
using apiCaptar.Configuration;
using apiCaptar.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;



public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        IServiceCollection serviceCollection = services.AddDbContext<MySQLContext>(static options =>
            options.UseSqlServer("server= localhost;database= api-pesquisa;user id=rc;password=hhhjjj321;"));


        //aa

        services.AddControllers();

        IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
        services.AddSingleton(mapper);
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddScoped<IUserRepository, UserRepository>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

        var supportedCultures = new[] { new CultureInfo("en-US") };
        app.UseRequestLocalization(new RequestLocalizationOptions
        {
            DefaultRequestCulture = new RequestCulture("en-US"),
            SupportedCultures = supportedCultures,
            SupportedUICultures = supportedCultures
        });

        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}


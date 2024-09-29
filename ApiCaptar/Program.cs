using apiCaptar.Config;
using apiCaptar.Configuration;
using apiCaptar.Repository;
using apiCaptar.Repository.Implementation;
using apiCaptar.Repository.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connection = builder.Configuration["ConnectionStrings:sqlConexao"];

builder.Services.AddDbContext<MySQLContext>(options => options.UseSqlServer(connection));


IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IpesquisaRepository, PesquisaRepository>();

builder.Services.AddControllers();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()      // Allows requests from any origin
              .AllowAnyMethod()      // Allows any HTTP method (GET, POST, PUT, DELETE, etc.)
              .AllowAnyHeader();     // Allows any headers
    });
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
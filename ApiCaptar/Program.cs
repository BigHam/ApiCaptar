using apiCaptar.Config;
using apiCaptar.Configuration;
using apiCaptar.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;








var builder = WebApplication.CreateSlimBuilder(args);

var connection = builder.Configuration["ConnectionStrings:sqlConexao"];



builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(
    connection,
    new MySqlServerVersion(new Version(8, 0, 8)))
);

// Registro do AutoMapper
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddAutoMapper(typeof(MappingConfig).Assembly);
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();


// Constru��o da aplica��o
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware para redirecionamento HTTPS
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Autentica��o e autoriza��o
app.UseAuthentication();
app.UseAuthorization();



// Mapeamento de controladores
app.MapControllers();




// Execu��o da aplica��o
app.Run();



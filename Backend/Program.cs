using Backend.DataContext;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(x =>
        x.JsonSerializerOptions.ReferenceHandler =
            System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles
    );

var configuration = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();
string cadenaConexion = configuration.GetConnectionString("mysqlRemoto");

// Configuración de inyección de dependencias del DBContext
builder.Services.AddDbContext<RegistroAccesoContext>(
    options => options.UseMySql(cadenaConexion,
                                ServerVersion.AutoDetect(cadenaConexion)));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection for services
builder.Services.AddScoped<IAlumnoService, AlumnoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

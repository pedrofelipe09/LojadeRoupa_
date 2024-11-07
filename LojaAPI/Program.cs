 using LojaAPI;
using LojadeRoupa._02_Repository.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // Informa ao Swagger para incluir o arquivo XML gerado
    var xmlFile = "Documentacao.xml"; // Nome do arquivo XML gerado
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);

    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Loja de Roupa",
        Version = "v1",
        Description = "Este sistema é de uma loja de vendas de roupas femininas e masculinas"
    });
});
builder.Services.AddAutoMapper(typeof(MappingProfile));
Inicializador_bd.Inicializar();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Loja de Roupa v1");
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


using System.Text.Json.Serialization;
using GerenciadorTarefas.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ServiceCollectionConfig.AddServices(builder.Services, builder.Configuration);

builder.Services
    .AddControllers()
    .AddJsonOptions(options => 
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())
    );
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

app.UseCors(options => {
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.WithHeaders("accept", "content-type", "origin"); 
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

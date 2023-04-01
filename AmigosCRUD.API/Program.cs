using AmigosCRUD.Domain.Interfaces;
using AmigosCRUD.Services;
using AmigosCRUD.Services.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Services with Layer
builder.Services.AddScoped<IAmigoService, AmigoService>();

//Add Connection Instance
builder.Services.AddDbContext<AmigosDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ApiFDataBase")));

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

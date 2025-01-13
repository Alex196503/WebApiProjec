using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiProjec.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProiectMediiBunContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProiectMediiBunContext")
    ?? throw new InvalidOperationException("Connection string 'ProiectMediiBunContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();

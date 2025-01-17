using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiProjec.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProiectMediiBunContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProiectMediiBunContext")
    ?? throw new InvalidOperationException("Connection string 'ProiectMediiBunContext' not found.")));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

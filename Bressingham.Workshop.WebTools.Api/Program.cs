using Bressingham.Workshop.WebTools.Data;
using Bressingham.Workshop.WebTools.Logic;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// 034QjI4IH1jNs4U56B3w6M9TXlH3qc5u
builder.Services.AddDbContext<WebToolsContext>(o => 
    o.UseSqlServer("Server=.;Database=WebTools;User Id=webtoolsapi;Password=034QjI4IH1jNs4U56B3w6M9TXlH3qc5u;TrustServerCertificate=True;"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IWebToolsLogic, WebToolsLogic>();

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

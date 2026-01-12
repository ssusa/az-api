using Microsoft.EntityFrameworkCore;
using Npgsql;
using az_api.Models;
using az_api.DataAccess;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AzDbContext>(options => options.UseNpgsql(connectionString));

// Dapper用PostgreSQL接続をDI登録
builder.Services.AddScoped(_ => new NpgsqlConnection(connectionString));
builder.Services.AddScoped<SyainDataAccess>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();
app.Run();

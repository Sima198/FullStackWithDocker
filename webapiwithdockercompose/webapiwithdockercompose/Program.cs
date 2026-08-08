using Microsoft.EntityFrameworkCore;
using webapiwithdockercompose.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

// CORS for Angular
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.WithOrigins(
                    "http://localhost:4200",
                    "http://localhost:4202"
                )
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Database
builder.Services.AddDbContext<CiitstudContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("MyCon"));
});

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// HTTP pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Comment this for Docker testing
// app.UseHttpsRedirection();

// Apply CORS BEFORE controllers
app.UseCors("AllowAngular");

app.UseAuthorization();

app.MapControllers();

app.Run();
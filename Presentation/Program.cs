using Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

string dbConnectionString = builder.Configuration.GetConnectionString("DbConnectionString")!;
builder.Services.AddDbContext<CheezManagerDbContext>(options =>
{
    options.UseNpgsql(dbConnectionString);
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();

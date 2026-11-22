using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IPassService, PassService>();
builder.Services.AddDbContext<Project_APIContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("\"Data Source=srv2\\\\pupils;Initial Catalog=Project_API;Integrated Security=True;Trust Server Certificate=True\"")));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();

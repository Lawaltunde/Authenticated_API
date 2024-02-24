using AUTHENTICATED_API.Data;
using AUTHENTICATED_API.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDataContext>(
    options => options.UseInMemoryDatabase("DataDb"));

builder.Services.AddDbContext<AppSecurityContext>(
    options => options.UseInMemoryDatabase("SecurityDb"));
builder.Services.AddAuthorization();

builder.Services.AddIdentityApiEndpoints<ShoppingCartModel>()
    .AddEntityFrameworkStores<AppSecurityContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapIdentityApi<AppUser>();

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

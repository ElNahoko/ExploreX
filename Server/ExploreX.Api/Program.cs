using Microsoft.EntityFrameworkCore;
using ExploreX.Domain.Repositories;
using ExploreX.Infrastructure.Data;
using ExploreX.Infrastructure.Repositories;
using Microsoft.OpenApi.Models;
using ExploreX.Application.CommandHandlers;
using System.Reflection;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ExploreX API", Version = "v1" });
});

builder.Services.AddMediatR(Assembly.GetAssembly(typeof(AddDestinationCommandHandler)));

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ExploreX API v1");
    });
}

app.UseRouting();

app.MapControllers();

app.Run();
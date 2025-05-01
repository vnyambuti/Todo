using Microsoft.EntityFrameworkCore;
using Todo.Infrastructure.Context;
using Todo.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


builder.Services.AddDbContext<TodoDbContext>(options =>
{

    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), b => b.MigrationsAssembly("Todo.Infrastructure"));

});


builder.Services.AddScoped(typeof(IBaseRepository<>),typeof(BaseRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<TodoContext>();

    if (!context.TodoItems.Any())
    {
        context.TodoItems.AddRange(
            new TodoItem { Name = "Go to school every day", IsComplete = false },
            new TodoItem { Name = "Do C# coding", IsComplete = false },
            new TodoItem { Name = "Brew homemade beer", IsComplete = true },
            new TodoItem { Name = "Meet a girlfriend", IsComplete = true },
            new TodoItem { Name = "Plan a travel to GB", IsComplete = false }
        );
        context.SaveChanges();
    }
}

app.Run();
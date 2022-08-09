using Microsoft.EntityFrameworkCore;
using backend.Models;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDbContext<CalculationContext>(opt =>
    opt.UseInMemoryDatabase("CalculationList"));


var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
using Pedalea.BusinessCore;
using Pedalea.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

builder.Services.DependencyInjectionPedaleaPersistence();
builder.Services.DependencyInjectionPedaleaBusinessCore();

var app = builder.Build();

app.UseCors(options =>
{
    options.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

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

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PetCare.API.Data;
using PetCare.API.Data.Pets;

var builder = WebApplication.CreateBuilder(args);

//Cross-Origin Resource Sharing (CORS) service added
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        builder => builder.WithOrigins("http://localhost:3000/")
        .AllowAnyMethod()
        .AllowAnyHeader().AllowAnyOrigin());
});

// Add services to the container.
builder.Services.AddDbContext<PetCareContext>();
 

builder.Services.AddControllers();

//Mock repo has to be swapped out by the real repo where th einterface is mapped to
builder.Services.AddScoped<IPetRepo, PostgresRepo>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





var app = builder.Build();


//use CORS policy
app.UseCors("AllowReactApp");


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

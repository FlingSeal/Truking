using Microsoft.EntityFrameworkCore;
using Truking.Data;
using Truking.Models.Dto;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string context = builder.Configuration.GetConnectionString("Trucing");
builder.Services.AddDbContext<TrukingDbContext>(option =>
        option.UseSqlServer(context));
builder.Services.AddAutoMapper(typeof(DtoMappingProfile));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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

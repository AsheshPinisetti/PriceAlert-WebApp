using AuthApi.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string ConnectionString = "Data source=ASHESHPINISETTI; Initial Catalog=PriceAlert; Integrated Security=true; MultipleActiveResultSets=true; Encrypt=false;";
builder.Services.AddControllers();
builder.Services.AddDbContext<AuthDbContext>(option => option.UseSqlServer(ConnectionString));
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
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

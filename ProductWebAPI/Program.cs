using Microsoft.EntityFrameworkCore;
using ProductWebAPI;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();

// DB Context Dependency Injection
var dbHost = "localhost";
var dbName = "productdb1";
var dbPassword = "123";

var connectionString = $"server={dbHost};database={dbName};user=root;password={dbPassword}";


builder.Services.AddDbContext<ProductDBContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Injection done

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

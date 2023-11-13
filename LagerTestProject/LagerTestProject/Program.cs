using LagerTestProject.DatabaseContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<IDataBaseContext,DataBaseContext>();
builder.Services.AddAutoMapper(typeof(Program));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
await MigrationAsync();

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
async Task MigrationAsync()
{
	try
	{
        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        var dbContext = services.GetRequiredService<DataBaseContext>();
        await dbContext.Database.MigrateAsync();

    }
	catch (Exception ex)
	{
        var loggerFactory=app.Services.GetRequiredService<ILoggerFactory>();
        var logger=loggerFactory.CreateLogger<Program>();
        logger.LogError(ex, "An exception occurred");
	}
}

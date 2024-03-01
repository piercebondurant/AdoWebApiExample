using AdoWebApiExample.Repositories.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//BEGIN ADD DEPENDENCY INJECTION FOR ICONFIGURATION
//----------------------------------------------------
var configBuilder = new ConfigurationBuilder();
configBuilder.AddJsonFile("appsettings.json");
var config = configBuilder.Build();
builder.Services.AddSingleton<IConfiguration>(config);
//----------------------------------------------------
//END SET UP DEPENDENCY INJECTION FOR ICONFIGURATION

//BEGIN ADD DEPDENDENCY INJECTION FOR YOUR REPOSITORIES
//-----------------------------------------------
builder.Services.AddScoped<ExampleRepository>();
//-----------------------------------------------
//END SET UP DEPENDENCY INJECTION FOR YOUR REPOSITORIES



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

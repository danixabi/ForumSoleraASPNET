using Microsoft.EntityFrameworkCore;
using ForumBackend.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApiContext>
    (opt => opt.UseInMemoryDatabase("ForumDb"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Set up connection with React:
var frontend_url = "http://localhost:3000/";
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddCors(options =>
{
    //var frontendUrl = configuration.GetValue<string>(frontend_url);
    Console.WriteLine(frontend_url);
    options.AddDefaultPolicy(builder =>
    {
        builder
            .WithOrigins(frontend_url)
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
//-----

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Set up connection with React:
app.UseCors();
//-----

app.UseAuthorization();

app.MapControllers();

app.Run();

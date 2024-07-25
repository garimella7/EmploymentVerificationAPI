
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registering the Service class
builder.Services.AddTransient<IVerifyEmploymentService, VerifyEmploymentService>();

// Adding CORS
builder.Services.AddCors();

var app = builder.Build();

//app.UseDefaultFiles(); // This line enables default file serving
app.UseStaticFiles(); // Enable serving static files from wwwroot

app.UseCors(builder =>
        builder.WithOrigins("https://localhost:7287/")
            .AllowAnyHeader()
            .AllowAnyMethod()
    );

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

// Serve index.html for any non-API requests
app.MapFallbackToFile("index.html");

app.Run();

using Core_API.CustomMiddleware;
using Core_API.ModelClasses;
using Core_API.Models;
using Core_API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//1. REgister the DbContext in Dependency COntainer as a Service
builder.Services.AddDbContext<ApiDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnStr"));
});

// COnfigure tge REdis Cache
builder.Services.AddDistributedRedisCache(options => {
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
});

// 2. Register Custom Service in DI COntainer
builder.Services.AddScoped<IService<Category, int>, CategoryService>();
builder.Services.AddScoped<IService<Product, int>, ProductService>();


//builder.Services.AddControllers();

builder.Services.AddControllers()
        .AddJsonOptions(options => {
            // SUpress the defualut Camel Casing for Property NAmes
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
        }).AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// COnfigure the CORS Service
builder.Services.AddCors(options => {
    options.AddPolicy("corspolicy", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});


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

//app.UseRouting();

app.UseAuthorization();
app.UseRequesException();

// Use the Custom Log Middleward
app.UseLogRequiest();
app.UseRouting();


app.MapControllers();

app.Run();

using FinalApp;
using FinalApp.Services.Mapper;
using FinalApp.Services.Services;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
 {
     c.MapType<DateOnly>(() => new OpenApiSchema { Type = "string", Format = "date" });
 });

builder.Services.AddControllers()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
        });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureDbConnection(builder.Configuration);

builder.Services.AddSingleton<IMeasurementMapper, MeasurementMapper>();
builder.Services.AddSingleton<IWorkerMapper, WorkerMapper>();
builder.Services.AddSingleton<ISurgeryMapper, SurgeryMapper>();
builder.Services.AddSingleton<IChelationTherapyMapper, ChelationTherapyMapper>();

builder.Services.AddTransient<IMeasurementService, MeasurementService>();
builder.Services.AddTransient<IWorkerService, WorkerService>();
builder.Services.AddTransient<IWorkplaceService, WorkplaceService>();
builder.Services.AddTransient<ISurgeryService, SurgeryService>();
builder.Services.AddTransient<IChelationTherapyService, ChelationTherapyService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

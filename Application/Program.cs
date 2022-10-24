using Application.Mappings;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

var app = builder.Build();


builder.Services.AddSingleton(AutoMapperConfig.Initialize());

app.MapGet("/", () => "Hello World!");

app.Run();

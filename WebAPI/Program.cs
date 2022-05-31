using Microsoft.AspNetCore.Mvc;
using WebAPI;
using WebAPI.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureDI();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.AddEndpoints();

app.UseSwagger();
app.UseSwaggerUI();
app.Run();

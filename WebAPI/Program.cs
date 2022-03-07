using Microsoft.AspNetCore.Mvc;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IProdutosService, ProdutosService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

app.MapGet("produtos", async  ( [FromServices] IProdutosService _service) =>
{
    var lista = _service.GetAll();
    return Results.Ok(lista);
});

app.MapGet("produtos/{id}", async ([FromServices] IProdutosService _service, int id) =>
{
    var item = _service.GetOne(id);
    return Results.Ok(item);
});

app.UseSwagger();
app.UseSwaggerUI();
app.Run();

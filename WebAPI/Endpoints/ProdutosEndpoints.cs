using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Endpoints
{
    public static class ProdutosEndpoints
    {
        public static void AddProdutosEndpoints(this WebApplication app )
        {
            app.MapGet("produtos", async ([FromServices] IProdutosService _service) =>
            {
                var lista = _service.GetAll();
                return Results.Ok(lista);
            });

            app.MapGet("produtos/{id}", async ([FromServices] IProdutosService _service, [FromRoute] int id) =>
            {
                var item = _service.GetOne(id);
                return Results.Ok(item);
            });
        }
    }
}

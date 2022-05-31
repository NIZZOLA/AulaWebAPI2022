using WebAPI.Endpoints;

namespace WebAPI.Startup
{
    public static class ConfigureEndpointsConfig
    {
        public static void AddEndpoints(this WebApplication app)
        {
            ProdutosEndpoints.AddProdutosEndpoints(app);
            //podemos inserir vários outros conjuntos aqui
        }
    }
}

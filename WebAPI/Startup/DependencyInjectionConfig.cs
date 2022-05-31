namespace WebAPI.Startup
{
    public static class DependencyInjectionConfig
    {
        public static void ConfigureDI(this IServiceCollection services)
        {
            services.AddSingleton<IProdutosService, ProdutosService>();
            // poderemos colocar aqui todos os serviços e repositórios
        }
    }
}

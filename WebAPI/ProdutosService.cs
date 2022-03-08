namespace WebAPI
{
    public class ProdutosService : IProdutosService
    {
        private IList<ProdutosModel> _produtos;
        public ProdutosService()
        {
            _produtos = new List<ProdutosModel>();
            _produtos.Add(new ProdutosModel() { Id = 1, Descricao = "Tomate", Ativo = true, Custo = 1, 
                Preco = 2, Estoque = 10 });
            _produtos.Add(new ProdutosModel() { Id = 2, Descricao = "Laranja", Ativo = true, Custo = 2, 
                Preco = 3, Estoque = 20 });
            _produtos.Add(new ProdutosModel() { Id = 3, Descricao = "Cebola", Ativo = true, Custo = 3, 
                Preco = 4, Estoque = 30 });
            _produtos.Add(new ProdutosModel() { Id = 4, Descricao = "Melancia", Ativo = true, Custo = 4, 
                Preco = 5, Estoque = 40 });
        }
        public ICollection<ProdutosModel> GetAll()
        {
            return _produtos;
        }

        public ProdutosModel GetOne(int id)
        {
            return _produtos.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}

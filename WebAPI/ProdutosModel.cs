namespace WebAPI
{
    public class ProdutosModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public decimal Custo { get; set; }
        public decimal Preco { get; set; }
        public decimal Estoque { get; set; }
        public string? Foto { get; set; }
        public DateTime DataDoCadastro { get; set; }
        public DateTime DataDaAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}

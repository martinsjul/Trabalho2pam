namespace Trabalho2pam
{
    public class Produto
    {
        public required string Nome { get; set; }
        public required double Preco { get; set; }
        public required string Descricao { get; set; }
        public required DateTime? Validade { get; set; }
        public required string Categoria { get; set; }
      
        public string PrecoFormatado => $"R$ {Preco:F2}";

        public Produto() { }

        public Produto(string nome, double preco)
        {
            
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Preco = preco;
        }
    }
}

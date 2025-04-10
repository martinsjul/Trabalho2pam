namespace Trabalho2pam
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public DateTime? Validade { get; set; }
        public string Categoria { get; set; }

        public string PrecoFormatado => $"R$ {Preco:F2}";

        public Produto() { }

        public Produto(string nome, double preco)
        {
            
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Preco = preco;
        }
    }
}

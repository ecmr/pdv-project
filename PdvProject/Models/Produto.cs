namespace PdvProject.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {Nome} - R${Preco:F2}";
        }
    }
}
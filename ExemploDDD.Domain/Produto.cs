namespace ExemploDDD.Domain;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public double Preco { get; set; }

    public void AtualizarPreco(double novoPreco)
    {
        if (novoPreco < 0)
        {
            throw new ArgumentException("O preço do produto não pode ser negativo.");
        }
        Preco = novoPreco;
    }
}

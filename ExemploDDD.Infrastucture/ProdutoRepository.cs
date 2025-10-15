using ExemploDDD.Domain;

namespace ExemploDDD.Infrastucture;

public class ProdutoRepository : IProdutoRepository
{
    private List<Produto> _produtos = new List<Produto>()
    {
        new Produto() { Id = 1, Nome = "Produto 1", Preco = 5.99 },
        new Produto() { Id = 2, Nome = "Produto 2", Preco = 9.99 },
        new Produto() { Id = 3, Nome = "Produto 3", Preco = 12.99 },
    };

    // Em uma aplicação real, este método faria a devida operação com um banco de dados por meio de chamada assíncrona

    public List<Produto> GetAll()
        => _produtos;
}

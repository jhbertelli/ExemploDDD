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

    // Em uma aplicação real, os métodos abaixo devem fazer as devidas operações
    // com um banco de dados, em chamadas assíncronas que retornam uma Task

    public void Delete(Produto produto)            
        => _produtos.Remove(produto);

    public List<Produto> GetAll()
        => _produtos;

    public Produto? FindById(int id)
        => _produtos.Find(x => x.Id == id);

    public void Insert(Produto produto)
        => _produtos.Add(produto);
}

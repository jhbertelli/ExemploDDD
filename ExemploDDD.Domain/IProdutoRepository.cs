namespace ExemploDDD.Domain;

public interface IProdutoRepository
{
    public List<Produto> GetAll();
    public void Insert(Produto produto);
    public void Delete(Produto produto);
    public Produto? FindById(int id);
}

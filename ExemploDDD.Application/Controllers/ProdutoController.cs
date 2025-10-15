using ExemploDDD.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ExemploDDD.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpGet("GetAllProdutos")]
    public GetProdutoOutput[] GetAll()
    {
        var produtos = _produtoRepository.GetAll();

        return produtos
            .Select(produto => new GetProdutoOutput
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Preco = produto.Preco
            })
            .ToArray();
    }
}

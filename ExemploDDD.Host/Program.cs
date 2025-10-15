using ExemploDDD.Application.Controllers;
using ExemploDDD.Domain;
using ExemploDDD.Infrastucture;

var builder = WebApplication.CreateBuilder(args);

// Adiciona as controllers da camada de aplicação
builder.Services.AddControllers().AddApplicationPart(typeof(ProdutoController).Assembly);

// Configura injeção de dependência entre a interface e a implementação do ProdutoRepository
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

// Configuração do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();

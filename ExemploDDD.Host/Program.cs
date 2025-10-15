using ExemploDDD.Application.Controllers;
using ExemploDDD.Domain;
using ExemploDDD.Infrastucture;

var builder = WebApplication.CreateBuilder(args);

// Adiciona as controllers da camada de aplica��o
builder.Services.AddControllers().AddApplicationPart(typeof(ProdutoController).Assembly);

// Configura inje��o de depend�ncia entre a interface e a implementa��o do ProdutoRepository
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

// Configura��o do Swagger
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

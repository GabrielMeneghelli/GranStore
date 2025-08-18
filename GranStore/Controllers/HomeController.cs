using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Categoria> categorias = new List<Categoria>
        {
            new Categoria
            {Id = 1, Nome = "Chuteira"},
            new Categoria
            {Id = 2, Nome = "Camiseta"},
            new Categoria
            {Id = 3, Nome = "Suplementos"},
            new Categoria
            {Id = 4, Nome = "Mochilas"},
            new Categoria
            {Id = 5, Nome = "Inverno"},
        
        };

        List<Produto> produtos = new List<Produto>
        {
            new Produto
            { Id = 1, Categoria = categorias[0], Nome = "Chuteira Campo Adidas F50 Club Unissex - Branco+Rosa", Descricao = "Rabisque a zaga toda com a Chuteira Campo Adidas F50 Club! Ideal para quem busca performance nas quatro linhas, esta chuteira de campo Adidas é leve e macia. O cabedal confeccionado em sintético traz tecnologia Fiberskin, que se adapta ao formato do pé, garantindo conforto nos chutes precisos. Seu solado com travas fixas proporcionam maior aderência ao gramado natural, enquanto o design garante a classe do jogador profissional. Marcar golaços nunca foi tão fácil. Peça já sua chuteira da Adidas!", ValorCusto = 100.00m, ValorVenda = 264.50m, QtdeEstoque = 24, Foto = "/img/produtos/0.png"},
            new Produto
            {Id = 2, Categoria = categorias[1], Nome = "Camisa Palmeiras I 24/25 s/n° Jogador Puma Masculina - Verde", Descricao = "Uma história de suor, conquistas e vitórias. A Camisa Palmeiras I 24/25 s/n° Jogador Puma Masculina representa o legado do maior campeão nacional que através do futebol une famílias, amigos e desconhecidos pela paixão alviverde. O manto de 110 anos remete à sensação de pertencimento que os torcedores compartilham em torcer pelo maior clube do Brasil.", ValorCusto = 140.67m, ValorVenda = 299.50m, QtdeEstoque = 7, Foto = "/img/produtos/1.png"},
            new Produto
            {Id = 3, Categoria = categorias[2], Nome = "Creatina Monohidratada 500g - 100% Pura Importada Dark Lab", Descricao = "Descrição A Creatina Pura Dark Lab é a escolha número 1 para atletas e praticantes de musculação que buscam melhores resultados. Com 500g de poder puro, a Creatina Pura Dark Lab é a solução para aqueles que buscam aumentar sua força, resistência e explosão muscular.", ValorCusto = 15.83m, ValorVenda = 55.39m, QtdeEstoque = 39, Foto = "/img/produtos/2.png"},
            new Produto
            {Id = 4, Categoria = categorias[3], Nome = "Mochila Resistente Escolar Masculina Faculdade 15 Litros - Preto+Azul", Descricao = "Compartimento principal com amplo espaço interno que comporta cadernos, pastas e etc ", ValorCusto = 50.67m, ValorVenda = 94.97m, QtdeEstoque = 37, Foto = "/img/produtos/4.png"},
            new Produto
            {Id = 5, Categoria = categorias[4], Nome = "Blusão Nike Park Masculino - Cinza", Descricao = "TREINE COM AQUECIMENTO LEVE.O moletom com capuz Nike Park garante cobertura confortável em um fleece macio.", ValorCusto = 240.67m, ValorVenda = 347.56m, QtdeEstoque = 7, Foto = "/img/produtos/3.png"},
            new Produto
            {Id = 6, Categoria = categorias[1], Nome = "Camisa Vasco I 24/25 1974 Kappa Masculina - Preto+Branco", Descricao = "Vasco da Gama, minha paixão! Esta Camisa Vasco I 1974 Torcedor Kappa é daqueles mantos que não podem faltar no guarda-roupa do torcedor Cruzmaltino. Confeccionada em materiais de qualidade, a camisa do Vasco é uma homenagem aos 50 anos do primeiro título do Campeonato Brasileiro do clube, conquistado em 1974, quando bateu o Cruzeiro na final.", ValorCusto = 123.56m, ValorVenda = 207.07m, QtdeEstoque = 67, Foto = "/img/produtos/5.png"},
            new Produto
            {Id = 7, Categoria = categorias[1], Nome = "Camisa Milan 23/24 s/nº Pré-Jogo Puma Masculina - Vermelho+Preto", Descricao = "Mostre seu apoio pelo gigante italiano com a Camisa Milan 23/24 s/nº Pré-Jogo Puma Masculina! Utilizada pelos jogadores durante os aquecimentos antes do jogo, essa Camisa Milan masculina apresenta composto tecnológico Dry Cell que afasta o suor da pele e te mantém seco enquanto você joga ou assiste a bola correr. Compre já essa camisa do Milan!", ValorCusto = 111.67m, ValorVenda = 144.50m, QtdeEstoque = 98, Foto = "/img/produtos/7.png"},
            new Produto
            {Id = 8, Categoria = categorias[1], Nome = "Camisa Barcelona Dry Azul - Azul", Descricao = "Composição: 100% Poliéster Cor Predominante: Azul Indicada para: Treino Escudo: Estampado Gênero: Masculino Clube: Barcelona", ValorCusto = 58.11m, ValorVenda = 98.90m, QtdeEstoque = 54, Foto = "/img/produtos/6.png"},
            new Produto
            {Id = 9, Categoria = categorias[0], Nome = "Chuteira Puma Attacanto BDP Society Masculina - Azul", Descricao = "Composição cabedal (parte superior): Material sintético reforçado Palmilha: EVA e removível; facilita o momento da higienização Forro: Revestimento em têxtil com acolchoamento no calcanhar Solado: Borracha com micro travas fixas, colado", ValorCusto = 200.67m, ValorVenda = 247.12m, QtdeEstoque = 132, Foto = "/img/produtos/8.png"},        
        };

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

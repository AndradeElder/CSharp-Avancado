
using ProjetoEmTresCamadas.Pizzaria.DAO;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio;

PizzaDAO pizzaDAO = new PizzaDAO();



Console.WriteLine("Bem vindo a nossa pizzaria!");
Console.WriteLine("Gostaria de uma pizza? S para sim e N para não");
var resposta = Console.ReadLine();
Console.WriteLine(resposta);

if (resposta == "s")
{
    var pizza = new Pizza();
    Console.WriteLine("Qual o Sabor de pizza? Calabreza 'C' , Frango 'F' ?");
    var sabor = Console.ReadLine();
    Console.WriteLine(sabor);
    Console.WriteLine($"O sabor escolhido foi {pizza.DefinirSabor(sabor)}");
    Console.WriteLine("Qual o tamanho da pizza? Pequeno 'P', medio 'M', grande 'G'?");
    var tamanho = Console.ReadLine();
    Console.WriteLine($"O sabor escolhido foi {pizza.DefinirTamanho(tamanho)}");

    Console.WriteLine($"Sua pizza é {pizza}");
    pizzaDAO.CriaPizza( pizza );
}

var pizzas = pizzaDAO.ObterPizza;


Console.WriteLine("Fim!");
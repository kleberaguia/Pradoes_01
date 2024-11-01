// See https://aka.ms/new-console-template for more information
using AbstractFactory.BaseFactory;
using AbstractFactory.ConcreteFactory;
using AbstractFactory.FactoryLanchesMethods;
using CrossCutting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;


HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddInfraStructure(builder.Configuration);


Console.WriteLine("Escolha o Lanche : ");




Console.WriteLine("(1)Bauru  (2)Frango  (3)Misto Quente  (4)Vegetariano");
var lancheEscolhido = Convert.ToInt32(Console.ReadLine());
try
{

    // Le o appsettings e criar um objeto IConfiguration
 


    LanchesFactory factory = new LanchesFactory();
	Lanches lanche = factory.CriarLanches(lancheEscolhido);
    Console.WriteLine(lanche.Nome);

    foreach (var item in lanche.Ingredientes)
    {
        Console.WriteLine(item);
      
    }
    Console.WriteLine("\nLanche montado com sucesso");

}
catch (Exception ex)
{

    Console.WriteLine("Erro :" + ex.Message);
}

Console.ReadLine();
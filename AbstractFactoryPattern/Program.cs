using AbstractFactoryPattern.PizzaFactories;

namespace AbstractFactoryPattern;

public class Program
{
    public static void Main(string[] args)
    {
        var nyPizzaStore = new NYPizzaStore();
        nyPizzaStore.OrderPizza("veggie");

        Console.WriteLine("---------------------------------------------");

        var vegasPizzaStore = new VegasPizzaStore();
        vegasPizzaStore.OrderPizza("cheese");
    }
}
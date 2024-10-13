using FactoryMethodAdvanced.Factories;

namespace FactoryMethodAdvanced;

public class Program
{
    public static void Main(string[] args)
    {
        AbstractPizzaStore nyPizzaStore = new NYPizzaStore();
        nyPizzaStore.OrderPizza("veggie");

        Console.WriteLine("----------------------------------------------------------------------------------");

        AbstractPizzaStore vegasPizzaStore = new VegasPizzaStore();
        vegasPizzaStore.OrderPizza("cheese");
    }
}
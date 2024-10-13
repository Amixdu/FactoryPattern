using FactoryMethodPattern.ApproachOne;
using FactoryMethodPattern.ApproachTwo;

namespace FactoryMethodPattern;
public class Program
{
    public static void Main(string[] args)
    {
        // METHOD 1
        // Getting a NY style veggie pizza
        // NYPizzaFactory nyFactory = new(); 
        // PizzaStore nyStore = new(nyFactory);
        // nyStore.OrderPizza("veggie");

        // // Getting a Vegas style veggie pizza
        // VegasPizzaFactory vegasFactory = new();
        // PizzaStore vegasStore = new(vegasFactory);
        // vegasStore.OrderPizza("veggie");


        // METHOD 2
        // Getting a NY style veggie pizza
        NYPizzaStore nyStore = new();
        nyStore.OrderPizza("veggie");

        // Getting a Vegas style veggie pizza
        VegasPizzaStore vegasStore = new();
        vegasStore.OrderPizza("veggie");

    }
}

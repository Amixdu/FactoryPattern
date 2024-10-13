using FactoryMethodAdvanced.Pizzas;

namespace FactoryMethodAdvanced.Factories;

public class NYPizzaStore : AbstractPizzaStore
{
    protected override AbstractPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new NYCheesePizza(),
            "veggie" => new NYVeggiePizza(),
            _ => throw new NotSupportedException()
        };
    }
}
using FactoryMethodAdvanced.Pizzas;

namespace FactoryMethodAdvanced.Factories;

public class VegasPizzaStore : AbstractPizzaStore
{
    protected override AbstractPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new VegasCheesePizza(),
            "veggie" => new VegasVeggiePizza(),
            _ => throw new NotSupportedException()
        };
    }
}
using FactoryMethodPattern.Pizzas;

namespace FactoryMethodPattern.ApproachTwo;

// Concrete factory
public class VegasPizzaStore : AbstractPizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new VegasCheesePizza(),
            "veggie" => new VegasVeggiePizza(),
            _ => throw new NotSupportedException()
        };
    }
}
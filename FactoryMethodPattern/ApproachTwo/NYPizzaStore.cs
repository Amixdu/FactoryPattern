using FactoryMethodPattern.Pizzas;

namespace FactoryMethodPattern.ApproachTwo;

// Concrete factory
public class NYPizzaStore : AbstractPizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new NYCheesePizza(),
            "veggie" => new NYVeggiePizza(),
            _ => throw new NotSupportedException()
        };
    }
}
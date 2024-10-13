using FactoryMethodPattern.Pizzas;

namespace FactoryMethodPattern.ApproachOne;

class NYPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new NYCheesePizza(),
            "veggie" => new NYVeggiePizza(),
            _ => throw new NotSupportedException()
        };
    }
}
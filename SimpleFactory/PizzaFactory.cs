using SimpleFactory.Pizzas;

namespace SimpleFactory;

public class PizzaFactory
{
    public static IPizza CreatePizza(string franchise, string type)
    {
        return franchise switch
        {
            "NY" => type switch
            {
                "cheese" => new NYCheesePizza(),
                "veggie" => new NYVeggiePizza(),
                _ => throw new NotSupportedException()
            },
            "Vegas" => type switch
            {
                "cheese" => new VegasCheesePizza(),
                "veggie" => new VegasVeggiePizza(),
                _ => throw new NotSupportedException()
            },
            _ => throw new NotSupportedException()
        };
    }
}

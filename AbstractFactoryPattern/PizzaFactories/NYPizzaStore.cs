using AbstractFactoryPattern.IngredientFactories;
using AbstractFactoryPattern.Pizzas;

namespace AbstractFactoryPattern.PizzaFactories;

public class NYPizzaStore : AbstractPizzaStore
{
    private readonly NYIngredientFactory ingredientFactory = new();
    protected override AbstractPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new NYCheesePizza(ingredientFactory),
            "veggie" => new NYVeggiePizza(ingredientFactory),
            _ => throw new NotSupportedException()
        };
    }
}
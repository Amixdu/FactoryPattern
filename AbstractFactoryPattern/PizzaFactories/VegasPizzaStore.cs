using AbstractFactoryPattern.IngredientFactories;
using AbstractFactoryPattern.Pizzas;

namespace AbstractFactoryPattern.PizzaFactories;

public class VegasPizzaStore : AbstractPizzaStore
{
    private readonly VegasIngredientFactory ingredientFactory = new();
    protected override AbstractPizza CreatePizza(string type)
    {
        return type switch
        {
            "cheese" => new VegasCheesePizza(ingredientFactory),
            "veggie" => new VegasVeggiePizza(ingredientFactory),
            _ => throw new NotSupportedException()
        };
    }
}
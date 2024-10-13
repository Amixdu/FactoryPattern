using AbstractFactoryPattern.IngredientFactories;

namespace AbstractFactoryPattern.Pizzas;

public class NYCheesePizza(IIngredientFactory ingredientFactory) : AbstractPizza("NY-style Cheese Pizza", ingredientFactory.CreateDough(), ingredientFactory.CreateSauce(), ingredientFactory.CreteVeggies())
{
    public override void Bake()
    {
        Console.WriteLine("NY cheese Bake");
    }

    public override void Box()
    {
        Console.WriteLine("NY cheese Box");
    }
}
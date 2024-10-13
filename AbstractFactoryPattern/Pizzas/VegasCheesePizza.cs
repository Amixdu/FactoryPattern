using AbstractFactoryPattern.IngredientFactories;

namespace AbstractFactoryPattern.Pizzas;

public class VegasCheesePizza(IIngredientFactory ingredientFactory) : AbstractPizza("Vegas-style Cheese Pizza", ingredientFactory.CreateDough(), ingredientFactory.CreateSauce(), ingredientFactory.CreteVeggies())
{
    public override void Bake()
    {
        Console.WriteLine("Vegas cheese Bake");
    }

    public override void Box()
    {
        Console.WriteLine("Vegas cheese Box");
    }
}
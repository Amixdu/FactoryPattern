using AbstractFactoryPattern.IngredientFactories;

namespace AbstractFactoryPattern.Pizzas;

public class NYVeggiePizza(IIngredientFactory ingredientFactory) : AbstractPizza("NY-style veggie Pizza", ingredientFactory.CreateDough(), ingredientFactory.CreateSauce(), ingredientFactory.CreteVeggies())
{
    public override void Bake()
    {
        Console.WriteLine("NY veggie Bake");
    }

    public override void Box()
    {
        Console.WriteLine("NY veggie Box");
    }
}
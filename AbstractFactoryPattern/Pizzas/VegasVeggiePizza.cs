using AbstractFactoryPattern.IngredientFactories;

namespace AbstractFactoryPattern.Pizzas;

public class VegasVeggiePizza(IIngredientFactory ingredientFactory) : AbstractPizza("Vegas-style Cheese Pizza", ingredientFactory.CreateDough(), ingredientFactory.CreateSauce(), ingredientFactory.CreteVeggies())
{
    public override void Bake()
    {
        Console.WriteLine("Vegas veggie Bake");
    }

    public override void Box()
    {
        Console.WriteLine("Vegas veggie Box");
    }
}
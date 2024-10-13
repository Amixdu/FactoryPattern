namespace FactoryMethodAdvanced.Pizzas;

public class NYVeggiePizza() : AbstractPizza("NY-style Veggie Pizza", "Thin crust", "Tomato sauce", ["Tomatoes", "Mushroom"])
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
namespace FactoryMethodAdvanced.Pizzas;

public class VegasVeggiePizza() : AbstractPizza("Vegas-style Veggie Pizza", "Thick crust", "Hot sauce", ["Olives", "Mushroom"])
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
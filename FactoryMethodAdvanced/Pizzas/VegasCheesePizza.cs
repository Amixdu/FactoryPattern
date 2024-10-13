namespace FactoryMethodAdvanced.Pizzas;

public class VegasCheesePizza() : AbstractPizza("Vegas-style Cheese Pizza", "Thick crust", "White sauce", ["Pepper", "Capcium"])
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
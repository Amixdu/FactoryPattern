namespace FactoryMethodPattern.Pizzas;

public class VegasVeggiePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Vegas Veggie - Bake");
    }

    public void Box()
    {
        Console.WriteLine("Vegas Veggie - Box");
    }

    public void Cut()
    {
        Console.WriteLine("Vegas Veggie - Cut");
    }

    public void Prepare()
    {
        Console.WriteLine("Vegas Veggie - Prepare");
    }
}
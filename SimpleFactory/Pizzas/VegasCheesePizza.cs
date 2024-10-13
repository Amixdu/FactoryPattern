namespace SimpleFactory.Pizzas;

public class VegasCheesePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Vegas Cheese - Bake");
    }

    public void Box()
    {
        Console.WriteLine("Vegas Cheese - Box");
    }

    public void Cut()
    {
        Console.WriteLine("Vegas Cheese - Cut");
    }

    public void Prepare()
    {
        Console.WriteLine("Vegas Cheese - Prepare");
    }
}
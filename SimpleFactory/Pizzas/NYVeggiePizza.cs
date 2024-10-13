namespace SimpleFactory.Pizzas;

public class NYVeggiePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("NY Veggie - Bake");
    }

    public void Box()
    {
        Console.WriteLine("NY Veggie - Box");
    }

    public void Cut()
    {
        Console.WriteLine("NY Veggie - Cut");
    }

    public void Prepare()
    {
        Console.WriteLine("NY Veggie - Prepare");
    }
}
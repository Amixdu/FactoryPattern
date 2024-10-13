namespace SimpleFactory.Pizzas;

public class NYCheesePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("NY Cheese - Bake");
    }

    public void Box()
    {
        Console.WriteLine("NY Cheese - Box");
    }

    public void Cut()
    {
        Console.WriteLine("NY Cheese - Cut");
    }

    public void Prepare()
    {
        Console.WriteLine("NY Cheese - Prepare");
    }
}
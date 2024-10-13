namespace FactoryMethodAdvanced.Pizzas;

public class NYCheesePizza() : AbstractPizza("NY-style Cheese Pizza", "Thin crust", "Red sauce", ["Tomatoes", "Bell pepper"])
{
    public override void Bake()
    {
        Console.WriteLine("NY cheese Bake");
    }

    public override void Box()
    {
        Console.WriteLine("NY cheese Box");
    }
}
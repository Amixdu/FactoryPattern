namespace FactoryMethodAdvanced.Pizzas;

public abstract class AbstractPizza(string name, string dough, string sauce, List<string> toppings)
{
    public string Name { get; protected set; } = name;
    protected string Dough { get; set; } = dough;
    protected string Sauce { get; set; } = sauce;
    protected List<string> Toppings { get; set; } = toppings;

    public void Prepare()
    {
        Console.WriteLine($"Preparing: {Name}");
        Console.WriteLine($"Used dough: {Dough} ");
        Console.WriteLine($"Sauce added: {Sauce}");
        Console.WriteLine($"Toppings added: {string.Join(", ", Toppings)}");
    }

    public abstract void Bake();

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza");
    }

    public abstract void Box();
}
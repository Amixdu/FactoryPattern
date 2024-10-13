using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern.Pizzas;

public abstract class AbstractPizza(string name, IDough dough, ISauce sauce, List<IVeggie> veggies)
{
    public string Name { get; protected set; } = name;
    protected IDough Dough { get; set; } = dough;
    protected ISauce Sauce { get; set; } = sauce;
    protected List<IVeggie> Veggies { get; set; } = veggies;

    public void Prepare()
    {
        Console.WriteLine($"Preparing: {Name}");
        Console.WriteLine($"Used dough: {Dough.Name} ");
        Console.WriteLine($"Sauce added: {Sauce.Name}");
        Console.WriteLine($"Veggies added: {string.Join(", ", Veggies.Select(v => v.Name))}");
    }

    public abstract void Bake();

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza");
    }

    public abstract void Box();
}
using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern.IngredientFactories;

public class NYIngredientFactory : IIngredientFactory
{
    public IDough CreateDough()
    {
        return new ThinCrustDough("Thin-crust dough");
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce("Marinara sauce");
    }

    public List<IVeggie> CreteVeggies()
    {
        return [new Mushroom("Mushroom"), new Tomato("Tomato")];
    }
}

using System;
using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern.IngredientFactories;

public class VegasIngredientFactory : IIngredientFactory
{
    public IDough CreateDough()
    {
        return new ThickCrustDough("Thick-crust dough");
    }

    public ISauce CreateSauce()
    {
        return new RedSauce("Red sauce");
    }

    public List<IVeggie> CreteVeggies()
    {
        return [new Tomato("Tomato")];
    }
}

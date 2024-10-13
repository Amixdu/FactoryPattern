using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern.IngredientFactories;

public interface IIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public List<IVeggie> CreteVeggies();
}

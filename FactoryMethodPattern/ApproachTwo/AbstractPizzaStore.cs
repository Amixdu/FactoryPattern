namespace FactoryMethodPattern.ApproachTwo;

// This is the factory
public abstract class AbstractPizzaStore
{
    protected abstract IPizza CreatePizza(string type);

    // Common method that uses the created pizza
    public IPizza OrderPizza(string type)
    {
        IPizza pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
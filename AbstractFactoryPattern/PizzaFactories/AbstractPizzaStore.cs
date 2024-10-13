using AbstractFactoryPattern.Pizzas;

namespace AbstractFactoryPattern.PizzaFactories;

public abstract class AbstractPizzaStore
{
    protected abstract AbstractPizza CreatePizza(string type);
    public AbstractPizza OrderPizza(string type)
    {
        AbstractPizza pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
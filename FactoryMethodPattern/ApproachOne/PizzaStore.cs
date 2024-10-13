namespace FactoryMethodPattern.ApproachOne;

public class PizzaStore(IPizzaFactory pizzaFactory)
{
    public IPizza OrderPizza(string type)
    {
        IPizza pizza = pizzaFactory.CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
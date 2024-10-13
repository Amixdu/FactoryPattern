namespace FactoryMethodPattern.ApproachOne;

// Client code that uses the relevant factory and performs some actions on the created pizza
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
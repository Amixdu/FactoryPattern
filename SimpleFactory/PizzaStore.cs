namespace SimpleFactory;

// Client code that uses the simple factory and performs some actions on the created pizza
public class PizzaStore()
{
    public IPizza OrderPizza(string franchise, string type)
    {

        IPizza pizza = PizzaFactory.CreatePizza(franchise, type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
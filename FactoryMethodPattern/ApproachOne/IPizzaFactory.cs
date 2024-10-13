namespace FactoryMethodPattern.ApproachOne;

public interface IPizzaFactory
{
    IPizza CreatePizza(string type);
}
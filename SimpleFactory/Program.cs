namespace SimpleFactory;
public class Program
{
    public static void Main(string[] args)
    {
        var store = new PizzaStore();

        // Getting a NY style veggie pizza
        store.OrderPizza("NY", "veggie");

        // Getting a Vegas style veggie pizza
        store.OrderPizza("Vegas", "veggie");
    }
}
